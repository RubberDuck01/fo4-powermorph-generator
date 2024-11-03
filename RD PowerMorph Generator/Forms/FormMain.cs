using RD_PowerMorph_Generator.Helpers;

namespace RD_PowerMorph_Generator
{
    public partial class FormMain : Form {
        private readonly GroupsCommander _groupsCommander;
        private readonly HelpButtonsManager _helpButtonsManager;
        private readonly VisualIndicatorController _visualIndicatorController;

        public FormMain() {
            InitializeComponent();

            // Initialize GroupsCommander:
            _groupsCommander = new GroupsCommander(this);
            _groupsCommander.SetInitialGroupBoxStates();

            // Initialize VisualIndicatorController:
            _visualIndicatorController = new VisualIndicatorController(this);
            _visualIndicatorController.SetInitial();

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
