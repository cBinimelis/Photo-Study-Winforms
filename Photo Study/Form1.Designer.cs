namespace Photo_Study
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn_openFolder = new Button();
            pb_demoImg = new PictureBox();
            btn_quit = new Button();
            btn_startSession = new Button();
            comboBox1 = new ComboBox();
            progressBar1 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)pb_demoImg).BeginInit();
            SuspendLayout();
            // 
            // btn_openFolder
            // 
            btn_openFolder.BackColor = Color.SlateBlue;
            btn_openFolder.Cursor = Cursors.Hand;
            btn_openFolder.FlatAppearance.BorderSize = 0;
            btn_openFolder.FlatAppearance.MouseDownBackColor = Color.DarkSlateBlue;
            btn_openFolder.FlatAppearance.MouseOverBackColor = Color.MediumSlateBlue;
            resources.ApplyResources(btn_openFolder, "btn_openFolder");
            btn_openFolder.Name = "btn_openFolder";
            btn_openFolder.UseVisualStyleBackColor = false;
            // 
            // pb_demoImg
            // 
            resources.ApplyResources(pb_demoImg, "pb_demoImg");
            pb_demoImg.Image = Properties.Resources.demo;
            pb_demoImg.Name = "pb_demoImg";
            pb_demoImg.TabStop = false;
            // 
            // btn_quit
            // 
            btn_quit.BackColor = Color.IndianRed;
            btn_quit.Cursor = Cursors.Hand;
            btn_quit.FlatAppearance.BorderSize = 0;
            btn_quit.FlatAppearance.MouseDownBackColor = Color.Firebrick;
            btn_quit.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            resources.ApplyResources(btn_quit, "btn_quit");
            btn_quit.Name = "btn_quit";
            btn_quit.UseVisualStyleBackColor = false;
            btn_quit.MouseClick += btn_quit_MouseClick;
            // 
            // btn_startSession
            // 
            btn_startSession.BackColor = Color.SlateBlue;
            btn_startSession.Cursor = Cursors.Hand;
            btn_startSession.FlatAppearance.BorderSize = 0;
            btn_startSession.FlatAppearance.MouseDownBackColor = Color.DarkSlateBlue;
            btn_startSession.FlatAppearance.MouseOverBackColor = Color.MediumSlateBlue;
            resources.ApplyResources(btn_startSession, "btn_startSession");
            btn_startSession.Name = "btn_startSession";
            btn_startSession.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.DarkSlateBlue;
            comboBox1.Cursor = Cursors.Hand;
            comboBox1.DisplayMember = "0";
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            resources.ApplyResources(comboBox1, "comboBox1");
            comboBox1.ForeColor = SystemColors.Window;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { resources.GetString("comboBox1.Items"), resources.GetString("comboBox1.Items1"), resources.GetString("comboBox1.Items2"), resources.GetString("comboBox1.Items3"), resources.GetString("comboBox1.Items4"), resources.GetString("comboBox1.Items5"), resources.GetString("comboBox1.Items6"), resources.GetString("comboBox1.Items7") });
            comboBox1.Name = "comboBox1";
            // 
            // progressBar1
            // 
            resources.ApplyResources(progressBar1, "progressBar1");
            progressBar1.Name = "progressBar1";
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.Value = 60;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            Controls.Add(progressBar1);
            Controls.Add(comboBox1);
            Controls.Add(btn_startSession);
            Controls.Add(btn_quit);
            Controls.Add(pb_demoImg);
            Controls.Add(btn_openFolder);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pb_demoImg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_openFolder;
        private PictureBox pb_demoImg;
        private Button btn_quit;
        private Button btn_startSession;
        private ComboBox comboBox1;
        private ProgressBar progressBar1;
    }
}