using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace FlowTimer {
  public partial class FlowTimer : Form {
    public Stopwatch enlapsedTime = new Stopwatch();

    string soundStartLoc;
    string soundEndLoc;
    string soundBreakLoc;
    string soundPauseLoc;
    SoundPlayer soundStart = new SoundPlayer();
    SoundPlayer soundBreakFin = new SoundPlayer();
    SoundPlayer soundBreak = new SoundPlayer();
    SoundPlayer soundPause = new SoundPlayer();

    public void Form_Load(object sender, EventArgs e) {
      tbxTimeEnlapsed.Text = "00:00:00";
      tbxBreak.Text = "00:00:00";

      this.Icon = Icon.ExtractAssociatedIcon("graphics/icon.ico");

      soundStartLoc = $"sounds/bing.wav";
      soundBreakLoc = $"sounds/bong.wav";
      soundEndLoc = $"sounds/break_fin.wav";
      soundPauseLoc = $"sounds/bong_short.wav";

      btnStart.BackgroundImage = Image.FromFile($"graphics/imgPlay.png");
      btnStart.BackgroundImageLayout = ImageLayout.Zoom;
      btnPause.BackgroundImage = Image.FromFile($"graphics/imgPause.png");
      btnPause.BackgroundImageLayout = ImageLayout.Zoom;
      btnBreak.BackgroundImage = Image.FromFile($"graphics/imgStop.png");
      btnBreak.BackgroundImageLayout = ImageLayout.Zoom;
      btnReset.BackgroundImage = Image.FromFile($"graphics/imgReset.png");
      btnReset.BackgroundImageLayout = ImageLayout.Zoom;
    }

    #region BUTTONS
    private void btnStart_Click(object sender, EventArgs e) {
      enlapsedTime.Start();

      btnStart.Enabled = false;
      btnPause.Enabled = true;
      btnBreak.Enabled = true;
      btnReset.Enabled = true;

      soundStart.SoundLocation = soundStartLoc;
      soundStart.Play();

    }

    private void btnStop_Click(object sender, EventArgs e) //pause button
    {
      enlapsedTime.Stop();

      btnStart.Enabled = true;
      btnPause.Enabled = false;

      soundPause.SoundLocation = soundPauseLoc;
      soundPause.Play();

    }

    private void btnBreak_Click(object sender, EventArgs e) {
      DialogResult x = MessageBox.Show("Are you sure you want to begin your break?", "", MessageBoxButtons.YesNo);
      enlapsedTime.Stop();

      if (x == DialogResult.Yes) {
        TimeSpan workTime = enlapsedTime.Elapsed;
        double breakSeconds = (enlapsedTime.ElapsedMilliseconds / 1000) * 0.16666666666666667;
        TimeSpan breakTime = TimeSpan.FromSeconds(breakSeconds);

        soundBreak.SoundLocation = soundBreakLoc;
        soundBreak.Play();

        tmrBreak.Enabled = true;
        tmrBreak.Start();

        tmrWork.Stop();
      }
      else {
        enlapsedTime.Start();
      }


    }

    private void btnFinish_Click(object sender, EventArgs e) //reset button
    {
      DialogResult x = MessageBox.Show("Are you sure you want to reset the timer?", "Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (x == DialogResult.Yes) {
        ResetTimer();
      }
    }
    #endregion

    #region TIMERS
    public void tmrWork_Tick(object sender, EventArgs e) {
      double breakSeconds = (enlapsedTime.ElapsedMilliseconds / 1000) * 0.222222222222222;

      TimeSpan breakSpan = TimeSpan.FromSeconds(breakSeconds);

      TimeSpan ts = enlapsedTime.Elapsed;

      #region MAIN_TIMER
      if (ts.Seconds < 10 & ts.Minutes < 10)  //main timer
      {
        tbxTimeEnlapsed.Text = $"0{ts.Hours}:0{ts.Minutes}:0{ts.Seconds}";
      }
      else if (ts.Seconds < 10 & ts.Minutes >= 10) {
        tbxTimeEnlapsed.Text = $"0{ts.Hours}:{ts.Minutes}:0{ts.Seconds}";
      }
      else if (ts.Seconds >= 10 & ts.Minutes < 10) {
        tbxTimeEnlapsed.Text = $"0{ts.Hours}:0{ts.Minutes}:{ts.Seconds}";
      }
      else {
        tbxTimeEnlapsed.Text = $"0{ts.Hours}:{ts.Minutes}:{ts.Seconds}";
      }
      #endregion

      #region BREAK_TIMER
      if (btnPause.Enabled)   //break timer
      {
        if (breakSpan.Seconds < 10 & breakSpan.Minutes < 10) {
          tbxBreak.Text = $"00:0{breakSpan.Minutes}:0{breakSpan.Seconds}";
        }
        else if (breakSpan.Seconds >= 10 & breakSpan.Minutes < 10) {
          tbxBreak.Text = $"00:0{breakSpan.Minutes}:{breakSpan.Seconds}";
        }
        else if (breakSpan.Seconds < 10 & breakSpan.Minutes >= 10) {
          tbxBreak.Text = $"00:{breakSpan.Minutes}:0{breakSpan.Seconds}";
        }
        else if (ts.Minutes >= 90) {
          tbxBreak.Text = "00:15:00";
        }
        else {
          tbxBreak.Text = $"{breakSpan.Minutes}:{breakSpan.Seconds}";
        }

      }
      #endregion
    }

    public void tmrBreak_Tick(object sender, EventArgs e) {
      string breakTimeString = tbxBreak.Text;
      TimeSpan newTime = TimeSpan.Parse($"00:{breakTimeString}");
      double totSeconds = newTime.TotalSeconds;
      bool endSoundPlayed = false;

      if (totSeconds != 0) {
        tbxBreak.Text = newTime.Subtract(TimeSpan.FromSeconds(1)).ToString();
      }
      else if (totSeconds == 0 & endSoundPlayed == false) {
        soundBreakFin.SoundLocation = soundEndLoc;
        soundBreakFin.Play();

        tmrBreak.Stop();
      }
    }
    #endregion

    #region TOOLSTRIP_MENU_ITEMS

    private void rulesToolStripMenuItem_Click(object sender, EventArgs e) {
      MessageBox.Show(
          @"This app awards you 20 minutes of break time for every 90 minutes of work.
                This amount will scale up and down, depending on how long you work for.",
          "How to Use",
          MessageBoxButtons.OK,
          MessageBoxIcon.Information
          );
    }
    #endregion

    #region OTHERS
    private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e) {

    }

    private void chbxShowBreak_CheckedChanged(object sender, EventArgs e) {
      if (showBreakTimerToolStripMenuItem.Checked) {
        lblBreak.Visible = true;
        tbxBreak.Visible = true;
      }

      if (!showBreakTimerToolStripMenuItem.Checked) {
        lblBreak.Visible = false;
        tbxBreak.Visible = false;
      }
    }

    private void ResetTimer() {
      enlapsedTime.Reset();
      btnBreak.Enabled = false;
      btnReset.Enabled = false;
      btnPause.Enabled = false;
      btnStart.Enabled = true;
      tbxTimeEnlapsed.Text = "00:00:00";
      tbxBreak.Text = "00:00:00";
    }

    #endregion

    public FlowTimer() {
      InitializeComponent();
    }

    private void alwaysOnTopToolStripMenuItem_CheckedChanged(object sender, EventArgs e) {

    }

    private void showBreakTimerToolStripMenuItem_Click(object sender, EventArgs e) {
      if (showBreakTimerToolStripMenuItem.Checked) {
        showBreakTimerToolStripMenuItem.Checked = false;
      }
      else {
        showBreakTimerToolStripMenuItem.Checked = true;
      }
    }
  }
}
