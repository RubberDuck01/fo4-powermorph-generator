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
            pbXmlsLoadStatus = new PictureBox();
            lblDefaultBodyPresetPath = new Label();
            btnLoadDefaultBodyHelp = new Button();
            lblDefaultBodyText = new Label();
            btnLoadDefaultBody = new Button();
            btnLoadXmlsHelp = new Button();
            gbGenerateBodyGenFiles = new GroupBox();
            pbGenerateBodyGenFiles = new PictureBox();
            gbUpdateBodyGenFiles = new GroupBox();
            pbUpdateBodyGenFiles = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            gbLoadXmlsControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbXmlsLoadStatus).BeginInit();
            gbGenerateBodyGenFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbGenerateBodyGenFiles).BeginInit();
            gbUpdateBodyGenFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbUpdateBodyGenFiles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            lblVer.Location = new Point(794, 447);
            lblVer.Name = "lblVer";
            lblVer.Size = new Size(38, 15);
            lblVer.TabIndex = 1;
            lblVer.Text = "label1";
            // 
            // btnXmlsLoad
            // 
            btnXmlsLoad.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXmlsLoad.Location = new Point(6, 74);
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
            lblXmlsPath.Location = new Point(6, 45);
            lblXmlsPath.Name = "lblXmlsPath";
            lblXmlsPath.Size = new Size(103, 15);
            lblXmlsPath.TabIndex = 4;
            lblXmlsPath.Text = "No path provided!";
            // 
            // gbLoadXmlsControls
            // 
            gbLoadXmlsControls.Controls.Add(pbXmlsLoadStatus);
            gbLoadXmlsControls.Controls.Add(lblDefaultBodyPresetPath);
            gbLoadXmlsControls.Controls.Add(btnLoadDefaultBodyHelp);
            gbLoadXmlsControls.Controls.Add(lblDefaultBodyText);
            gbLoadXmlsControls.Controls.Add(btnLoadDefaultBody);
            gbLoadXmlsControls.Controls.Add(btnLoadXmlsHelp);
            gbLoadXmlsControls.Controls.Add(lblXmlsPath);
            gbLoadXmlsControls.Controls.Add(btnXmlsLoad);
            gbLoadXmlsControls.Controls.Add(lblXmlsPathText);
            gbLoadXmlsControls.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            gbLoadXmlsControls.Location = new Point(12, 102);
            gbLoadXmlsControls.Name = "gbLoadXmlsControls";
            gbLoadXmlsControls.Size = new Size(272, 333);
            gbLoadXmlsControls.TabIndex = 5;
            gbLoadXmlsControls.TabStop = false;
            gbLoadXmlsControls.Text = "Load Body XMLs:";
            // 
            // pbXmlsLoadStatus
            // 
            pbXmlsLoadStatus.BackColor = Color.Transparent;
            pbXmlsLoadStatus.Location = new Point(196, 280);
            pbXmlsLoadStatus.Name = "pbXmlsLoadStatus";
            pbXmlsLoadStatus.Size = new Size(70, 47);
            pbXmlsLoadStatus.SizeMode = PictureBoxSizeMode.CenterImage;
            pbXmlsLoadStatus.TabIndex = 8;
            pbXmlsLoadStatus.TabStop = false;
            // 
            // lblDefaultBodyPresetPath
            // 
            lblDefaultBodyPresetPath.AutoSize = true;
            lblDefaultBodyPresetPath.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDefaultBodyPresetPath.ForeColor = Color.Red;
            lblDefaultBodyPresetPath.Location = new Point(6, 180);
            lblDefaultBodyPresetPath.Name = "lblDefaultBodyPresetPath";
            lblDefaultBodyPresetPath.Size = new Size(103, 15);
            lblDefaultBodyPresetPath.TabIndex = 7;
            lblDefaultBodyPresetPath.Text = "No path provided!";
            // 
            // btnLoadDefaultBodyHelp
            // 
            btnLoadDefaultBodyHelp.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoadDefaultBodyHelp.Location = new Point(221, 213);
            btnLoadDefaultBodyHelp.Name = "btnLoadDefaultBodyHelp";
            btnLoadDefaultBodyHelp.Size = new Size(45, 45);
            btnLoadDefaultBodyHelp.TabIndex = 5;
            btnLoadDefaultBodyHelp.Text = "?";
            btnLoadDefaultBodyHelp.UseVisualStyleBackColor = true;
            // 
            // lblDefaultBodyText
            // 
            lblDefaultBodyText.AutoSize = true;
            lblDefaultBodyText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDefaultBodyText.Location = new Point(6, 150);
            lblDefaultBodyText.Name = "lblDefaultBodyText";
            lblDefaultBodyText.Size = new Size(172, 15);
            lblDefaultBodyText.TabIndex = 6;
            lblDefaultBodyText.Text = "Path to your default body XML:";
            // 
            // btnLoadDefaultBody
            // 
            btnLoadDefaultBody.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoadDefaultBody.Location = new Point(6, 213);
            btnLoadDefaultBody.Name = "btnLoadDefaultBody";
            btnLoadDefaultBody.Size = new Size(209, 45);
            btnLoadDefaultBody.TabIndex = 4;
            btnLoadDefaultBody.Text = "Load default body XML";
            btnLoadDefaultBody.UseVisualStyleBackColor = true;
            // 
            // btnLoadXmlsHelp
            // 
            btnLoadXmlsHelp.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoadXmlsHelp.Location = new Point(221, 74);
            btnLoadXmlsHelp.Name = "btnLoadXmlsHelp";
            btnLoadXmlsHelp.Size = new Size(45, 45);
            btnLoadXmlsHelp.TabIndex = 3;
            btnLoadXmlsHelp.Text = "?";
            btnLoadXmlsHelp.UseVisualStyleBackColor = true;
            // 
            // gbGenerateBodyGenFiles
            // 
            gbGenerateBodyGenFiles.Controls.Add(pbGenerateBodyGenFiles);
            gbGenerateBodyGenFiles.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            gbGenerateBodyGenFiles.Location = new Point(290, 102);
            gbGenerateBodyGenFiles.Name = "gbGenerateBodyGenFiles";
            gbGenerateBodyGenFiles.Size = new Size(542, 216);
            gbGenerateBodyGenFiles.TabIndex = 6;
            gbGenerateBodyGenFiles.TabStop = false;
            gbGenerateBodyGenFiles.Text = "Generate BodyGen Files:";
            // 
            // pbGenerateBodyGenFiles
            // 
            pbGenerateBodyGenFiles.BackColor = Color.Transparent;
            pbGenerateBodyGenFiles.Location = new Point(466, 163);
            pbGenerateBodyGenFiles.Name = "pbGenerateBodyGenFiles";
            pbGenerateBodyGenFiles.Size = new Size(70, 47);
            pbGenerateBodyGenFiles.SizeMode = PictureBoxSizeMode.CenterImage;
            pbGenerateBodyGenFiles.TabIndex = 9;
            pbGenerateBodyGenFiles.TabStop = false;
            // 
            // gbUpdateBodyGenFiles
            // 
            gbUpdateBodyGenFiles.Controls.Add(pbUpdateBodyGenFiles);
            gbUpdateBodyGenFiles.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            gbUpdateBodyGenFiles.Location = new Point(290, 324);
            gbUpdateBodyGenFiles.Name = "gbUpdateBodyGenFiles";
            gbUpdateBodyGenFiles.Size = new Size(542, 111);
            gbUpdateBodyGenFiles.TabIndex = 7;
            gbUpdateBodyGenFiles.TabStop = false;
            gbUpdateBodyGenFiles.Text = "Update BodyGen Files:";
            // 
            // pbUpdateBodyGenFiles
            // 
            pbUpdateBodyGenFiles.BackColor = Color.Transparent;
            pbUpdateBodyGenFiles.Location = new Point(466, 58);
            pbUpdateBodyGenFiles.Name = "pbUpdateBodyGenFiles";
            pbUpdateBodyGenFiles.Size = new Size(70, 47);
            pbUpdateBodyGenFiles.SizeMode = PictureBoxSizeMode.CenterImage;
            pbUpdateBodyGenFiles.TabIndex = 10;
            pbUpdateBodyGenFiles.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(236, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(254, 29);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(578, 67);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 471);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(gbUpdateBodyGenFiles);
            Controls.Add(gbGenerateBodyGenFiles);
            Controls.Add(gbLoadXmlsControls);
            Controls.Add(lblVer);
            Controls.Add(lblWatermark);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rubber Duck's PowerMorph Generator";
            gbLoadXmlsControls.ResumeLayout(false);
            gbLoadXmlsControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbXmlsLoadStatus).EndInit();
            gbGenerateBodyGenFiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbGenerateBodyGenFiles).EndInit();
            gbUpdateBodyGenFiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbUpdateBodyGenFiles).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Button btnLoadXmlsHelp;
        private Label lblDefaultBodyText;
        private Label lblDefaultBodyPresetPath;
        private Button btnLoadDefaultBodyHelp;
        private Button btnLoadDefaultBody;
        private PictureBox pbXmlsLoadStatus;
        private GroupBox gbGenerateBodyGenFiles;
        private PictureBox pbGenerateBodyGenFiles;
        private GroupBox gbUpdateBodyGenFiles;
        private PictureBox pbUpdateBodyGenFiles;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
