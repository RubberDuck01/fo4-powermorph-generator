using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RD_PowerMorph_Generator.Controllers {
    internal class GroupsCommander {
        private readonly FormMain _formMain;

        public GroupsCommander(FormMain formMain) {
            _formMain = formMain;
        }

        public void EnableButton(string btnName) {
            var button = _formMain.Controls.Find(btnName, true).FirstOrDefault() as Button;
            if (button != null) {
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
    }
}
