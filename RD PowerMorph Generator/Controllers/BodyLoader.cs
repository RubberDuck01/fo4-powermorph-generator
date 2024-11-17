using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using RD_PowerMorph_Generator.Helpers;

namespace RD_PowerMorph_Generator.Controllers {
    internal class BodyLoader {
        // Loads all the body preset XMLs as well as the target body preset
        private readonly FormMain _formMain;
        private readonly ControlsCommander _controlsCommander;
        private readonly LabelsWorker _labelsWorker;
        private readonly VisualIndicatorController _visualIndicatorController;
        private List<XDocument> _bodyXmls;
        private XDocument _targetBodyXml;

        public BodyLoader(FormMain formMain) {
            _formMain = formMain;
            _controlsCommander = new ControlsCommander(_formMain);
            _labelsWorker = new LabelsWorker(_formMain);
            _visualIndicatorController = new VisualIndicatorController(_formMain);
            _bodyXmls = new List<XDocument>();
            _targetBodyXml = new XDocument();
        }

        // Load all XMLs from target directory:
        public void LoadXmlsFromDirectory() {
            using (var foldersBrowserDialog = new FolderBrowserDialog()) {
                if (foldersBrowserDialog.ShowDialog() == DialogResult.OK) {
                    var dirPath = foldersBrowserDialog.SelectedPath;
                    var xmlFiles = Directory.GetFiles(dirPath, "*.xml");

                    _bodyXmls.Clear();
                    foreach (var file in xmlFiles) {
                        try {
                            var xmlDoc = XDocument.Load(file);
                            _bodyXmls.Add(xmlDoc);
                        } catch (Exception ex) {
                            MessageBox.Show($"Error loading XML file: {file}\n\n{ex.Message}", "Something went wrong...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    MessageBox.Show($"Loaded {_bodyXmls.Count} XML files.", "XMLs loaded!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _labelsWorker.SetLabelPathOk("lblXmlsPath", dirPath);
                    _controlsCommander.EnableGenerateGroupBox(_bodyXmls.Count);
                    _visualIndicatorController.SetPbCaption("pbXmlsLoadStatus", "Selected directory ok!");
                    _controlsCommander.DisableButton("btnGenerateBodyGenFiles");
                }
            }
        }

        public List<XDocument> GetAllBodyXmls() {
            return _bodyXmls;
        }

        // Load target (default) body XML:
        // this is for use with custom patching for bypassing zeroed-sliders body build
        public void LoadTargetBodyXml() {
            using (var openFileDialog = new OpenFileDialog()) {
                openFileDialog.Filter = "XML files (*.xml)|*.xml";
                openFileDialog.Title = "Load target (default) body XML file preset";

                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    var filePath = openFileDialog.FileName;

                    try {
                        _targetBodyXml = XDocument.Load(filePath);
                        MessageBox.Show($"Target body XML loaded successfully!\nFull path to XML:\n{filePath}", "Target body XML loaded!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _labelsWorker.SetLabelPathOk("lblDefaultBodyPresetPath", filePath);
                        _visualIndicatorController.SetPbOk("pbDefBodyLoad");
                        _visualIndicatorController.SetPbCaption("pbDefBodyLoad", "Target body preset XML loaded!");
                        _controlsCommander.EnableApplicationDataGroupBox(Path.GetFileName(filePath));
                    } catch (Exception ex) {
                        MessageBox.Show($"Error loading target body XML file: {filePath}\n\n{ex.Message}", "Something went wrong...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public XDocument GetTargetBodyXml() {
            return _targetBodyXml;
        }
    }
}
