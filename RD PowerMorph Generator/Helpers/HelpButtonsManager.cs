using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RD_PowerMorph_Generator.Helpers
{
    internal class HelpButtonsManager {
        internal void ShowHelpMessage(int btnId) {
            string helpText = btnId switch {
                1 => HelpTextProvider.HelpLoadXmls(),
                2 => HelpTextProvider.HelpGenerate(),
                3 => HelpTextProvider.HelpUpdate(),
                4 => HelpTextProvider.HelpLoadedXmlsData(),
                _ => "No help available for this button."
            };

            MessageBox.Show(helpText, "PowerMorph Generator - Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
