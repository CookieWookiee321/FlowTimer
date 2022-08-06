
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
      this.lblBreak = new System.Windows.Forms.Label();
      this.tbxBreak = new System.Windows.Forms.TextBox();
      this.tbxTimeEnlapsed = new System.Windows.Forms.TextBox();
      this.tmrWork = new System.Windows.Forms.Timer(this.components);
      this.btnStart = new System.Windows.Forms.Button();
      this.btnPause = new System.Windows.Forms.Button();
      this.btnBreak = new System.Windows.Forms.Button();
      this.btnReset = new System.Windows.Forms.Button();
      this.tmrBreak = new System.Windows.Forms.Timer(this.components);
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.showBreakTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.menuStrip1.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // lblTimeHeading
      // 
      this.lblTimeHeading.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.lblTimeHeading.AutoSize = true;
      this.lblTimeHeading.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblTimeHeading.Location = new System.Drawing.Point(31, 10);
      this.lblTimeHeading.Name = "lblTimeHeading";
      this.lblTimeHeading.Size = new System.Drawing.Size(96, 22);
      this.lblTimeHeading.TabIndex = 0;
      this.lblTimeHeading.Text = "Work Time:";
      // 
      // lblBreak
      // 
      this.lblBreak.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.lblBreak.AutoSize = true;
      this.lblBreak.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblBreak.Location = new System.Drawing.Point(29, 54);
      this.lblBreak.Name = "lblBreak";
      this.lblBreak.Size = new System.Drawing.Size(99, 22);
      this.lblBreak.TabIndex = 2;
      this.lblBreak.Text = "Break Time:";
      // 
      // tbxBreak
      // 
      this.tbxBreak.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbxBreak.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.tbxBreak.Location = new System.Drawing.Point(161, 46);
      this.tbxBreak.Name = "tbxBreak";
      this.tbxBreak.ReadOnly = true;
      this.tbxBreak.Size = new System.Drawing.Size(153, 38);
      this.tbxBreak.TabIndex = 2;
      // 
      // tbxTimeEnlapsed
      // 
      this.tbxTimeEnlapsed.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbxTimeEnlapsed.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.tbxTimeEnlapsed.Location = new System.Drawing.Point(161, 3);
      this.tbxTimeEnlapsed.Name = "tbxTimeEnlapsed";
      this.tbxTimeEnlapsed.ReadOnly = true;
      this.tbxTimeEnlapsed.Size = new System.Drawing.Size(153, 38);
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
      this.btnStart.Location = new System.Drawing.Point(11, 119);
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
      this.btnPause.Location = new System.Drawing.Point(92, 119);
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
      this.btnBreak.Location = new System.Drawing.Point(173, 119);
      this.btnBreak.Name = "btnBreak";
      this.btnBreak.Size = new System.Drawing.Size(75, 75);
      this.btnBreak.TabIndex = 4;
      this.btnBreak.UseVisualStyleBackColor = false;
      this.btnBreak.Click += new System.EventHandler(this.btnBreak_Click);
      // 
      // btnReset
      // 
      this.btnReset.BackColor = System.Drawing.SystemColors.Control;
      this.btnReset.Enabled = false;
      this.btnReset.Location = new System.Drawing.Point(254, 119);
      this.btnReset.Name = "btnReset";
      this.btnReset.Size = new System.Drawing.Size(75, 75);
      this.btnReset.TabIndex = 5;
      this.btnReset.UseVisualStyleBackColor = false;
      this.btnReset.Click += new System.EventHandler(this.btnFinish_Click);
      // 
      // tmrBreak
      // 
      this.tmrBreak.Interval = 1000;
      this.tmrBreak.Tick += new System.EventHandler(this.tmrBreak_Tick);
      // 
      // menuStrip1
      // 
      this.menuStrip1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem1});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(340, 26);
      this.menuStrip1.TabIndex = 6;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.Checked = true;
      this.fileToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showBreakTimerToolStripMenuItem,
            this.alwaysOnTopToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(71, 22);
      this.fileToolStripMenuItem.Text = "Settings";
      // 
      // showBreakTimerToolStripMenuItem
      // 
      this.showBreakTimerToolStripMenuItem.Checked = true;
      this.showBreakTimerToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
      this.showBreakTimerToolStripMenuItem.Name = "showBreakTimerToolStripMenuItem";
      this.showBreakTimerToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
      this.showBreakTimerToolStripMenuItem.Text = "Show Break Timer";
      this.showBreakTimerToolStripMenuItem.CheckedChanged += new System.EventHandler(this.chbxShowBreak_CheckedChanged);
      this.showBreakTimerToolStripMenuItem.Click += new System.EventHandler(this.showBreakTimerToolStripMenuItem_Click);
      // 
      // alwaysOnTopToolStripMenuItem
      // 
      this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
      this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
      this.alwaysOnTopToolStripMenuItem.Text = "Always On Top";
      this.alwaysOnTopToolStripMenuItem.CheckedChanged += new System.EventHandler(this.alwaysOnTopToolStripMenuItem_CheckedChanged);
      // 
      // helpToolStripMenuItem
      // 
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(51, 22);
      this.helpToolStripMenuItem.Text = "Help";
      this.helpToolStripMenuItem.Click += new System.EventHandler(this.rulesToolStripMenuItem_Click);
      // 
      // aboutToolStripMenuItem1
      // 
      this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
      this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(60, 22);
      this.aboutToolStripMenuItem1.Text = "About";
      this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.rulesToolStripMenuItem_Click);
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Controls.Add(this.lblTimeHeading, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.tbxBreak, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.lblBreak, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.tbxTimeEnlapsed, 1, 0);
      this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 29);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(317, 87);
      this.tableLayoutPanel1.TabIndex = 7;
      // 
      // FlowTimer
      // 
      this.AcceptButton = this.btnStart;
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(340, 204);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Controls.Add(this.btnReset);
      this.Controls.Add(this.btnBreak);
      this.Controls.Add(this.btnPause);
      this.Controls.Add(this.btnStart);
      this.Controls.Add(this.menuStrip1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "FlowTimer";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "FlowTimer";
      this.Load += new System.EventHandler(this.Form_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimeHeading;
        private System.Windows.Forms.Label lblBreak;
        private System.Windows.Forms.TextBox tbxBreak;
        private System.Windows.Forms.TextBox tbxTimeEnlapsed;
        private System.Windows.Forms.Timer tmrWork;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnBreak;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Timer tmrBreak;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem showBreakTimerToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
  }
}

