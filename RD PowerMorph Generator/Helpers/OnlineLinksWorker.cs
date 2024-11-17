using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RD_PowerMorph_Generator.Helpers;

namespace RD_PowerMorph_Generator.Helpers {
    internal class OnlineLinksWorker {
        private readonly FormMain _formMain;
        private readonly ToolTip _toolTip;
        private readonly VisualIndicatorController _visualIndicatorController;

        public OnlineLinksWorker(FormMain formMain) {
            _formMain = formMain;
            _toolTip = new ToolTip();
            _visualIndicatorController = new VisualIndicatorController(_formMain);
        }

        public void SetAllOnlineLinks() {
            SetGithubLink();
            SetNexusLink();
            SetKoFiLink();
        }

        public void SetGithubLink() {
            _visualIndicatorController.SetPbCaption("pbGitHub", "Check the source code on GitHub");
        }

        public void SetNexusLink() {
            _visualIndicatorController.SetPbCaption("pbNexus", "Visit mod page on Nexus");
        }

        public void SetKoFiLink() {
            _visualIndicatorController.SetPbCaption("pbKoFi", "Like this tool? Consider buying me a Ko-Fi!");
        }

        public void OpenGithubLink() {
            Process.Start(new ProcessStartInfo {
                FileName = "https://github.com/RubberDuck01/fo4-powermorph-generator",
                UseShellExecute = true
            });
        }

        public void OpenNexusLink() {
            Process.Start(new ProcessStartInfo {
                FileName = "https://www.nexusmods.com/fallout4/mods/50476",
                UseShellExecute = true
            });
        }

        public void OpenKoFiLink() {
            Process.Start(new ProcessStartInfo {
                FileName = "https://ko-fi.com/rubberduck01",
                UseShellExecute = true
            });
        }
    }
}
