using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RD_PowerMorph_Generator.Helpers {
    internal class LabelsWorker {
        // Handles all label text
        private readonly FormMain _formMain;
        private readonly ToolTip _toolTip;

        public LabelsWorker(FormMain formMain, ToolTip sharedToolTip) {
            _formMain = formMain;
            _toolTip = sharedToolTip;
        }

        public void SetInitialLabelCaptions() {
            // TODO: Set initial label captions
            SetLabelCaption("lblVer", "Current version is 1.0.0 (XX/Nov/2024)");
            SetLabelCaption("lblXmlsPath", "Path to all your body preset XML files");
            SetLabelCaption("lblDefaultBodyPresetPath", "Path to your target (default) body preset XML file");
            SetLabelCaption("lblInfoTotalXmls", "Number of detected body preset XMLs in selected directory");
            SetLabelCaption("lblInfoDefaultBodyName", "Name of your selected default body preset XML");
            SetLabelCaption("lblInfoGeneratorOutputPath", "Path to the output directory for generated BodyGen files");
            SetLabelCaption("lblGeneratorOutputPath", "Path to the output directory for generated BodyGen files");
            SetLabelCaption("lblGeneratorState", "Current state of the BodyGen generator");
            SetLabelCaption("lblUpdateTargetBodyName", "Name of the target body preset XML for BodyGen files patching");
        }

        public void SetLabelCaption(string lblName, string lblCaption) {
            var label = _formMain.Controls.Find(lblName, true).FirstOrDefault() as Label;
            if (label != null) {
                _toolTip.SetToolTip(label, lblCaption);
            }
        }

        public void SetCheckBoxCaption(string chkName, string chkCaption) {
            var checkBox = _formMain.Controls.Find(chkName, true).FirstOrDefault() as CheckBox;
            if (checkBox != null) {
                _toolTip.SetToolTip(checkBox, chkCaption);
            }
        }

        public void SetComboBoxCaption(string cmbName, string cmbCaption) {
            var comboBox = _formMain.Controls.Find(cmbName, true).FirstOrDefault() as ComboBox;
            if (comboBox != null) {
                _toolTip.SetToolTip(comboBox, cmbCaption);
            }
        }

        public void SetLabelPathOk(string lblName, string txtPath) {
            var label = _formMain.Controls.Find(lblName, true).FirstOrDefault() as Label;
            if (label != null) {
                string displayPath = TrimPath(txtPath, 50);
                label.Text = displayPath;
                label.ForeColor = System.Drawing.Color.Green;
                _toolTip.SetToolTip(label, txtPath);
            }
        }

        private string TrimPath(string path, int maxLen) {
            if (path.Length <= maxLen) {
                return path;
            }

            string start = path.Substring(0, 15);
            string end = path.Substring(path.Length - 15, 15);
            return $"{start}...{end}";
        }

        public void SetLabelInfoText(string lblName, string lblText, string lblCaption) {
            var label = _formMain.Controls.Find(lblName, true).FirstOrDefault() as Label;
            if (label != null) {
                label.Text = lblText;
                label.ForeColor = System.Drawing.Color.Green;
                _toolTip.SetToolTip(label, lblCaption);
            }
        }

        public void SetLabelInfoTextAlt(string lblName, string lblText, string lblCaption) {
            var label = _formMain.Controls.Find(lblName, true).FirstOrDefault() as Label;
            if (label != null) {
                label.Text = lblText;
                label.ForeColor = System.Drawing.Color.Blue;
                _toolTip.SetToolTip(label, lblCaption);
            }
        }
    }
}
