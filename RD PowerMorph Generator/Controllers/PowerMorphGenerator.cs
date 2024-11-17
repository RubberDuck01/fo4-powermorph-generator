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

        public PowerMorphGenerator(FormMain formMain, ToolTip sharedToolTip) {
            _formMain = formMain;
            _controlsCommander = new ControlsCommander(_formMain, sharedToolTip);
            _labelsWorker = new LabelsWorker(_formMain, sharedToolTip);
            _visualIndicatorController = new VisualIndicatorController(_formMain, sharedToolTip);
            _bodyXmls = new List<XDocument>();
            _outputDirectory = string.Empty;
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
        public void GenerateBodyGenFiles() {

        }
    }
}
