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
        private XDocument? _targetBodyXml;
        private string _outputDirectory;
        private readonly ProgressBar _progressBar;

        public PowerMorphGenerator(FormMain formMain, ToolTip sharedToolTip, ProgressBar progressBar) {
            _formMain = formMain;
            _controlsCommander = new ControlsCommander(_formMain, sharedToolTip);
            _labelsWorker = new LabelsWorker(_formMain, sharedToolTip);
            _visualIndicatorController = new VisualIndicatorController(_formMain, sharedToolTip);
            _bodyXmls = new List<XDocument>();
            _targetBodyXml = new XDocument();
            _outputDirectory = string.Empty;
            _progressBar = progressBar;
        }

        public void SetBodyXmls(List<XDocument> bodyXmls) {
            _bodyXmls = bodyXmls;
        }

        public void SetTargetBodyPreset(XDocument targetBodyPreset) {
            _targetBodyXml = targetBodyPreset;
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
                    _labelsWorker.SetLabelInfoTextAlt("lblGeneratorState", "Ready!", "Hit the 'Generate BodyGen Files' button to begin!");
                }
            }
        }

        public string GetOutputDirectory() {
            return _outputDirectory;
        }

        // Generate BodyGen files - master logic:
        public async Task GenerateBodyGenFilesAsync(string sizeFilter, double deviation, bool disablePlayerMorphs, string selectedPlayerMorphsPreset, bool writeUniqueNpcLines, BodyLoader bodyLoader) {
            // work start
            _visualIndicatorController.SetPbWorking("pbGeneratorState");
            _progressBar.Minimum = 0;
            _progressBar.Value = 0;
            int totalPresets = _bodyXmls.Sum(xmlDoc => xmlDoc.Descendants("Preset").Count());
            _progressBar.Maximum = totalPresets * 2;

            var progress = new Progress<string>(message => {
                _progressBar.Value += 1;
                _labelsWorker.SetLabelInfoTextAlt("lblGeneratorState", $"Processing...", "Generating files, please wait...");
            });

            try {
                await Task.Run(() => {
                    GenerateMorphsIni(progress, sizeFilter, disablePlayerMorphs, selectedPlayerMorphsPreset, writeUniqueNpcLines);
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

            // Finally, check if default (target) body preset is loaded and enable the update group:
            if (bodyLoader.GetTargetBodyXml() != null) {
                _controlsCommander.EnableGroup("gbUpdateBodyGenFiles");
                
                // Disable patching if deviation has been used:
                if (Math.Abs(deviation) > 0.001) {
                    // Deviation used, disable patching:
                    _controlsCommander.DisableButton("btnUpdateBodyGenFiles");
                    _visualIndicatorController.SetPbNotOk("pbBodyGenUpdateState");
                    _visualIndicatorController.SetPbCaption("pbBodyGenUpdateState", "Deviation used, patching disabled!");
                    MessageBox.Show("You've used deviation (randomness) while generating your new morphs.ini and templates.ini files. Patching is not possible for such cases.\n\nIf you generate new files without deviation, the patching process will become available.", "PowerMorph - Patching not allowed!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else {
                    // Deviation not used, enable patching:
                    _controlsCommander.EnableButton("btnUpdateBodyGenFiles");
                    _visualIndicatorController.SetPbPlus("pbBodyGenUpdateState");
                    _visualIndicatorController.SetPbCaption("pbBodyGenUpdateState", "PowerMorph Patcher is ready!");
                    
                    // Set label to target body name:
                    var targetPresetName = bodyLoader.GetTargetBodyXml()?.Descendants("Preset").FirstOrDefault()?.Attribute("name")?.Value;
                    if (!string.IsNullOrEmpty(targetPresetName)) {
                        _labelsWorker.SetLabelInfoTextAlt("lblUpdateTargetBodyName", targetPresetName, "The name of your selected target body preset");
                    }
                }
            }
        }

        // morphs.ini generation:
        public void GenerateMorphsIni(IProgress<string> progress, string sizeFilter, bool disablePlayerMorphs, string selectedPlayerMorphsPreset, bool writeUniqueNpcLines) {
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
                morphsFileBuilder.AppendLine(string.Join("|", presetNames));
            }

            // Add lines for Player:
            morphsFileBuilder.AppendLine("\n# Female Player"); // ini comment
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

            // Lines (comments) for Unique NPCs (companions, but can be any actor). These are the most important ones to me:
            if (writeUniqueNpcLines) {
                morphsFileBuilder.AppendLine("\n# Cait");
                morphsFileBuilder.AppendLine("# Fallout4.esm|79249=[enter_desired_preset_name]");
                morphsFileBuilder.AppendLine("\n# Curie (Synth)");
                morphsFileBuilder.AppendLine("# Fallout4.esm|1647C6=[enter_desired_preset_name]");
                morphsFileBuilder.AppendLine("\n# Piper");
                morphsFileBuilder.AppendLine("# Fallout4.esm|2F1E=[enter_desired_preset_name]");
                morphsFileBuilder.AppendLine("\n# R4-04 (Tales From the Commonwealth)");
                morphsFileBuilder.AppendLine("# 3DNPC_FO4.esp|4356=[enter_desired_preset_name]");
                morphsFileBuilder.AppendLine("\n# Ivy (Companion Ivy V6)");
                morphsFileBuilder.AppendLine("# CompanionIvy.esm|0803=[enter_desired_preset_name]");
                morphsFileBuilder.AppendLine("\n# Heather (Heather V2)");
                morphsFileBuilder.AppendLine("# llamaCompanionHeatherv2.esp|AB33=[enter_desired_preset_name]");
                morphsFileBuilder.AppendLine("\n# Ellen (Ellen The Cartographer)");
                morphsFileBuilder.AppendLine("# ellen.esp|1002=[enter_desired_preset_name]");
                morphsFileBuilder.AppendLine("\n# Female Assistant (Gun For Hire)");
                morphsFileBuilder.AppendLine("# Flashy_CrimeAndPunishment_GunForHire_Addon.esp|45AD=[enter_desired_preset_name]");
            }

            using (var morphsFile = new StreamWriter(morphsIniPath, false, Encoding.Default)) {
                morphsFile.Write(morphsFileBuilder.ToString());
            }
        }

        public void GenerateTemplatesIni(IProgress<string> progress, string sizeFilter, double deviation) {
            string templatesIniPath = Path.Combine(_outputDirectory, "templates.ini");

            using (var templatesFile = new StreamWriter(templatesIniPath, false, Encoding.Default)) {
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

        // Logic for updating:
        public async Task UpdateTemplatesIniForDefaultBodyAsync(BodyLoader bodyLoader, string sizeFilter, IProgress<int> progress) {
            if (_targetBodyXml == null) {
                MessageBox.Show("No target body preset XML loaded!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string templatesIniPath = Path.Combine(_outputDirectory, "templates.ini");
            if (!File.Exists(templatesIniPath)) {
                MessageBox.Show("No templates.ini file found in the output directory!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try {
                var defaultSliders = bodyLoader.ParseDefaultBodyPreset();
                var templatesData = File.ReadAllLines(templatesIniPath);
                var updatedTemplatesData = new List<string>();

                int totalLines = templatesData.Length;
                int processedLines = 0;

                foreach (var line in templatesData) {
                    if (string.IsNullOrEmpty(line) || !line.Contains('=')) {
                        updatedTemplatesData.Add(line);
                        // continue;
                    } else {
                        var parts = line.Split('=', 2);
                        var presetName = parts[0].Trim();
                        var slidersPart = parts[1];

                        var presetXml = FindPresetXmlByName(presetName);
                        if (presetXml == null) {
                            // not found, keep it as-is:
                            updatedTemplatesData.Add(line);
                            // continue;
                        } else {
                            var presetSliders = ParsePresetSliders(presetXml, sizeFilter);
                            var adjustedSliders = ComputeAdjustedSliders(presetSliders, defaultSliders);

                            // Build updated sliders line:
                            var sliderEntries = adjustedSliders.Select(s => $"{s.Key}@{s.Value:0.##}");
                            var updatedSlidersLine = $"{presetName}={string.Join(", ", sliderEntries)}";

                            updatedTemplatesData.Add(updatedSlidersLine);
                        }
                    }

                    processedLines++;
                    progress.Report(processedLines);
                }

                await File.WriteAllLinesAsync(templatesIniPath, updatedTemplatesData);
                MessageBox.Show("BodyGen files have been updated successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) {
                MessageBox.Show($"An error occurred during the update of BodyGen files:\n{ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper - parse sliders from a preset XML:
        private Dictionary<string, double> ParsePresetSliders(XDocument presetXml, string sizeFilter) {
            var sliders = new Dictionary<string, double>();
            var presetElement = presetXml.Descendants("Preset").FirstOrDefault();
            if (presetElement == null) {
                return sliders;
            }

            var sliderElements = presetElement.Descendants("SetSlider");
            if (!string.IsNullOrEmpty(sizeFilter)) {
                sliderElements = sliderElements.Where(s => s.Attribute("size")?.Value?.Equals(sizeFilter, StringComparison.OrdinalIgnoreCase) == true);
            }

            foreach (var slider in sliderElements) {
                string sliderName = slider.Attribute("name")?.Value!;
                if (string.IsNullOrEmpty(sliderName)) {
                    continue;
                }

                if (double.TryParse(slider.Attribute("value")?.Value, out double sliderValue)) {
                    sliders[sliderName] = sliderValue;
                }
            }

            return sliders;
        }

        // Helper - find preset XML by name:
        private XDocument? FindPresetXmlByName(string presetName) {
            foreach (var xmlDoc in _bodyXmls) {
                var presetElement = xmlDoc.Descendants("Preset").FirstOrDefault(p => p.Attribute("name")?.Value == presetName);
                if (presetElement != null) {
                    return new XDocument(presetElement);
                }
            }

            return null;
        }

        // Compute adjusted sliders:
        private Dictionary<string, double> ComputeAdjustedSliders(Dictionary<string, double> presetSliders, Dictionary<string, double> defaultSliders) {
            var adjustedSliders = new Dictionary<string, double>();
            var sliderNames = new HashSet<string>(presetSliders.Keys.Concat(defaultSliders.Keys));

            foreach (var sliderName in sliderNames) {
                presetSliders.TryGetValue(sliderName, out double presetValue);
                defaultSliders.TryGetValue(sliderName, out double defaultValue);

                double adjustedValue = (presetValue - defaultValue) / 100.0;
                adjustedSliders[sliderName] = adjustedValue;
            }

            return adjustedSliders;
        }
    }
}
