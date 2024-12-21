namespace RD_PowerMorph_Generator {
    partial class FormMain {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            lblVer = new Label();
            btnXmlsLoad = new Button();
            lblXmlsPathText = new Label();
            lblXmlsPath = new Label();
            gbLoadXmlsControls = new GroupBox();
            pbDefBodyLoad = new PictureBox();
            pbXmlsLoadStatus = new PictureBox();
            lblDefaultBodyPresetPath = new Label();
            lblDefaultBodyText = new Label();
            btnLoadDefaultBody = new Button();
            btnHelpLoadXmls = new Button();
            gbGenerateBodyGenFiles = new GroupBox();
            cbWriteUniqueNpcLines = new CheckBox();
            cboxPlayerMorphs = new ComboBox();
            cbDisableMorphsPlayer = new CheckBox();
            tbRandomFilter = new TextBox();
            radioBtnFilterSmall = new RadioButton();
            radioBtnFilterBig = new RadioButton();
            lblRandomFilter = new Label();
            lblBigSmallFilter = new Label();
            btnHelpGenerate = new Button();
            pgBarGenerate = new ProgressBar();
            pbGeneratorState = new PictureBox();
            lblGeneratorState = new Label();
            btnGenerateBodyGenFiles = new Button();
            lblGeneratorStateText = new Label();
            pbInisOutputDir = new PictureBox();
            btnSelectOutputDir = new Button();
            lblGeneratorOutputPath = new Label();
            lblGeneratorOutputDirText = new Label();
            gbUpdateBodyGenFiles = new GroupBox();
            btnHelpUpdate = new Button();
            lblUpdateProgress = new Label();
            pgBarUpdate = new ProgressBar();
            pbBodyGenUpdateState = new PictureBox();
            btnUpdateBodyGenFiles = new Button();
            lblUpdateTargetBodyName = new Label();
            lblUpdateFilesText = new Label();
            pbAppTitle1 = new PictureBox();
            pbAppTitle2 = new PictureBox();
            gbAppLoadData = new GroupBox();
            lblInfoGeneratorOutputPath = new Label();
            lblInfoGeneratorOutput = new Label();
            lblInfoDefaultBodyName = new Label();
            label10 = new Label();
            lblInfoTotalXmls = new Label();
            label8 = new Label();
            btnHelpLoadedXmlsData = new Button();
            pbWatermark = new PictureBox();
            pbGitHub = new PictureBox();
            pbNexus = new PictureBox();
            pbKoFi = new PictureBox();
            pbRedStar = new PictureBox();
            gbLoadXmlsControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbDefBodyLoad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbXmlsLoadStatus).BeginInit();
            gbGenerateBodyGenFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbGeneratorState).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbInisOutputDir).BeginInit();
            gbUpdateBodyGenFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbBodyGenUpdateState).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAppTitle1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAppTitle2).BeginInit();
            gbAppLoadData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbWatermark).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbGitHub).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNexus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbKoFi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRedStar).BeginInit();
            SuspendLayout();
            // 
            // lblVer
            // 
            lblVer.AutoSize = true;
            lblVer.Location = new Point(735, 467);
            lblVer.Name = "lblVer";
            lblVer.Size = new Size(97, 15);
            lblVer.TabIndex = 1;
            lblVer.Text = "v0.7 (02/11/2024)";
            // 
            // btnXmlsLoad
            // 
            btnXmlsLoad.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXmlsLoad.Location = new Point(6, 52);
            btnXmlsLoad.Name = "btnXmlsLoad";
            btnXmlsLoad.Size = new Size(209, 45);
            btnXmlsLoad.TabIndex = 2;
            btnXmlsLoad.Text = "Load XML Sliders";
            btnXmlsLoad.UseVisualStyleBackColor = true;
            btnXmlsLoad.Click += btnXmlsLoad_Click;
            // 
            // lblXmlsPathText
            // 
            lblXmlsPathText.AutoSize = true;
            lblXmlsPathText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblXmlsPathText.Location = new Point(6, 19);
            lblXmlsPathText.Name = "lblXmlsPathText";
            lblXmlsPathText.Size = new Size(174, 15);
            lblXmlsPathText.TabIndex = 3;
            lblXmlsPathText.Text = "Path to BodySlide XML slider(s):";
            // 
            // lblXmlsPath
            // 
            lblXmlsPath.AutoSize = true;
            lblXmlsPath.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblXmlsPath.ForeColor = Color.Red;
            lblXmlsPath.Location = new Point(6, 34);
            lblXmlsPath.Name = "lblXmlsPath";
            lblXmlsPath.Size = new Size(103, 15);
            lblXmlsPath.TabIndex = 4;
            lblXmlsPath.Text = "No path provided!";
            // 
            // gbLoadXmlsControls
            // 
            gbLoadXmlsControls.BackColor = Color.Transparent;
            gbLoadXmlsControls.Controls.Add(pbDefBodyLoad);
            gbLoadXmlsControls.Controls.Add(pbXmlsLoadStatus);
            gbLoadXmlsControls.Controls.Add(lblDefaultBodyPresetPath);
            gbLoadXmlsControls.Controls.Add(lblDefaultBodyText);
            gbLoadXmlsControls.Controls.Add(btnLoadDefaultBody);
            gbLoadXmlsControls.Controls.Add(btnHelpLoadXmls);
            gbLoadXmlsControls.Controls.Add(lblXmlsPath);
            gbLoadXmlsControls.Controls.Add(btnXmlsLoad);
            gbLoadXmlsControls.Controls.Add(lblXmlsPathText);
            gbLoadXmlsControls.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            gbLoadXmlsControls.Location = new Point(12, 102);
            gbLoadXmlsControls.Name = "gbLoadXmlsControls";
            gbLoadXmlsControls.Size = new Size(272, 195);
            gbLoadXmlsControls.TabIndex = 5;
            gbLoadXmlsControls.TabStop = false;
            gbLoadXmlsControls.Text = "Load Body XMLs:";
            // 
            // pbDefBodyLoad
            // 
            pbDefBodyLoad.BackColor = Color.Transparent;
            pbDefBodyLoad.BackgroundImageLayout = ImageLayout.Stretch;
            pbDefBodyLoad.Location = new Point(221, 138);
            pbDefBodyLoad.Name = "pbDefBodyLoad";
            pbDefBodyLoad.Size = new Size(45, 45);
            pbDefBodyLoad.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDefBodyLoad.TabIndex = 11;
            pbDefBodyLoad.TabStop = false;
            // 
            // pbXmlsLoadStatus
            // 
            pbXmlsLoadStatus.BackColor = Color.Transparent;
            pbXmlsLoadStatus.BackgroundImageLayout = ImageLayout.Stretch;
            pbXmlsLoadStatus.Location = new Point(221, 52);
            pbXmlsLoadStatus.Name = "pbXmlsLoadStatus";
            pbXmlsLoadStatus.Size = new Size(45, 45);
            pbXmlsLoadStatus.SizeMode = PictureBoxSizeMode.StretchImage;
            pbXmlsLoadStatus.TabIndex = 8;
            pbXmlsLoadStatus.TabStop = false;
            // 
            // lblDefaultBodyPresetPath
            // 
            lblDefaultBodyPresetPath.AutoSize = true;
            lblDefaultBodyPresetPath.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDefaultBodyPresetPath.ForeColor = Color.Red;
            lblDefaultBodyPresetPath.Location = new Point(6, 120);
            lblDefaultBodyPresetPath.Name = "lblDefaultBodyPresetPath";
            lblDefaultBodyPresetPath.Size = new Size(103, 15);
            lblDefaultBodyPresetPath.TabIndex = 7;
            lblDefaultBodyPresetPath.Text = "No path provided!";
            // 
            // lblDefaultBodyText
            // 
            lblDefaultBodyText.AutoSize = true;
            lblDefaultBodyText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDefaultBodyText.Location = new Point(6, 102);
            lblDefaultBodyText.Name = "lblDefaultBodyText";
            lblDefaultBodyText.Size = new Size(172, 15);
            lblDefaultBodyText.TabIndex = 6;
            lblDefaultBodyText.Text = "Path to your default body XML:";
            // 
            // btnLoadDefaultBody
            // 
            btnLoadDefaultBody.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoadDefaultBody.Location = new Point(6, 138);
            btnLoadDefaultBody.Name = "btnLoadDefaultBody";
            btnLoadDefaultBody.Size = new Size(209, 45);
            btnLoadDefaultBody.TabIndex = 4;
            btnLoadDefaultBody.Text = "Load target body XML";
            btnLoadDefaultBody.UseVisualStyleBackColor = true;
            btnLoadDefaultBody.Click += btnLoadDefaultBody_Click;
            // 
            // btnHelpLoadXmls
            // 
            btnHelpLoadXmls.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHelpLoadXmls.Location = new Point(245, 15);
            btnHelpLoadXmls.Name = "btnHelpLoadXmls";
            btnHelpLoadXmls.Size = new Size(21, 23);
            btnHelpLoadXmls.TabIndex = 3;
            btnHelpLoadXmls.Text = "?";
            btnHelpLoadXmls.UseVisualStyleBackColor = true;
            // 
            // gbGenerateBodyGenFiles
            // 
            gbGenerateBodyGenFiles.BackColor = Color.Transparent;
            gbGenerateBodyGenFiles.Controls.Add(cbWriteUniqueNpcLines);
            gbGenerateBodyGenFiles.Controls.Add(cboxPlayerMorphs);
            gbGenerateBodyGenFiles.Controls.Add(cbDisableMorphsPlayer);
            gbGenerateBodyGenFiles.Controls.Add(tbRandomFilter);
            gbGenerateBodyGenFiles.Controls.Add(radioBtnFilterSmall);
            gbGenerateBodyGenFiles.Controls.Add(radioBtnFilterBig);
            gbGenerateBodyGenFiles.Controls.Add(lblRandomFilter);
            gbGenerateBodyGenFiles.Controls.Add(lblBigSmallFilter);
            gbGenerateBodyGenFiles.Controls.Add(btnHelpGenerate);
            gbGenerateBodyGenFiles.Controls.Add(pgBarGenerate);
            gbGenerateBodyGenFiles.Controls.Add(pbGeneratorState);
            gbGenerateBodyGenFiles.Controls.Add(lblGeneratorState);
            gbGenerateBodyGenFiles.Controls.Add(btnGenerateBodyGenFiles);
            gbGenerateBodyGenFiles.Controls.Add(lblGeneratorStateText);
            gbGenerateBodyGenFiles.Controls.Add(pbInisOutputDir);
            gbGenerateBodyGenFiles.Controls.Add(btnSelectOutputDir);
            gbGenerateBodyGenFiles.Controls.Add(lblGeneratorOutputPath);
            gbGenerateBodyGenFiles.Controls.Add(lblGeneratorOutputDirText);
            gbGenerateBodyGenFiles.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            gbGenerateBodyGenFiles.Location = new Point(290, 102);
            gbGenerateBodyGenFiles.Name = "gbGenerateBodyGenFiles";
            gbGenerateBodyGenFiles.Size = new Size(542, 195);
            gbGenerateBodyGenFiles.TabIndex = 6;
            gbGenerateBodyGenFiles.TabStop = false;
            gbGenerateBodyGenFiles.Text = "Generate BodyGen Files:";
            // 
            // cbWriteUniqueNpcLines
            // 
            cbWriteUniqueNpcLines.AutoSize = true;
            cbWriteUniqueNpcLines.Checked = true;
            cbWriteUniqueNpcLines.CheckState = CheckState.Checked;
            cbWriteUniqueNpcLines.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbWriteUniqueNpcLines.Location = new Point(331, 104);
            cbWriteUniqueNpcLines.Name = "cbWriteUniqueNpcLines";
            cbWriteUniqueNpcLines.Size = new Size(149, 19);
            cbWriteUniqueNpcLines.TabIndex = 25;
            cbWriteUniqueNpcLines.Text = "Write Unique NPC lines";
            cbWriteUniqueNpcLines.UseVisualStyleBackColor = true;
            // 
            // cboxPlayerMorphs
            // 
            cboxPlayerMorphs.Enabled = false;
            cboxPlayerMorphs.FormattingEnabled = true;
            cboxPlayerMorphs.Location = new Point(331, 145);
            cboxPlayerMorphs.Name = "cboxPlayerMorphs";
            cboxPlayerMorphs.Size = new Size(205, 23);
            cboxPlayerMorphs.TabIndex = 24;
            // 
            // cbDisableMorphsPlayer
            // 
            cbDisableMorphsPlayer.AutoSize = true;
            cbDisableMorphsPlayer.Checked = true;
            cbDisableMorphsPlayer.CheckState = CheckState.Checked;
            cbDisableMorphsPlayer.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbDisableMorphsPlayer.Location = new Point(331, 123);
            cbDisableMorphsPlayer.Name = "cbDisableMorphsPlayer";
            cbDisableMorphsPlayer.Size = new Size(160, 19);
            cbDisableMorphsPlayer.TabIndex = 23;
            cbDisableMorphsPlayer.Text = "Disable morphs on Player";
            cbDisableMorphsPlayer.UseVisualStyleBackColor = true;
            cbDisableMorphsPlayer.CheckedChanged += cbDisableMorphsPlayer_CheckedChanged;
            // 
            // tbRandomFilter
            // 
            tbRandomFilter.BackColor = SystemColors.InactiveBorder;
            tbRandomFilter.Location = new Point(436, 66);
            tbRandomFilter.Name = "tbRandomFilter";
            tbRandomFilter.Size = new Size(100, 23);
            tbRandomFilter.TabIndex = 22;
            tbRandomFilter.KeyPress += tbRandomFilter_KeyPress;
            // 
            // radioBtnFilterSmall
            // 
            radioBtnFilterSmall.AutoSize = true;
            radioBtnFilterSmall.Location = new Point(483, 37);
            radioBtnFilterSmall.Name = "radioBtnFilterSmall";
            radioBtnFilterSmall.Size = new Size(53, 19);
            radioBtnFilterSmall.TabIndex = 21;
            radioBtnFilterSmall.Text = "Small";
            radioBtnFilterSmall.UseVisualStyleBackColor = true;
            // 
            // radioBtnFilterBig
            // 
            radioBtnFilterBig.AutoSize = true;
            radioBtnFilterBig.Checked = true;
            radioBtnFilterBig.Location = new Point(436, 37);
            radioBtnFilterBig.Name = "radioBtnFilterBig";
            radioBtnFilterBig.Size = new Size(41, 19);
            radioBtnFilterBig.TabIndex = 20;
            radioBtnFilterBig.TabStop = true;
            radioBtnFilterBig.Text = "Big";
            radioBtnFilterBig.UseVisualStyleBackColor = true;
            // 
            // lblRandomFilter
            // 
            lblRandomFilter.AutoSize = true;
            lblRandomFilter.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRandomFilter.Location = new Point(331, 69);
            lblRandomFilter.Name = "lblRandomFilter";
            lblRandomFilter.Size = new Size(99, 15);
            lblRandomFilter.TabIndex = 19;
            lblRandomFilter.Text = "Randomness (%):";
            // 
            // lblBigSmallFilter
            // 
            lblBigSmallFilter.AutoSize = true;
            lblBigSmallFilter.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBigSmallFilter.Location = new Point(373, 39);
            lblBigSmallFilter.Name = "lblBigSmallFilter";
            lblBigSmallFilter.Size = new Size(57, 15);
            lblBigSmallFilter.TabIndex = 18;
            lblBigSmallFilter.Text = "Size filter:";
            // 
            // btnHelpGenerate
            // 
            btnHelpGenerate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHelpGenerate.Location = new Point(515, 15);
            btnHelpGenerate.Name = "btnHelpGenerate";
            btnHelpGenerate.Size = new Size(21, 23);
            btnHelpGenerate.TabIndex = 12;
            btnHelpGenerate.Text = "?";
            btnHelpGenerate.UseVisualStyleBackColor = true;
            // 
            // pgBarGenerate
            // 
            pgBarGenerate.Location = new Point(6, 174);
            pgBarGenerate.Name = "pgBarGenerate";
            pgBarGenerate.Size = new Size(530, 15);
            pgBarGenerate.TabIndex = 17;
            // 
            // pbGeneratorState
            // 
            pbGeneratorState.BackColor = Color.Transparent;
            pbGeneratorState.BackgroundImageLayout = ImageLayout.Stretch;
            pbGeneratorState.Location = new Point(221, 123);
            pbGeneratorState.Name = "pbGeneratorState";
            pbGeneratorState.Size = new Size(45, 45);
            pbGeneratorState.SizeMode = PictureBoxSizeMode.StretchImage;
            pbGeneratorState.TabIndex = 16;
            pbGeneratorState.TabStop = false;
            // 
            // lblGeneratorState
            // 
            lblGeneratorState.AutoSize = true;
            lblGeneratorState.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGeneratorState.ForeColor = Color.Red;
            lblGeneratorState.Location = new Point(221, 105);
            lblGeneratorState.Name = "lblGeneratorState";
            lblGeneratorState.Size = new Size(59, 15);
            lblGeneratorState.TabIndex = 15;
            lblGeneratorState.Text = "Not ready";
            // 
            // btnGenerateBodyGenFiles
            // 
            btnGenerateBodyGenFiles.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerateBodyGenFiles.Location = new Point(6, 123);
            btnGenerateBodyGenFiles.Name = "btnGenerateBodyGenFiles";
            btnGenerateBodyGenFiles.Size = new Size(209, 45);
            btnGenerateBodyGenFiles.TabIndex = 14;
            btnGenerateBodyGenFiles.Text = "Generate BodyGen Files";
            btnGenerateBodyGenFiles.UseVisualStyleBackColor = true;
            btnGenerateBodyGenFiles.Click += btnGenerateBodyGenFiles_Click;
            // 
            // lblGeneratorStateText
            // 
            lblGeneratorStateText.AutoSize = true;
            lblGeneratorStateText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGeneratorStateText.Location = new Point(6, 105);
            lblGeneratorStateText.Name = "lblGeneratorStateText";
            lblGeneratorStateText.Size = new Size(162, 15);
            lblGeneratorStateText.TabIndex = 13;
            lblGeneratorStateText.Text = "PowerMorph Generator state:";
            // 
            // pbInisOutputDir
            // 
            pbInisOutputDir.BackColor = Color.Transparent;
            pbInisOutputDir.BackgroundImageLayout = ImageLayout.Stretch;
            pbInisOutputDir.Location = new Point(221, 37);
            pbInisOutputDir.Name = "pbInisOutputDir";
            pbInisOutputDir.Size = new Size(45, 45);
            pbInisOutputDir.SizeMode = PictureBoxSizeMode.StretchImage;
            pbInisOutputDir.TabIndex = 12;
            pbInisOutputDir.TabStop = false;
            // 
            // btnSelectOutputDir
            // 
            btnSelectOutputDir.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSelectOutputDir.Location = new Point(6, 37);
            btnSelectOutputDir.Name = "btnSelectOutputDir";
            btnSelectOutputDir.Size = new Size(209, 45);
            btnSelectOutputDir.TabIndex = 10;
            btnSelectOutputDir.Text = "Select Output Directory";
            btnSelectOutputDir.UseVisualStyleBackColor = true;
            btnSelectOutputDir.Click += btnSelectOutputDir_Click;
            // 
            // lblGeneratorOutputPath
            // 
            lblGeneratorOutputPath.AutoSize = true;
            lblGeneratorOutputPath.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGeneratorOutputPath.ForeColor = Color.Red;
            lblGeneratorOutputPath.Location = new Point(221, 19);
            lblGeneratorOutputPath.Name = "lblGeneratorOutputPath";
            lblGeneratorOutputPath.Size = new Size(103, 15);
            lblGeneratorOutputPath.TabIndex = 10;
            lblGeneratorOutputPath.Text = "No path provided!";
            // 
            // lblGeneratorOutputDirText
            // 
            lblGeneratorOutputDirText.AutoSize = true;
            lblGeneratorOutputDirText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGeneratorOutputDirText.Location = new Point(6, 19);
            lblGeneratorOutputDirText.Name = "lblGeneratorOutputDirText";
            lblGeneratorOutputDirText.Size = new Size(170, 15);
            lblGeneratorOutputDirText.TabIndex = 10;
            lblGeneratorOutputDirText.Text = "BodyGen INIs output directory:";
            // 
            // gbUpdateBodyGenFiles
            // 
            gbUpdateBodyGenFiles.BackColor = Color.Transparent;
            gbUpdateBodyGenFiles.Controls.Add(btnHelpUpdate);
            gbUpdateBodyGenFiles.Controls.Add(lblUpdateProgress);
            gbUpdateBodyGenFiles.Controls.Add(pgBarUpdate);
            gbUpdateBodyGenFiles.Controls.Add(pbBodyGenUpdateState);
            gbUpdateBodyGenFiles.Controls.Add(btnUpdateBodyGenFiles);
            gbUpdateBodyGenFiles.Controls.Add(lblUpdateTargetBodyName);
            gbUpdateBodyGenFiles.Controls.Add(lblUpdateFilesText);
            gbUpdateBodyGenFiles.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            gbUpdateBodyGenFiles.Location = new Point(290, 303);
            gbUpdateBodyGenFiles.Name = "gbUpdateBodyGenFiles";
            gbUpdateBodyGenFiles.Size = new Size(542, 132);
            gbUpdateBodyGenFiles.TabIndex = 7;
            gbUpdateBodyGenFiles.TabStop = false;
            gbUpdateBodyGenFiles.Text = "Update BodyGen Files:";
            // 
            // btnHelpUpdate
            // 
            btnHelpUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHelpUpdate.Location = new Point(515, 15);
            btnHelpUpdate.Name = "btnHelpUpdate";
            btnHelpUpdate.Size = new Size(21, 23);
            btnHelpUpdate.TabIndex = 18;
            btnHelpUpdate.Text = "?";
            btnHelpUpdate.UseVisualStyleBackColor = true;
            // 
            // lblUpdateProgress
            // 
            lblUpdateProgress.AutoSize = true;
            lblUpdateProgress.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUpdateProgress.Location = new Point(6, 93);
            lblUpdateProgress.Name = "lblUpdateProgress";
            lblUpdateProgress.Size = new Size(55, 15);
            lblUpdateProgress.TabIndex = 20;
            lblUpdateProgress.Text = "Progress:";
            // 
            // pgBarUpdate
            // 
            pgBarUpdate.Location = new Point(6, 111);
            pgBarUpdate.Name = "pgBarUpdate";
            pgBarUpdate.Size = new Size(530, 15);
            pgBarUpdate.TabIndex = 19;
            // 
            // pbBodyGenUpdateState
            // 
            pbBodyGenUpdateState.BackColor = Color.Transparent;
            pbBodyGenUpdateState.BackgroundImageLayout = ImageLayout.Stretch;
            pbBodyGenUpdateState.Location = new Point(221, 37);
            pbBodyGenUpdateState.Name = "pbBodyGenUpdateState";
            pbBodyGenUpdateState.Size = new Size(45, 45);
            pbBodyGenUpdateState.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBodyGenUpdateState.TabIndex = 18;
            pbBodyGenUpdateState.TabStop = false;
            // 
            // btnUpdateBodyGenFiles
            // 
            btnUpdateBodyGenFiles.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdateBodyGenFiles.Location = new Point(6, 37);
            btnUpdateBodyGenFiles.Name = "btnUpdateBodyGenFiles";
            btnUpdateBodyGenFiles.Size = new Size(209, 45);
            btnUpdateBodyGenFiles.TabIndex = 18;
            btnUpdateBodyGenFiles.Text = "Go!";
            btnUpdateBodyGenFiles.UseVisualStyleBackColor = true;
            btnUpdateBodyGenFiles.Click += btnUpdateBodyGenFiles_Click;
            // 
            // lblUpdateTargetBodyName
            // 
            lblUpdateTargetBodyName.AutoSize = true;
            lblUpdateTargetBodyName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUpdateTargetBodyName.ForeColor = Color.Red;
            lblUpdateTargetBodyName.Location = new Point(250, 19);
            lblUpdateTargetBodyName.Name = "lblUpdateTargetBodyName";
            lblUpdateTargetBodyName.Size = new Size(102, 15);
            lblUpdateTargetBodyName.TabIndex = 18;
            lblUpdateTargetBodyName.Text = "Target body name";
            // 
            // lblUpdateFilesText
            // 
            lblUpdateFilesText.AutoSize = true;
            lblUpdateFilesText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUpdateFilesText.Location = new Point(6, 19);
            lblUpdateFilesText.Name = "lblUpdateFilesText";
            lblUpdateFilesText.Size = new Size(238, 15);
            lblUpdateFilesText.TabIndex = 18;
            lblUpdateFilesText.Text = "Update BodyGen files based on target body:";
            // 
            // pbAppTitle1
            // 
            pbAppTitle1.BackColor = Color.Transparent;
            pbAppTitle1.Image = (Image)resources.GetObject("pbAppTitle1.Image");
            pbAppTitle1.Location = new Point(12, 12);
            pbAppTitle1.Name = "pbAppTitle1";
            pbAppTitle1.Size = new Size(236, 36);
            pbAppTitle1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAppTitle1.TabIndex = 8;
            pbAppTitle1.TabStop = false;
            // 
            // pbAppTitle2
            // 
            pbAppTitle2.BackColor = Color.Transparent;
            pbAppTitle2.Image = (Image)resources.GetObject("pbAppTitle2.Image");
            pbAppTitle2.Location = new Point(254, 29);
            pbAppTitle2.Name = "pbAppTitle2";
            pbAppTitle2.Size = new Size(578, 67);
            pbAppTitle2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAppTitle2.TabIndex = 9;
            pbAppTitle2.TabStop = false;
            // 
            // gbAppLoadData
            // 
            gbAppLoadData.BackColor = Color.Transparent;
            gbAppLoadData.Controls.Add(lblInfoGeneratorOutputPath);
            gbAppLoadData.Controls.Add(lblInfoGeneratorOutput);
            gbAppLoadData.Controls.Add(lblInfoDefaultBodyName);
            gbAppLoadData.Controls.Add(label10);
            gbAppLoadData.Controls.Add(lblInfoTotalXmls);
            gbAppLoadData.Controls.Add(label8);
            gbAppLoadData.Controls.Add(btnHelpLoadedXmlsData);
            gbAppLoadData.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            gbAppLoadData.Location = new Point(12, 303);
            gbAppLoadData.Name = "gbAppLoadData";
            gbAppLoadData.Size = new Size(272, 132);
            gbAppLoadData.TabIndex = 8;
            gbAppLoadData.TabStop = false;
            gbAppLoadData.Text = "Application load data";
            // 
            // lblInfoGeneratorOutputPath
            // 
            lblInfoGeneratorOutputPath.AutoSize = true;
            lblInfoGeneratorOutputPath.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInfoGeneratorOutputPath.ForeColor = Color.Red;
            lblInfoGeneratorOutputPath.Location = new Point(6, 93);
            lblInfoGeneratorOutputPath.Name = "lblInfoGeneratorOutputPath";
            lblInfoGeneratorOutputPath.Size = new Size(161, 15);
            lblInfoGeneratorOutputPath.TabIndex = 14;
            lblInfoGeneratorOutputPath.Text = "No output directory selected!";
            // 
            // lblInfoGeneratorOutput
            // 
            lblInfoGeneratorOutput.AutoSize = true;
            lblInfoGeneratorOutput.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInfoGeneratorOutput.Location = new Point(6, 78);
            lblInfoGeneratorOutput.Name = "lblInfoGeneratorOutput";
            lblInfoGeneratorOutput.Size = new Size(151, 15);
            lblInfoGeneratorOutput.TabIndex = 13;
            lblInfoGeneratorOutput.Text = "Generator output directory:";
            // 
            // lblInfoDefaultBodyName
            // 
            lblInfoDefaultBodyName.AutoSize = true;
            lblInfoDefaultBodyName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInfoDefaultBodyName.ForeColor = Color.Red;
            lblInfoDefaultBodyName.Location = new Point(6, 52);
            lblInfoDefaultBodyName.Name = "lblInfoDefaultBodyName";
            lblInfoDefaultBodyName.Size = new Size(165, 15);
            lblInfoDefaultBodyName.TabIndex = 12;
            lblInfoDefaultBodyName.Text = "Default body XML not loaded!";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(6, 37);
            label10.Name = "label10";
            label10.Size = new Size(140, 15);
            label10.TabIndex = 12;
            label10.Text = "Default body preset XML:";
            // 
            // lblInfoTotalXmls
            // 
            lblInfoTotalXmls.AutoSize = true;
            lblInfoTotalXmls.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInfoTotalXmls.ForeColor = Color.Red;
            lblInfoTotalXmls.Location = new Point(187, 19);
            lblInfoTotalXmls.Name = "lblInfoTotalXmls";
            lblInfoTotalXmls.Size = new Size(13, 15);
            lblInfoTotalXmls.TabIndex = 12;
            lblInfoTotalXmls.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(6, 19);
            label8.Name = "label8";
            label8.Size = new Size(175, 15);
            label8.TabIndex = 12;
            label8.Text = "Total loaded XML presets count:";
            // 
            // btnHelpLoadedXmlsData
            // 
            btnHelpLoadedXmlsData.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHelpLoadedXmlsData.Location = new Point(245, 15);
            btnHelpLoadedXmlsData.Name = "btnHelpLoadedXmlsData";
            btnHelpLoadedXmlsData.Size = new Size(21, 23);
            btnHelpLoadedXmlsData.TabIndex = 10;
            btnHelpLoadedXmlsData.Text = "?";
            btnHelpLoadedXmlsData.UseVisualStyleBackColor = true;
            // 
            // pbWatermark
            // 
            pbWatermark.BackColor = Color.Transparent;
            pbWatermark.BackgroundImageLayout = ImageLayout.Stretch;
            pbWatermark.Image = (Image)resources.GetObject("pbWatermark.Image");
            pbWatermark.Location = new Point(12, 447);
            pbWatermark.Name = "pbWatermark";
            pbWatermark.Size = new Size(200, 41);
            pbWatermark.SizeMode = PictureBoxSizeMode.StretchImage;
            pbWatermark.TabIndex = 12;
            pbWatermark.TabStop = false;
            // 
            // pbGitHub
            // 
            pbGitHub.BackColor = Color.Transparent;
            pbGitHub.BackgroundImageLayout = ImageLayout.Stretch;
            pbGitHub.Image = Properties.Resources.rd_github_default;
            pbGitHub.Location = new Point(290, 447);
            pbGitHub.Name = "pbGitHub";
            pbGitHub.Size = new Size(116, 35);
            pbGitHub.SizeMode = PictureBoxSizeMode.StretchImage;
            pbGitHub.TabIndex = 13;
            pbGitHub.TabStop = false;
            pbGitHub.MouseDown += pbGitHub_MouseDown;
            pbGitHub.MouseEnter += pbGitHub_MouseEnter;
            pbGitHub.MouseLeave += pbGitHub_MouseLeave;
            // 
            // pbNexus
            // 
            pbNexus.BackColor = Color.Transparent;
            pbNexus.BackgroundImageLayout = ImageLayout.Stretch;
            pbNexus.Image = Properties.Resources.rd_nexus_default;
            pbNexus.Location = new Point(412, 447);
            pbNexus.Name = "pbNexus";
            pbNexus.Size = new Size(116, 35);
            pbNexus.SizeMode = PictureBoxSizeMode.StretchImage;
            pbNexus.TabIndex = 14;
            pbNexus.TabStop = false;
            pbNexus.MouseDown += pbNexus_MouseDown;
            pbNexus.MouseEnter += pbNexus_MouseEnter;
            pbNexus.MouseLeave += pbNexus_MouseLeave;
            // 
            // pbKoFi
            // 
            pbKoFi.BackColor = Color.Transparent;
            pbKoFi.BackgroundImageLayout = ImageLayout.Stretch;
            pbKoFi.Image = Properties.Resources.rd_kofi_default;
            pbKoFi.Location = new Point(534, 447);
            pbKoFi.Name = "pbKoFi";
            pbKoFi.Size = new Size(116, 35);
            pbKoFi.SizeMode = PictureBoxSizeMode.StretchImage;
            pbKoFi.TabIndex = 15;
            pbKoFi.TabStop = false;
            pbKoFi.MouseDown += pbKoFi_MouseDown;
            pbKoFi.MouseEnter += pbKoFi_MouseEnter;
            pbKoFi.MouseLeave += pbKoFi_MouseLeave;
            // 
            // pbRedStar
            // 
            pbRedStar.BackColor = Color.Transparent;
            pbRedStar.BackgroundImageLayout = ImageLayout.Stretch;
            pbRedStar.Image = (Image)resources.GetObject("pbRedStar.Image");
            pbRedStar.Location = new Point(218, 441);
            pbRedStar.Name = "pbRedStar";
            pbRedStar.Size = new Size(50, 47);
            pbRedStar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbRedStar.TabIndex = 16;
            pbRedStar.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(844, 491);
            Controls.Add(pbRedStar);
            Controls.Add(pbKoFi);
            Controls.Add(pbNexus);
            Controls.Add(pbGitHub);
            Controls.Add(pbWatermark);
            Controls.Add(gbAppLoadData);
            Controls.Add(pbAppTitle2);
            Controls.Add(pbAppTitle1);
            Controls.Add(gbUpdateBodyGenFiles);
            Controls.Add(gbGenerateBodyGenFiles);
            Controls.Add(gbLoadXmlsControls);
            Controls.Add(lblVer);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rubber Duck's PowerMorph Generator";
            gbLoadXmlsControls.ResumeLayout(false);
            gbLoadXmlsControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbDefBodyLoad).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbXmlsLoadStatus).EndInit();
            gbGenerateBodyGenFiles.ResumeLayout(false);
            gbGenerateBodyGenFiles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbGeneratorState).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbInisOutputDir).EndInit();
            gbUpdateBodyGenFiles.ResumeLayout(false);
            gbUpdateBodyGenFiles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbBodyGenUpdateState).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAppTitle1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAppTitle2).EndInit();
            gbAppLoadData.ResumeLayout(false);
            gbAppLoadData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbWatermark).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbGitHub).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNexus).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbKoFi).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRedStar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblVer;
        private Button btnXmlsLoad;
        private Label lblXmlsPathText;
        private Label lblXmlsPath;
        private GroupBox gbLoadXmlsControls;
        private Button btnHelpLoadXmls;
        private Label lblDefaultBodyText;
        private Label lblDefaultBodyPresetPath;
        private Button btnLoadDefaultBody;
        private PictureBox pbXmlsLoadStatus;
        private GroupBox gbGenerateBodyGenFiles;
        private GroupBox gbUpdateBodyGenFiles;
        private PictureBox pbAppTitle1;
        private PictureBox pbAppTitle2;
        private Button btnSelectOutputDir;
        private Label lblGeneratorOutputPath;
        private Label lblGeneratorOutputDirText;
        private PictureBox pbDefBodyLoad;
        private PictureBox pbInisOutputDir;
        private Label lblGeneratorStateText;
        private ProgressBar pgBarGenerate;
        private PictureBox pbGeneratorState;
        private Label lblGeneratorState;
        private Button btnGenerateBodyGenFiles;
        private Label lblUpdateProgress;
        private ProgressBar pgBarUpdate;
        private PictureBox pbBodyGenUpdateState;
        private Button btnUpdateBodyGenFiles;
        private Label lblUpdateTargetBodyName;
        private Label lblUpdateFilesText;
        private GroupBox gbAppLoadData;
        private Button btnHelpGenerate;
        private Button btnHelpUpdate;
        private Button btnHelpLoadedXmlsData;
        private Label lblInfoDefaultBodyName;
        private Label label10;
        private Label lblInfoTotalXmls;
        private Label label8;
        private Label lblInfoGeneratorOutputPath;
        private Label lblInfoGeneratorOutput;
        private PictureBox pbWatermark;
        private PictureBox pbGitHub;
        private PictureBox pbNexus;
        private PictureBox pbKoFi;
        private PictureBox pbRedStar;
        private RadioButton radioBtnFilterSmall;
        private RadioButton radioBtnFilterBig;
        private Label lblRandomFilter;
        private Label lblBigSmallFilter;
        private TextBox tbRandomFilter;
        private CheckBox cbDisableMorphsPlayer;
        private ComboBox cboxPlayerMorphs;
        private CheckBox cbWriteUniqueNpcLines;
    }
}
