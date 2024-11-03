using RD_PowerMorph_Generator.Controllers;
using RD_PowerMorph_Generator.Helpers;

namespace RD_PowerMorph_Generator
{
    public partial class FormMain : Form {
        private readonly ControlsCommander _controlsCommander;
        private readonly HelpButtonsManager _helpButtonsManager;
        private readonly VisualIndicatorController _visualIndicatorController;
        private readonly BodyLoader _bodyLoader;

        public FormMain() {
            InitializeComponent();

            // Initialize ControlsCommander:
            _controlsCommander = new ControlsCommander(this);
            _controlsCommander.SetInitialGroupBoxStates();

            // Initialize VisualIndicatorController:
            _visualIndicatorController = new VisualIndicatorController(this);
            _visualIndicatorController.SetInitial();

            // Initialize the HelpButtonsManager:
            _helpButtonsManager = new HelpButtonsManager();
            btnHelpLoadXmls.Click += (sender, e) => ShowHelpMessage(1);
            btnHelpGenerate.Click += (sender, e) => ShowHelpMessage(2);
            btnHelpUpdate.Click += (sender, e) => ShowHelpMessage(3);
            btnHelpLoadedXmlsData.Click += (sender, e) => ShowHelpMessage(4);

            // Initialize the BodyLoader:
            _bodyLoader = new BodyLoader(this);
        }

        private void ShowHelpMessage(int btnId) {
            _helpButtonsManager.ShowHelpMessage(btnId);
        }

        private void btnXmlsLoad_Click(object sender, EventArgs e) {
            _bodyLoader.LoadXmlsFromDirectory();
        }
    }
}
