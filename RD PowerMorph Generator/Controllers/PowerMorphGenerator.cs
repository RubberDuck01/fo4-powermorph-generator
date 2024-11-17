using RD_PowerMorph_Generator.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RD_PowerMorph_Generator.Controllers {
    internal class PowerMorphGenerator {
        private readonly FormMain _formMain;
        private readonly ControlsCommander _controlsCommander;
        private readonly LabelsWorker _labelsWorker;
        private readonly VisualIndicatorController _visualIndicatorController;
        private List<XDocument> _bodyXmls;
        private string _outputDirectory;
        private readonly ProgressBar _progressBar;

        public PowerMorphGenerator(FormMain formMain, ToolTip sharedToolTip, ProgressBar progressBar) {
            _formMain = formMain;
            _controlsCommander = new ControlsCommander(_formMain, sharedToolTip);
            _labelsWorker = new LabelsWorker(_formMain, sharedToolTip);
            _visualIndicatorController = new VisualIndicatorController(_formMain, sharedToolTip);
            _bodyXmls = new List<XDocument>();
            _outputDirectory = string.Empty;
            _progressBar = progressBar;
        }

        public void SetBodyXmls(List<XDocument> bodyXmls) {
            _bodyXmls = bodyXmls;
        }

        // Set output dir:
        public void SetOutputDirectory() {
            using (var folderBrowserDialog = new FolderBrowserDialog()) {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK) {
                    _outputDirectory = folderBrowserDialog.SelectedPath;
                    MessageBox.Show($"Output directory set to:\n{_outputDirectory}", "Output directory set!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _labelsWorker.SetLabelPathOk("lblGeneratorOutputPath", _outputDirectory);
                    _labelsWorker.SetLabelPathOk("lblInfoGeneratorOutputPath", _outputDirectory);
                    _visualIndicatorController.SetPbOk("pbInisOutputDir");
                    _visualIndicatorController.SetPbCaption("pbInisOutputDir", "Output directory set!");
                    
                    // Enable generator, indicating it's ready:
                    _controlsCommander.EnableButton("btnGenerateBodyGenFiles");
                    _visualIndicatorController.SetPbPlus("pbGeneratorState");
                    _visualIndicatorController.SetPbCaption("pbGeneratorState", "PowerMorph Generator is ready to rock!");
                    _labelsWorker.SetLabelInfoTextAlt("lblGeneratorState", "Ready! Waiting for user input...", "Hit the 'Generate BodyGen Files' button to begin!");
                }
            }
        }

        public string GetOutputDirectory() {
            return _outputDirectory;
        }

        // Generate BodyGen files - master logic:
        public async Task GenerateBodyGenFilesAsync() {
            // work start
            _visualIndicatorController.SetPbWorking("pbGeneratorState");
            _progressBar.Minimum = 0;
            _progressBar.Value = 0;
            int totalPresets = _bodyXmls.Sum(xmlDoc => xmlDoc.Descendants("Preset").Count());
            _progressBar.Maximum = totalPresets;

            var progress = new Progress<string>(message => {
                _progressBar.Value += 1;
                _labelsWorker.SetLabelInfoTextAlt("lblGeneratorState", $"Processing: {message}", "Generating files, please wait...");
            });

            await Task.Run(() => {
                GenerateMorphsIni(progress);
                GenerateTemplatesIni(progress);
            });

            // work completed:
            _visualIndicatorController.SetPbOk("pbGeneratorState");
            _labelsWorker.SetLabelInfoText("lblGeneratorState", "Generator finished!", "All BodyGen files generated successfully!");
            _progressBar.Value = _progressBar.Maximum;

            // if target body is loaded, and generator finished successfully, enable the update group:
            // _controlsCommander.EnableGroup("gbUpdateBodyGenFiles");

            // GenerateMorphsIni();
            // GenerateTemplatesIni();
        }

        // morphs.ini generation:
        public void GenerateMorphsIni(IProgress<string> progress) {
            string morphsIniPath = Path.Combine(_outputDirectory, "morphs.ini");
            bool morphsIniExists = File.Exists(morphsIniPath);

            using (var morphsFile = new StreamWriter(morphsIniPath, true, Encoding.UTF8)) {
                if (!morphsIniExists) {
                    morphsFile.WriteLine("All|Female|HumanRace=");
                }

                foreach (var xmlDoc in _bodyXmls) {
                    var presetList = xmlDoc.Descendants("Preset");

                    foreach (var preset in presetList) {
                        string presetName = preset.Attribute("name")!.Value;

                        if (string.IsNullOrEmpty(presetName)) {
                            continue;
                        }

                        morphsFile.WriteLine($"{presetName}|");
                        progress.Report(presetName);
                    }
                }
            }
        }

        public void GenerateTemplatesIni(IProgress<string> progress) {
            string templatesIniPath = Path.Combine(_outputDirectory, "templates.ini");

            using (var templatesFile = new StreamWriter(templatesIniPath, true, Encoding.UTF8)) {
                foreach (var xmlDoc in _bodyXmls) {
                    var presetList = xmlDoc.Descendants("Preset");

                    foreach (var preset in presetList) {
                        string presetName = preset.Attribute("name")!.Value;

                        if (string.IsNullOrEmpty(presetName)) {
                            continue;
                        }

                        templatesFile.Write($"{presetName}=");

                        var sliderList = preset.Descendants("SetSlider").ToList();
                        List<string> sliderDataList = new List<string>();

                        foreach (var slider in sliderList) {
                            string sliderName = slider.Attribute("name")!.Value;
                            if (string.IsNullOrEmpty(sliderName)) {
                                continue;
                            }

                            if (!double.TryParse(slider.Attribute("value")?.Value, out double value)) {
                                continue;
                            }

                            double v = value / 100.0;
                            string sliderData = $"{sliderName}@{v}";

                            sliderDataList.Add(sliderData);
                        }

                        // write:
                        templatesFile.WriteLine(string.Join(",", sliderDataList));
                        progress.Report(presetName);
                    }
                }
            }
        }
    }
}
