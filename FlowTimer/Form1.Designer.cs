
namespace FlowTimer
{
    partial class FlowTimer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlowTimer));
            this.lblTimeHeading = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblBreak = new System.Windows.Forms.Label();
            this.lblShowBreak = new System.Windows.Forms.Label();
            this.chbxShowBreak = new System.Windows.Forms.CheckBox();
            this.tbxBreak = new System.Windows.Forms.TextBox();
            this.tbxTimeEnlapsed = new System.Windows.Forms.TextBox();
            this.tmrWork = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnBreak = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.tmrBreak = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soundFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.breakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.breakToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTimeHeading
            // 
            this.lblTimeHeading.AutoSize = true;
            this.lblTimeHeading.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimeHeading.Location = new System.Drawing.Point(64, 8);
            this.lblTimeHeading.Name = "lblTimeHeading";
            this.lblTimeHeading.Size = new System.Drawing.Size(87, 20);
            this.lblTimeHeading.TabIndex = 0;
            this.lblTimeHeading.Text = "Work Time:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(12, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chbxShowBreak);
            this.splitContainer1.Panel1.Controls.Add(this.lblBreak);
            this.splitContainer1.Panel1.Controls.Add(this.lblShowBreak);
            this.splitContainer1.Panel1.Controls.Add(this.lblTimeHeading);
            this.splitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbxBreak);
            this.splitContainer1.Panel2.Controls.Add(this.tbxTimeEnlapsed);
            this.splitContainer1.Panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitContainer1.Size = new System.Drawing.Size(318, 125);
            this.splitContainer1.SplitterDistance = 154;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblBreak
            // 
            this.lblBreak.AutoSize = true;
            this.lblBreak.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBreak.Location = new System.Drawing.Point(62, 40);
            this.lblBreak.Name = "lblBreak";
            this.lblBreak.Size = new System.Drawing.Size(89, 20);
            this.lblBreak.TabIndex = 2;
            this.lblBreak.Text = "Break Time:";
            this.lblBreak.Visible = false;
            // 
            // lblShowBreak
            // 
            this.lblShowBreak.AutoSize = true;
            this.lblShowBreak.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblShowBreak.Location = new System.Drawing.Point(24, 73);
            this.lblShowBreak.Name = "lblShowBreak";
            this.lblShowBreak.Size = new System.Drawing.Size(127, 20);
            this.lblShowBreak.TabIndex = 1;
            this.lblShowBreak.Text = "Show break time:";
            // 
            // chbxShowBreak
            // 
            this.chbxShowBreak.AutoSize = true;
            this.chbxShowBreak.Location = new System.Drawing.Point(133, 96);
            this.chbxShowBreak.Name = "chbxShowBreak";
            this.chbxShowBreak.Size = new System.Drawing.Size(18, 17);
            this.chbxShowBreak.TabIndex = 3;
            this.chbxShowBreak.UseVisualStyleBackColor = true;
            this.chbxShowBreak.CheckedChanged += new System.EventHandler(this.chbxShowBreak_CheckedChanged);
            // 
            // tbxBreak
            // 
            this.tbxBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxBreak.Location = new System.Drawing.Point(3, 35);
            this.tbxBreak.Name = "tbxBreak";
            this.tbxBreak.ReadOnly = true;
            this.tbxBreak.Size = new System.Drawing.Size(153, 28);
            this.tbxBreak.TabIndex = 2;
            this.tbxBreak.Visible = false;
            // 
            // tbxTimeEnlapsed
            // 
            this.tbxTimeEnlapsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxTimeEnlapsed.Location = new System.Drawing.Point(3, 3);
            this.tbxTimeEnlapsed.Name = "tbxTimeEnlapsed";
            this.tbxTimeEnlapsed.ReadOnly = true;
            this.tbxTimeEnlapsed.Size = new System.Drawing.Size(153, 28);
            this.tbxTimeEnlapsed.TabIndex = 0;
            // 
            // tmrWork
            // 
            this.tmrWork.Enabled = true;
            this.tmrWork.Interval = 1000;
            this.tmrWork.Tick += new System.EventHandler(this.tmrWork_Tick);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.Control;
            this.btnStart.BackgroundImage = global::FlowTimer.Properties.Resources.imgPlay;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.Location = new System.Drawing.Point(12, 158);
            this.btnStart.Margin = new System.Windows.Forms.Padding(0);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 75);
            this.btnStart.TabIndex = 2;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.SystemColors.Control;
            this.btnPause.Enabled = false;
            this.btnPause.Location = new System.Drawing.Point(93, 158);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 75);
            this.btnPause.TabIndex = 3;
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnBreak
            // 
            this.btnBreak.BackColor = System.Drawing.SystemColors.Control;
            this.btnBreak.Enabled = false;
            this.btnBreak.Location = new System.Drawing.Point(174, 158);
            this.btnBreak.Name = "btnBreak";
            this.btnBreak.Size = new System.Drawing.Size(75, 75);
            this.btnBreak.TabIndex = 4;
            this.btnBreak.UseVisualStyleBackColor = false;
            this.btnBreak.Click += new System.EventHandler(this.btnBreak_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.SystemColors.Control;
            this.btnFinish.Enabled = false;
            this.btnFinish.Location = new System.Drawing.Point(255, 158);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 75);
            this.btnFinish.TabIndex = 5;
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // tmrBreak
            // 
            this.tmrBreak.Interval = 1000;
            this.tmrBreak.Tick += new System.EventHandler(this.tmrBreak_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(343, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.rulesToolStripMenuItem,
            this.soundFilesToolStripMenuItem,
            this.imageFilesToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // rulesToolStripMenuItem
            // 
            this.rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            this.rulesToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.rulesToolStripMenuItem.Text = "Rules";
            this.rulesToolStripMenuItem.Click += new System.EventHandler(this.rulesToolStripMenuItem_Click);
            // 
            // soundFilesToolStripMenuItem
            // 
            this.soundFilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.finishToolStripMenuItem,
            this.breakToolStripMenuItem});
            this.soundFilesToolStripMenuItem.Name = "soundFilesToolStripMenuItem";
            this.soundFilesToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.soundFilesToolStripMenuItem.Text = "Sound Files";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // finishToolStripMenuItem
            // 
            this.finishToolStripMenuItem.Name = "finishToolStripMenuItem";
            this.finishToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.finishToolStripMenuItem.Text = "Finish";
            this.finishToolStripMenuItem.Click += new System.EventHandler(this.finishToolStripMenuItem_Click);
            // 
            // breakToolStripMenuItem
            // 
            this.breakToolStripMenuItem.Name = "breakToolStripMenuItem";
            this.breakToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.breakToolStripMenuItem.Text = "Break";
            this.breakToolStripMenuItem.Click += new System.EventHandler(this.breakToolStripMenuItem_Click);
            // 
            // imageFilesToolStripMenuItem
            // 
            this.imageFilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem1,
            this.pauseToolStripMenuItem1,
            this.breakToolStripMenuItem1,
            this.resetToolStripMenuItem});
            this.imageFilesToolStripMenuItem.Name = "imageFilesToolStripMenuItem";
            this.imageFilesToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.imageFilesToolStripMenuItem.Text = "Image Files";
            // 
            // startToolStripMenuItem1
            // 
            this.startToolStripMenuItem1.Name = "startToolStripMenuItem1";
            this.startToolStripMenuItem1.Size = new System.Drawing.Size(129, 26);
            this.startToolStripMenuItem1.Text = "Start";
            // 
            // pauseToolStripMenuItem1
            // 
            this.pauseToolStripMenuItem1.Name = "pauseToolStripMenuItem1";
            this.pauseToolStripMenuItem1.Size = new System.Drawing.Size(129, 26);
            this.pauseToolStripMenuItem1.Text = "Pause";
            // 
            // breakToolStripMenuItem1
            // 
            this.breakToolStripMenuItem1.Name = "breakToolStripMenuItem1";
            this.breakToolStripMenuItem1.Size = new System.Drawing.Size(129, 26);
            this.breakToolStripMenuItem1.Text = "Break";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.resetToolStripMenuItem.Text = "Reset";
            // 
            // FlowTimer
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 246);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnBreak);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FlowTimer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlowTimer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimeHeading;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblBreak;
        private System.Windows.Forms.Label lblShowBreak;
        private System.Windows.Forms.CheckBox chbxShowBreak;
        private System.Windows.Forms.TextBox tbxBreak;
        private System.Windows.Forms.TextBox tbxTimeEnlapsed;
        private System.Windows.Forms.Timer tmrWork;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnBreak;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Timer tmrBreak;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soundFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem breakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem breakToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
    }
}

