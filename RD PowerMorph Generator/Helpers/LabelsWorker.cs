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

        public LabelsWorker(FormMain formMain) {
            _formMain = formMain;
            _toolTip = new ToolTip();
        }

        public void SetInitialLabelCaptions() {

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
    }
}
