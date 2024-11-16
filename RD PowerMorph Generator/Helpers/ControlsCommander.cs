using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RD_PowerMorph_Generator.Helpers {
    internal class ControlsCommander {
        private readonly FormMain _formMain;
        private readonly VisualIndicatorController _visualIndicatorController;
        private readonly LabelsWorker _labelsWorker;

        public ControlsCommander(FormMain formMain) {
            _formMain = formMain;
            _visualIndicatorController = new VisualIndicatorController(_formMain);
            _labelsWorker = new LabelsWorker(_formMain);
        }

        public void EnableButton(string btnName) {
            var button = _formMain.Controls.Find(btnName, true).FirstOrDefault() as Button;
            if (button != null)
            {
                button.Enabled = true;
            }
        }

        public void DisableButton(string btnName) {
            var button = _formMain.Controls.Find(btnName, true).FirstOrDefault() as Button;
            if (button != null) {
                button.Enabled = false;
            }
        }

        public void EnableGroup(string groupName) {
            var group = _formMain.Controls.Find(groupName, true).FirstOrDefault() as GroupBox;
            if (group != null) {
                group.Enabled = true;
            }
        }

        public void DisableGroup(string groupName) {
            var group = _formMain.Controls.Find(groupName, true).FirstOrDefault() as GroupBox;
            if (group != null) {
                group.Enabled = false;
            }
        }

        public void SetInitialGroupBoxStates() {
            foreach (Control control in _formMain.Controls) {
                if (control is GroupBox gb) {
                    if (gb.Name != "gbLoadXmlsControls") {
                        gb.Enabled = false;
                    }
                }
            }
        }

        public void EnableApplicationDataGroupBox(string targetBodyXmlName) {
            EnableGroup("gbAppLoadData");
            _labelsWorker.SetLabelInfoText("lblInfoDefaultBodyName", targetBodyXmlName, "The name of your selected default body preset XML.");
        }
        
        public void EnableGenerateGroupBox(int totalXmlsCount) {
            EnableGroup("gbAppLoadData");
            EnableGroup("gbGenerateBodyGenFiles");
            _labelsWorker.SetLabelInfoText("lblInfoTotalXmls", totalXmlsCount.ToString(), $"The selected directory contains {totalXmlsCount} BodySlide slider preset(s).");
            _visualIndicatorController.SetPbOk("pbXmlsLoadStatus");
            _visualIndicatorController.SetPbNotOk("pbInisOutputDir");
            _visualIndicatorController.SetPbNotOk("pbGeneratorState");
        }
    }
}
