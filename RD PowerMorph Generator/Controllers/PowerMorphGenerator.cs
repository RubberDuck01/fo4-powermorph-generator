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
        public async Task GenerateBodyGenFilesAsync(string sizeFilter, double deviation, bool disablePlayerMorphs, string selectedPlayerMorphsPreset) {
            // work start
            _visualIndicatorController.SetPbWorking("pbGeneratorState");
            _progressBar.Minimum = 0;
            _progressBar.Value = 0;
            int totalPresets = _bodyXmls.Sum(xmlDoc => xmlDoc.Descendants("Preset").Count());
            _progressBar.Maximum = totalPresets * 2;

            var progress = new Progress<string>(message => {
                _progressBar.Value += 1;
                _labelsWorker.SetLabelInfoTextAlt("lblGeneratorState", $"Processing: {message}", "Generating files, please wait...");
            });

            try {
                await Task.Run(() => {
                    GenerateMorphsIni(progress, sizeFilter, disablePlayerMorphs, selectedPlayerMorphsPreset);
                    GenerateTemplatesIni(progress, sizeFilter, deviation);
                });
            } catch (Exception ex) {
                MessageBox.Show($"An error occurred during the generation of BodyGen files:\n{ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _visualIndicatorController.SetPbNotOk("pbGeneratorState");
                _labelsWorker.SetLabelInfoText("lblGeneratorState", "Generator error!", "An error occurred during the generation of BodyGen files.");
                return;
            }

            // work completed:
            _visualIndicatorController.SetPbOk("pbGeneratorState");
            _visualIndicatorController.SetPbCaption("pbGeneratorState", "BodyGen files generation finished!");
            _labelsWorker.SetLabelInfoText("lblGeneratorState", "Generator finished!", "All BodyGen files generated successfully!");
            _progressBar.Value = _progressBar.Maximum;
            MessageBox.Show($"Done! Generated new BodyGen files for all {totalPresets} body presets!", "RD PowerMorph Generator - Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // if target body is loaded, and generator finished successfully, enable the update group:
            // _controlsCommander.EnableGroup("gbUpdateBodyGenFiles");
        }

        // morphs.ini generation:
        public void GenerateMorphsIni(IProgress<string> progress, string sizeFilter, bool disablePlayerMorphs, string selectedPlayerMorphsPreset) {
            string morphsIniPath = Path.Combine(_outputDirectory, "morphs.ini");
            var morphsFileBuilder = new StringBuilder();
            morphsFileBuilder.Append("All|Female|HumanRace=");

            var presetNames = new List<string>();
            foreach (var xmlDoc in _bodyXmls) {
                var presetList = xmlDoc.Descendants("Preset");

                foreach (var preset in presetList) {
                    string? presetName = preset.Attribute("name")?.Value;
                    if (string.IsNullOrEmpty(presetName)) {
                        continue;
                    }

                    var sliderList = preset.Descendants("SetSlider").Where(slider => slider.Attribute("size")?.Value?.ToLower() == sizeFilter.ToLower()).ToList();
                    if (sliderList.Count == 0) {
                        continue;
                    }

                    presetNames.Add(presetName);
                    progress.Report(presetName);
                }
            }

            if (presetNames.Any()) {
                morphsFileBuilder.AppendLine(string.Join(", ", presetNames));
            }

            // Add lines for Player:
            morphsFileBuilder.AppendLine("# FemalePlayer"); // ini comment
            if (disablePlayerMorphs) {
                // Exclude Player from morphs:
                morphsFileBuilder.AppendLine("Fallout4.esm|7=[exclude_from_bodygen]");
            } else {
                // If not-target preset specified for Player, use random (disable the line):
                if (selectedPlayerMorphsPreset == "(Random body preset)") {
                    morphsFileBuilder.AppendLine($"# Fallout4.esm|7=(Disabled - Randomized)");
                } else {
                    // Set it to desired preset:
                    morphsFileBuilder.AppendLine($"Fallout4.esm|7={selectedPlayerMorphsPreset}");
                }
            }

            using (var morphsFile = new StreamWriter(morphsIniPath, false, Encoding.UTF8)) {
                morphsFile.Write(morphsFileBuilder.ToString());
            }
        }

        public void GenerateTemplatesIni(IProgress<string> progress, string sizeFilter, double deviation) {
            string templatesIniPath = Path.Combine(_outputDirectory, "templates.ini");

            using (var templatesFile = new StreamWriter(templatesIniPath, false, Encoding.UTF8)) {
                foreach (var xmlDoc in _bodyXmls) {
                    var presetList = xmlDoc.Descendants("Preset");

                    foreach (var preset in presetList) {
                        string? presetName = preset.Attribute("name")!.Value;
                        if (string.IsNullOrEmpty(presetName)) {
                            continue;
                        }

                        var sliderList = preset.Descendants("SetSlider").Where(slider => slider.Attribute("size")?.Value?.ToLower() == sizeFilter.ToLower()).ToList();
                        if (sliderList.Count == 0) {
                            continue;
                        }

                        templatesFile.Write($"{presetName}=");
                        List<string> sliderDataList = new List<string>();

                        foreach (var slider in sliderList) {
                            string? sliderName = slider.Attribute("name")?.Value;
                            if (string.IsNullOrEmpty(sliderName)) {
                                continue;
                            }

                            if (!double.TryParse(slider.Attribute("value")?.Value, out double value)) {
                                continue;
                            }

                            // Apply deviation:
                            double val_dev_neg = value - deviation;
                            double val_dev_pos = value + deviation;

                            val_dev_neg = Math.Max(Math.Min(val_dev_neg, 100), 0);
                            val_dev_pos = Math.Max(Math.Min(val_dev_pos, 100), 0);

                            // double v = value / 100.0;
                            // string sliderData = $"{sliderName}@{v}";

                            string sliderData;
                            if (Math.Abs(deviation) < 0.001) {
                                // No deviation:
                                double v = value / 100.0;
                                sliderData = $"{sliderName}@{v}";
                            } else {
                                // With deviation, val range:
                                double val_neg_normalized = val_dev_neg / 100.0;
                                double val_pos_normalized = val_dev_pos / 100.0;
                                sliderData = $"{sliderName}@{val_neg_normalized}:{val_pos_normalized}";
                            }

                            sliderDataList.Add(sliderData);
                        }

                        if (sliderDataList.Count == 0) {
                            continue;
                        }

                        // write:
                        templatesFile.WriteLine(string.Join(", ", sliderDataList));
                        progress.Report(presetName);
                    }
                }
            }
        }
    }
}
