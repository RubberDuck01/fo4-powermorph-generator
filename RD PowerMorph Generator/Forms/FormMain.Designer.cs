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
            btnLoadXmlsHelp = new Button();
            gbGenerateBodyGenFiles = new GroupBox();
            progressBar1 = new ProgressBar();
            pictureBox4 = new PictureBox();
            label4 = new Label();
            button3 = new Button();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            gbUpdateBodyGenFiles = new GroupBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label6 = new Label();
            button2 = new Button();
            pictureBox5 = new PictureBox();
            progressBar2 = new ProgressBar();
            label7 = new Label();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            gbLoadXmlsControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbDefBodyLoad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbXmlsLoadStatus).BeginInit();
            gbGenerateBodyGenFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            gbUpdateBodyGenFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
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
            gbLoadXmlsControls.Controls.Add(btnLoadXmlsHelp);
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
            pbDefBodyLoad.Location = new Point(221, 138);
            pbDefBodyLoad.Name = "pbDefBodyLoad";
            pbDefBodyLoad.Size = new Size(45, 45);
            pbDefBodyLoad.SizeMode = PictureBoxSizeMode.CenterImage;
            pbDefBodyLoad.TabIndex = 11;
            pbDefBodyLoad.TabStop = false;
            // 
            // pbXmlsLoadStatus
            // 
            pbXmlsLoadStatus.BackColor = Color.Transparent;
            pbXmlsLoadStatus.Location = new Point(221, 52);
            pbXmlsLoadStatus.Name = "pbXmlsLoadStatus";
            pbXmlsLoadStatus.Size = new Size(45, 45);
            pbXmlsLoadStatus.SizeMode = PictureBoxSizeMode.CenterImage;
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
            // btnLoadXmlsHelp
            // 
            btnLoadXmlsHelp.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoadXmlsHelp.Location = new Point(245, 15);
            btnLoadXmlsHelp.Name = "btnLoadXmlsHelp";
            btnLoadXmlsHelp.Size = new Size(21, 23);
            btnLoadXmlsHelp.TabIndex = 3;
            btnLoadXmlsHelp.Text = "?";
            btnLoadXmlsHelp.UseVisualStyleBackColor = true;
            // 
            // gbGenerateBodyGenFiles
            // 
            gbGenerateBodyGenFiles.BackColor = Color.Transparent;
            gbGenerateBodyGenFiles.Controls.Add(button4);
            gbGenerateBodyGenFiles.Controls.Add(progressBar1);
            gbGenerateBodyGenFiles.Controls.Add(pictureBox4);
            gbGenerateBodyGenFiles.Controls.Add(label4);
            gbGenerateBodyGenFiles.Controls.Add(button3);
            gbGenerateBodyGenFiles.Controls.Add(label3);
            gbGenerateBodyGenFiles.Controls.Add(pictureBox3);
            gbGenerateBodyGenFiles.Controls.Add(button1);
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
            // progressBar1
            // 
            progressBar1.Location = new Point(6, 174);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(530, 15);
            progressBar1.TabIndex = 17;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Location = new Point(221, 116);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(45, 45);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
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
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(6, 116);
            button3.Name = "button3";
            button3.Size = new Size(209, 45);
            button3.TabIndex = 14;
            button3.Text = "Select output directory...";
            button3.UseVisualStyleBackColor = true;
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
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Location = new Point(221, 44);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(45, 45);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(6, 44);
            button1.Name = "button1";
            button1.Size = new Size(209, 45);
            button1.TabIndex = 10;
            button1.Text = "Select output directory...";
            button1.UseVisualStyleBackColor = true;
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
            gbUpdateBodyGenFiles.Controls.Add(button5);
            gbUpdateBodyGenFiles.Controls.Add(label7);
            gbUpdateBodyGenFiles.Controls.Add(progressBar2);
            gbUpdateBodyGenFiles.Controls.Add(pictureBox5);
            gbUpdateBodyGenFiles.Controls.Add(button2);
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
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
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
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(254, 29);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(578, 67);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(button6);
            groupBox1.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 303);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(272, 132);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Application load data";
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
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(6, 37);
            button2.Name = "button2";
            button2.Size = new Size(209, 45);
            button2.TabIndex = 18;
            button2.Text = "Go!";
            button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Location = new Point(221, 37);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(45, 45);
            pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox5.TabIndex = 18;
            pictureBox5.TabStop = false;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(6, 111);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(530, 15);
            progressBar2.TabIndex = 19;
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
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(515, 15);
            button4.Name = "button4";
            button4.Size = new Size(21, 23);
            button4.TabIndex = 12;
            button4.Text = "?";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(515, 15);
            button5.Name = "button5";
            button5.Size = new Size(21, 23);
            button5.TabIndex = 18;
            button5.Text = "?";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(245, 15);
            button6.Name = "button6";
            button6.Size = new Size(21, 23);
            button6.TabIndex = 10;
            button6.Text = "?";
            button6.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(844, 471);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            gbUpdateBodyGenFiles.ResumeLayout(false);
            gbUpdateBodyGenFiles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
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
        private Button btnLoadDefaultBody;
        private PictureBox pbXmlsLoadStatus;
        private GroupBox gbGenerateBodyGenFiles;
        private GroupBox gbUpdateBodyGenFiles;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private Label label2;
        private Label label1;
        private PictureBox pbDefBodyLoad;
        private PictureBox pictureBox3;
        private Label label3;
        private ProgressBar progressBar1;
        private PictureBox pictureBox4;
        private Label label4;
        private Button button3;
        private Label label7;
        private ProgressBar progressBar2;
        private PictureBox pictureBox5;
        private Button button2;
        private Label label6;
        private Label label5;
        private GroupBox groupBox1;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}
