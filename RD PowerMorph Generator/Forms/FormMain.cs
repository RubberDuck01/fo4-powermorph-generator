using RD_PowerMorph_Generator.Helpers;

namespace RD_PowerMorph_Generator {
    public partial class FormMain : Form {
        private readonly HelpButtonsManager _helpButtonsManager;

        public FormMain() {
            InitializeComponent();

            // Initialize the HelpButtonsManager:
            _helpButtonsManager = new HelpButtonsManager();
            btnHelpLoadXmls.Click += (sender, e) => ShowHelpMessage(1);
            btnHelpGenerate.Click += (sender, e) => ShowHelpMessage(2);
            btnHelpUpdate.Click += (sender, e) => ShowHelpMessage(3);
            btnHelpLoadedXmlsData.Click += (sender, e) => ShowHelpMessage(4);
        }

        private void ShowHelpMessage(int btnId) {
            _helpButtonsManager.ShowHelpMessage(btnId);
        }
    }
}
