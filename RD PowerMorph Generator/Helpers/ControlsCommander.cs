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

        public ControlsCommander(FormMain formMain, ToolTip sharedToolTip) {
            _formMain = formMain;
            _visualIndicatorController = new VisualIndicatorController(_formMain, sharedToolTip);
            _labelsWorker = new LabelsWorker(_formMain, sharedToolTip);
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
            _visualIndicatorController.SetPbCaption("pbInisOutputDir", "Select the output directory for generated BodyGen files");
            _visualIndicatorController.SetPbNotOk("pbGeneratorState");
            _visualIndicatorController.SetPbCaption("pbGeneratorState", "Generator not ready because output directory is not set");
            _labelsWorker.SetLabelCaption("lblBigSmallFilter", "Specify the desired size filter used for getting values from body XML presets.\nIf you're unsure about this, leave it on default ('Big'). For more info, check the Wiki on GitHub!");
            _labelsWorker.SetLabelCaption("lblRandomFilter", "Allows you to apply random values for your body presets during initial generation.\nLeave it empty or at 0 to disable.\nNOT RECOMMENDED to use if you later want to patch the files for integration with your own body preset!");
            _labelsWorker.SetCheckBoxCaption("cbWriteUniqueNpcLines", "When checked (Enabled), the PowerMorph Generator will write some extra lines\nfor specifying the bodies of some Unique NPCs. This will NOT affect\nthe generation process. All the extra lines are commented - meaning they are disabled\nand you'll have to manually edit the morphs.ini file to uncomment (enable) them.");
            _labelsWorker.SetCheckBoxCaption("cbDisableMorphsPlayer", "When checked (Disabled), the Player's body will be excluded from BodyGen.\nWhen unchecked (Enabled), the Player may get a random body morphs.\nUse at your own risk.");
        }
    }
}
