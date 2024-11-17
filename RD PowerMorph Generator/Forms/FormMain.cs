using RD_PowerMorph_Generator.Controllers;
using RD_PowerMorph_Generator.Helpers;

namespace RD_PowerMorph_Generator
{
    public partial class FormMain : Form {
        private readonly ControlsCommander _controlsCommander;
        private readonly HelpButtonsManager _helpButtonsManager;
        private readonly VisualIndicatorController _visualIndicatorController;
        private readonly BodyLoader _bodyLoader;
        private readonly LabelsWorker _labelsWorker;
        private readonly OnlineLinksWorker _onlineLinksWorker;
        private readonly PowerMorphGenerator _powerMorphGenerator;
        private readonly ToolTip _sharedToolTip;

        public FormMain() {
            InitializeComponent();
            _sharedToolTip = new ToolTip();

            // Initialize ControlsCommander:
            _controlsCommander = new ControlsCommander(this, _sharedToolTip);
            _controlsCommander.SetInitialGroupBoxStates();

            // Initialize VisualIndicatorController:
            _visualIndicatorController = new VisualIndicatorController(this, _sharedToolTip);
            _visualIndicatorController.SetInitial();

            // Initialize LabelsWorker:
            _labelsWorker = new LabelsWorker(this, _sharedToolTip);
            _labelsWorker.SetInitialLabelCaptions();

            // Initialize the HelpButtonsManager:
            _helpButtonsManager = new HelpButtonsManager();
            btnHelpLoadXmls.Click += (sender, e) => ShowHelpMessage(1);
            btnHelpGenerate.Click += (sender, e) => ShowHelpMessage(2);
            btnHelpUpdate.Click += (sender, e) => ShowHelpMessage(3);
            btnHelpLoadedXmlsData.Click += (sender, e) => ShowHelpMessage(4);

            // Initialize the BodyLoader:
            _bodyLoader = new BodyLoader(this, _sharedToolTip);

            // Initialize the OnlineLinksWorker:
            _onlineLinksWorker = new OnlineLinksWorker(this, _sharedToolTip);
            _onlineLinksWorker.SetAllOnlineLinks();

            // Initialize the PowerMorphGenerator:
            _powerMorphGenerator = new PowerMorphGenerator(this, _sharedToolTip);
        }

        private void ShowHelpMessage(int btnId) {
            _helpButtonsManager.ShowHelpMessage(btnId);
        }

        private void btnXmlsLoad_Click(object sender, EventArgs e) {
            _bodyLoader.LoadXmlsFromDirectory();
        }

        private void btnLoadDefaultBody_Click(object sender, EventArgs e) {
            _bodyLoader.LoadTargetBodyXml();
        }

        // Events for custom buttons (Github, Nexus, Ko-Fi):
        private void pbGitHub_MouseEnter(object sender, EventArgs e) {
            var pbGitHub = sender as PictureBox;
            if (pbGitHub != null) {
                pbGitHub.Image = Properties.Resources.rd_github_hover;
            }
        }

        private void pbGitHub_MouseLeave(object sender, EventArgs e) {
            var pbGitHub = sender as PictureBox;
            if (pbGitHub != null) {
                pbGitHub.Image = Properties.Resources.rd_github_default;
            }
        }

        private void pbGitHub_MouseDown(object sender, MouseEventArgs e) {
            _onlineLinksWorker.OpenGithubLink();

            var pbGitHub = sender as PictureBox;
            if (pbGitHub != null) {
                pbGitHub.Image = Properties.Resources.rd_github_click;
            }
        }

        private void pbNexus_MouseEnter(object sender, EventArgs e) {
            var pbNexus = sender as PictureBox;
            if (pbNexus != null) {
                pbNexus.Image = Properties.Resources.rd_nexus_hover;
            }
        }

        private void pbNexus_MouseLeave(object sender, EventArgs e) {
            var pbNexus = sender as PictureBox;
            if (pbNexus != null) {
                pbNexus.Image = Properties.Resources.rd_nexus_default;
            }
        }

        private void pbNexus_MouseDown(object sender, MouseEventArgs e) {
            _onlineLinksWorker.OpenNexusLink();

            var pbNexus = sender as PictureBox;
            if (pbNexus != null) {
                pbNexus.Image = Properties.Resources.rd_nexus_click;
            }
        }

        private void pbKoFi_MouseEnter(object sender, EventArgs e) {
            var pbKoFi = sender as PictureBox;
            if (pbKoFi != null) {
                pbKoFi.Image = Properties.Resources.rd_kofi_hover;
            }
        }

        private void pbKoFi_MouseLeave(object sender, EventArgs e) {
            var pbKoFi = sender as PictureBox;
            if (pbKoFi != null) {
                pbKoFi.Image = Properties.Resources.rd_kofi_default;
            }
        }

        private void pbKoFi_MouseDown(object sender, MouseEventArgs e) {
            _onlineLinksWorker.OpenKoFiLink();

            var pbKoFi = sender as PictureBox;
            if (pbKoFi != null) {
                pbKoFi.Image = Properties.Resources.rd_kofi_click;
            }
        }

        private void btnSelectOutputDir_Click(object sender, EventArgs e) {
            _powerMorphGenerator.SetOutputDirectory();
        }
    }
}
