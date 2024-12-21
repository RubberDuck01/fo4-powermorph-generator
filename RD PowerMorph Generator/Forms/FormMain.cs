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
            _powerMorphGenerator = new PowerMorphGenerator(this, _sharedToolTip, pgBarGenerate);
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

        private async void btnGenerateBodyGenFiles_Click(object sender, EventArgs e) {
            // Get loaded body presets:
            _powerMorphGenerator.SetBodyXmls(_bodyLoader.GetAllBodyXmls());

            // Check if target body preset is loaded:
            /*
            if (_bodyLoader.GetTargetBodyXml() != null) {
                _powerMorphGenerator.SetTargetBodyPreset(_bodyLoader.GetTargetBodyXml());
            }
            */

            // Handle size filter:
            string sizeFilter = "big"; // default radio checked
            if (radioBtnFilterSmall.Checked) {
                sizeFilter = "small";
            } else if (radioBtnFilterBig.Checked) {
                sizeFilter = "big";
            }

            // Handle randomness (deviation):
            double deviation = 0.0; // default, when tbRandomFilter is empty
            string deviationText = tbRandomFilter.Text.Trim();

            if (string.IsNullOrEmpty(deviationText)) {
                deviation = 0.0; // empty

            } else if (!double.TryParse(deviationText, out deviation)) {
                MessageBox.Show("Uh-oh, something went wrong when getting deviation values...", "E1: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (deviation < 0 || deviation > 100) {
                MessageBox.Show("Randomness percentage (deviation) must be in range 0 to 100.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Handle Player morphs:
            bool disablePlayerMorphs = cbDisableMorphsPlayer.Checked; // true/checked = no player morphs, false/unchecked = player morphs
            string? selectedPlayerMorphPreset = null;

            if (!disablePlayerMorphs) {
                selectedPlayerMorphPreset = cboxPlayerMorphs.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(selectedPlayerMorphPreset)) {
                    MessageBox.Show("Please select a player morph preset or check the 'Disable Player Morphs' checkbox.", "No Player Morphs Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            await _powerMorphGenerator.GenerateBodyGenFilesAsync(sizeFilter, deviation, disablePlayerMorphs, selectedPlayerMorphPreset!, _bodyLoader);
        }

        private void tbRandomFilter_KeyPress(object sender, KeyPressEventArgs e) {
            // Allow only digits, control chars and one decimal point:
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.') {
                e.Handled = true;
            }

            // Only allow one decimal point:
            if (e.KeyChar == '.' && ((sender as TextBox)?.Text.IndexOf('.') > -1)) {
                e.Handled = true;
            }
        }

        private void cbDisableMorphsPlayer_CheckedChanged(object sender, EventArgs e) {
            if (cbDisableMorphsPlayer.Checked) {
                cboxPlayerMorphs.Enabled = false;
            } else {
                cboxPlayerMorphs.Enabled = true;
                PopulatePlayerMorphsComboBox();
            }
        }

        private void PopulatePlayerMorphsComboBox() {
            cboxPlayerMorphs.Items.Clear();
            cboxPlayerMorphs.Items.Add("(Random body preset)");

            List<string> presetNames = _bodyLoader.GetLoadedPresetNames(_bodyLoader.GetAllBodyXmls());
            foreach (string presetName in presetNames) {
                cboxPlayerMorphs.Items.Add(presetName);
            }

            cboxPlayerMorphs.SelectedIndex = 0;
        }

        private async void btnUpdateBodyGenFiles_Click(object sender, EventArgs e) {
            string sizeFilter = "big"; // default radio checked
            if (radioBtnFilterSmall.Checked) {
                sizeFilter = "small";
            } else if (radioBtnFilterBig.Checked) {
                sizeFilter = "big";
            }

            btnUpdateBodyGenFiles.Enabled = false;
            pgBarUpdate.Minimum = 0;
            pgBarUpdate.Value = 0;

            string templatesIniPath = Path.Combine(_powerMorphGenerator.GetOutputDirectory(), "templates.ini");
            if (!File.Exists(templatesIniPath)) {
                MessageBox.Show("No templates.ini file found in the output directory!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnUpdateBodyGenFiles.Enabled = true;
                return;
            }

            string[] templatesData = await File.ReadAllLinesAsync(templatesIniPath);
            int totalLines = templatesData.Length;
            pgBarUpdate.Maximum = totalLines;

            var progress = new Progress<int>(value => {
                if (value <= pgBarUpdate.Maximum) {
                    pgBarUpdate.Value = value;
                }
            });

            await _powerMorphGenerator.UpdateTemplatesIniForDefaultBodyAsync(_bodyLoader, sizeFilter, progress);

            btnUpdateBodyGenFiles.Enabled = true;
            _visualIndicatorController.SetPbOk("pbBodyGenUpdateState");
            _visualIndicatorController.SetPbCaption("pbBodyGenUpdateState", "BodyGen files updated successfully!");
        }
    }
}
