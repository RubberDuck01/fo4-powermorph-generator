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
            lblWatermark = new Label();
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
            btnHelpGenerate = new Button();
            pgBarGenerate = new ProgressBar();
            pbGeneratorState = new PictureBox();
            label4 = new Label();
            btnGenerateBodyGenFiles = new Button();
            label3 = new Label();
            pbInisOutputDir = new PictureBox();
            btnSelectOutputDir = new Button();
            label2 = new Label();
            label1 = new Label();
            gbUpdateBodyGenFiles = new GroupBox();
            btnHelpUpdate = new Button();
            label7 = new Label();
            pgBarUpdate = new ProgressBar();
            pbBodyGenUpdateState = new PictureBox();
            btnUpdateBodyGenFiles = new Button();
            label6 = new Label();
            label5 = new Label();
            pbAppTitle1 = new PictureBox();
            pbAppTitle2 = new PictureBox();
            gbAppLoadData = new GroupBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            btnHelpLoadedXmlsData = new Button();
            lblLinkGithub = new LinkLabel();
            lblLinkNexus = new LinkLabel();
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
            SuspendLayout();
            // 
            // lblWatermark
            // 
            lblWatermark.AutoSize = true;
            lblWatermark.BackColor = Color.Transparent;
            lblWatermark.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblWatermark.Location = new Point(12, 443);
            lblWatermark.Name = "lblWatermark";
            lblWatermark.Size = new Size(159, 19);
            lblWatermark.TabIndex = 0;
            lblWatermark.Text = "By: Rubber Duck";
            // 
            // lblVer
            // 
            lblVer.AutoSize = true;
            lblVer.Location = new Point(735, 447);
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
            gbGenerateBodyGenFiles.Controls.Add(btnHelpGenerate);
            gbGenerateBodyGenFiles.Controls.Add(pgBarGenerate);
            gbGenerateBodyGenFiles.Controls.Add(pbGeneratorState);
            gbGenerateBodyGenFiles.Controls.Add(label4);
            gbGenerateBodyGenFiles.Controls.Add(btnGenerateBodyGenFiles);
            gbGenerateBodyGenFiles.Controls.Add(label3);
            gbGenerateBodyGenFiles.Controls.Add(pbInisOutputDir);
            gbGenerateBodyGenFiles.Controls.Add(btnSelectOutputDir);
            gbGenerateBodyGenFiles.Controls.Add(label2);
            gbGenerateBodyGenFiles.Controls.Add(label1);
            gbGenerateBodyGenFiles.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            gbGenerateBodyGenFiles.Location = new Point(290, 102);
            gbGenerateBodyGenFiles.Name = "gbGenerateBodyGenFiles";
            gbGenerateBodyGenFiles.Size = new Size(542, 195);
            gbGenerateBodyGenFiles.TabIndex = 6;
            gbGenerateBodyGenFiles.TabStop = false;
            gbGenerateBodyGenFiles.Text = "Generate BodyGen Files:";
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
            pbGeneratorState.Location = new Point(221, 116);
            pbGeneratorState.Name = "pbGeneratorState";
            pbGeneratorState.Size = new Size(45, 45);
            pbGeneratorState.SizeMode = PictureBoxSizeMode.StretchImage;
            pbGeneratorState.TabIndex = 16;
            pbGeneratorState.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(221, 98);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 15;
            label4.Text = "Not ready";
            // 
            // btnGenerateBodyGenFiles
            // 
            btnGenerateBodyGenFiles.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerateBodyGenFiles.Location = new Point(6, 116);
            btnGenerateBodyGenFiles.Name = "btnGenerateBodyGenFiles";
            btnGenerateBodyGenFiles.Size = new Size(209, 45);
            btnGenerateBodyGenFiles.TabIndex = 14;
            btnGenerateBodyGenFiles.Text = "Generate BodyGen Files";
            btnGenerateBodyGenFiles.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 98);
            label3.Name = "label3";
            label3.Size = new Size(162, 15);
            label3.TabIndex = 13;
            label3.Text = "PowerMorph Generator state:";
            // 
            // pbInisOutputDir
            // 
            pbInisOutputDir.BackColor = Color.Transparent;
            pbInisOutputDir.BackgroundImageLayout = ImageLayout.Stretch;
            pbInisOutputDir.Location = new Point(221, 44);
            pbInisOutputDir.Name = "pbInisOutputDir";
            pbInisOutputDir.Size = new Size(45, 45);
            pbInisOutputDir.SizeMode = PictureBoxSizeMode.StretchImage;
            pbInisOutputDir.TabIndex = 12;
            pbInisOutputDir.TabStop = false;
            // 
            // btnSelectOutputDir
            // 
            btnSelectOutputDir.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSelectOutputDir.Location = new Point(6, 44);
            btnSelectOutputDir.Name = "btnSelectOutputDir";
            btnSelectOutputDir.Size = new Size(209, 45);
            btnSelectOutputDir.TabIndex = 10;
            btnSelectOutputDir.Text = "Select Output Directory";
            btnSelectOutputDir.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(221, 19);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 10;
            label2.Text = "No path provided!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(170, 15);
            label1.TabIndex = 10;
            label1.Text = "BodyGen INIs output directory:";
            // 
            // gbUpdateBodyGenFiles
            // 
            gbUpdateBodyGenFiles.BackColor = Color.Transparent;
            gbUpdateBodyGenFiles.Controls.Add(btnHelpUpdate);
            gbUpdateBodyGenFiles.Controls.Add(label7);
            gbUpdateBodyGenFiles.Controls.Add(pgBarUpdate);
            gbUpdateBodyGenFiles.Controls.Add(pbBodyGenUpdateState);
            gbUpdateBodyGenFiles.Controls.Add(btnUpdateBodyGenFiles);
            gbUpdateBodyGenFiles.Controls.Add(label6);
            gbUpdateBodyGenFiles.Controls.Add(label5);
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(6, 93);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 20;
            label7.Text = "Progress:";
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
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(250, 19);
            label6.Name = "label6";
            label6.Size = new Size(102, 15);
            label6.TabIndex = 18;
            label6.Text = "Target body name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 19);
            label5.Name = "label5";
            label5.Size = new Size(238, 15);
            label5.TabIndex = 18;
            label5.Text = "Update BodyGen files based on target body:";
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
            gbAppLoadData.Controls.Add(label11);
            gbAppLoadData.Controls.Add(label10);
            gbAppLoadData.Controls.Add(label9);
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
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(6, 82);
            label11.Name = "label11";
            label11.Size = new Size(165, 15);
            label11.TabIndex = 12;
            label11.Text = "Default body XML not loaded!";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(6, 67);
            label10.Name = "label10";
            label10.Size = new Size(146, 15);
            label10.TabIndex = 12;
            label10.Text = "Default body preset name:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(6, 34);
            label9.Name = "label9";
            label9.Size = new Size(103, 15);
            label9.TabIndex = 12;
            label9.Text = "No path provided!";
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
            // lblLinkGithub
            // 
            lblLinkGithub.AutoSize = true;
            lblLinkGithub.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblLinkGithub.Location = new Point(177, 443);
            lblLinkGithub.Name = "lblLinkGithub";
            lblLinkGithub.Size = new Size(69, 19);
            lblLinkGithub.TabIndex = 10;
            lblLinkGithub.TabStop = true;
            lblLinkGithub.Text = "GitHub";
            // 
            // lblLinkNexus
            // 
            lblLinkNexus.AutoSize = true;
            lblLinkNexus.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblLinkNexus.Location = new Point(252, 443);
            lblLinkNexus.Name = "lblLinkNexus";
            lblLinkNexus.Size = new Size(109, 19);
            lblLinkNexus.TabIndex = 11;
            lblLinkNexus.TabStop = true;
            lblLinkNexus.Text = "Nexus page";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(844, 471);
            Controls.Add(lblLinkNexus);
            Controls.Add(lblLinkGithub);
            Controls.Add(gbAppLoadData);
            Controls.Add(pbAppTitle2);
            Controls.Add(pbAppTitle1);
            Controls.Add(gbUpdateBodyGenFiles);
            Controls.Add(gbGenerateBodyGenFiles);
            Controls.Add(gbLoadXmlsControls);
            Controls.Add(lblVer);
            Controls.Add(lblWatermark);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWatermark;
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
        private Label label2;
        private Label label1;
        private PictureBox pbDefBodyLoad;
        private PictureBox pbInisOutputDir;
        private Label label3;
        private ProgressBar pgBarGenerate;
        private PictureBox pbGeneratorState;
        private Label label4;
        private Button btnGenerateBodyGenFiles;
        private Label label7;
        private ProgressBar pgBarUpdate;
        private PictureBox pbBodyGenUpdateState;
        private Button btnUpdateBodyGenFiles;
        private Label label6;
        private Label label5;
        private GroupBox gbAppLoadData;
        private Button btnHelpGenerate;
        private Button btnHelpUpdate;
        private Button btnHelpLoadedXmlsData;
        private LinkLabel lblLinkGithub;
        private LinkLabel lblLinkNexus;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
    }
}
