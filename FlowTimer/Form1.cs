using System;
using System.Diagnostics;
using System.Collections;
using System.Media;
using System.Data.OleDb;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

/*
 THINGS TO DO:
    1) "Finish" button code
    2) Make able to select custom sounds
    3) Finish sound gathering
    4) Fix Break timer (sometimes doesn't reset properly)
    5) Add I/O for timers and sound location memory
 */

namespace FlowTimer
{
    public partial class FlowTimer : Form
    {
        public Stopwatch enlapsedTime = new Stopwatch();
        ArrayList workSessionsList = new ArrayList(); 

        SoundPlayer soundStart = new SoundPlayer();
        string soundStartLoc;
        SoundPlayer soundBreakFin = new SoundPlayer();
        string soundEndLoc;
        SoundPlayer soundBreak = new SoundPlayer();
        string soundBreakLoc;
        SoundPlayer soundPause = new SoundPlayer();
        string soundPauseLoc;
    
        public void Form1_Load(object sender, EventArgs e)
        {
            DatabaseInit.CreateDB();

            tbxTimeEnlapsed.Text = "00:00:00";
            tbxBreak.Text = "00:00:00";

            this.Icon = Icon.ExtractAssociatedIcon("../../../graphics/icon.ico");

            List<string[]> details = DatabaseInit.LoadFiles();

            foreach (string[] file in details)
            {
                if (file[0].Equals("sounds"))
                {
                    switch (file[2])
                    {
                        case "start":
                            soundStartLoc = $"{Directory.GetCurrentDirectory()}/{file[0]}/{file[1]}";
                            break;
                        case "startBreak":
                            soundBreakLoc = $"{Directory.GetCurrentDirectory()}/{file[0]}/{file[1]}";
                            break;
                        case "finishBreak":
                            soundEndLoc = $"{Directory.GetCurrentDirectory()}/{file[0]}/{file[1]}";
                            break;
                        case "pause":
                            soundPauseLoc = $"{Directory.GetCurrentDirectory()}/{file[0]}/{file[1]}";
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (file[2])
                    {
                        case "play":
                            btnStart.BackgroundImage = Image.FromFile($"../../../{file[0]}/{file[1]}");
                            btnStart.BackgroundImageLayout = ImageLayout.Zoom;
                            break;
                        case "reset":
                            btnFinish.BackgroundImage = Image.FromFile($"../../../{file[0]}/{file[1]}");
                            btnFinish.BackgroundImageLayout = ImageLayout.Zoom;
                            break;
                        case "stop":
                            btnBreak.BackgroundImage = Image.FromFile($"../../../{file[0]}/{file[1]}");
                            btnBreak.BackgroundImageLayout = ImageLayout.Zoom;
                            break;
                        case "pause":
                            btnPause.BackgroundImage = Image.FromFile($"../../../{file[0]}/{file[1]}");
                            btnPause.BackgroundImageLayout = ImageLayout.Zoom;
                            break;
                        default:
                            break;
                    }
                }
            }

            chbxShowBreak.Checked = true;
        }

        #region BUTTONS
        private void btnStart_Click(object sender, EventArgs e)
        {
            enlapsedTime.Start();

            btnStart.Enabled = false;
            btnPause.Enabled = true;
            btnBreak.Enabled = true;
            btnFinish.Enabled = true;

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

        private void btnBreak_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Are you sure you want to begin your break?", "", MessageBoxButtons.YesNo);
            enlapsedTime.Stop();

            if (x == DialogResult.Yes)
            {
                TimeSpan workTime = enlapsedTime.Elapsed;
                double breakSeconds = (enlapsedTime.ElapsedMilliseconds / 1000) * 0.16666666666666667;
                TimeSpan breakTime = TimeSpan.FromSeconds(breakSeconds);

                Session currentSession = new Session(workTime, breakTime);

                workSessionsList.Add(currentSession);

                soundBreak.SoundLocation = soundBreakLoc;
                soundBreak.Play();

                tmrBreak.Enabled = true;
                tmrBreak.Start();

                tmrWork.Stop();
            }
            else
            {
                enlapsedTime.Start();
            }


        }

        private void btnFinish_Click(object sender, EventArgs e) //reset button
        {
            DialogResult x = MessageBox.Show("Are you sure you want to reset the timer?", "Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (x == DialogResult.Yes)
            {
                ResetTimer();
            }
        }
        #endregion

        #region TIMERS
        public void tmrWork_Tick(object sender, EventArgs e)
        {
            double breakSeconds = (enlapsedTime.ElapsedMilliseconds / 1000) * 0.222222222222222;

            TimeSpan breakSpan = TimeSpan.FromSeconds(breakSeconds);

            TimeSpan ts = enlapsedTime.Elapsed;

            #region MAIN_TIMER
            if (ts.Seconds < 10 & ts.Minutes < 10)  //main timer
            {
                tbxTimeEnlapsed.Text = $"0{ts.Hours}:0{ts.Minutes}:0{ts.Seconds}";
            }
            else if (ts.Seconds < 10 & ts.Minutes >= 10)
            {
                tbxTimeEnlapsed.Text = $"0{ts.Hours}:{ts.Minutes}:0{ts.Seconds}";
            }
            else if (ts.Seconds >= 10 & ts.Minutes < 10)
            {
                tbxTimeEnlapsed.Text = $"0{ts.Hours}:0{ts.Minutes}:{ts.Seconds}";
            }
            else
            {
                tbxTimeEnlapsed.Text = $"0{ts.Hours}:{ts.Minutes}:{ts.Seconds}";
            }
            #endregion

            #region BREAK_TIMER
            if (btnPause.Enabled)   //break timer
            {
                if (breakSpan.Seconds < 10 & breakSpan.Minutes < 10)
                {
                    tbxBreak.Text = $"00:0{breakSpan.Minutes}:0{breakSpan.Seconds}";
                }
                else if (breakSpan.Seconds >= 10 & breakSpan.Minutes < 10)
                {
                    tbxBreak.Text = $"00:0{breakSpan.Minutes}:{breakSpan.Seconds}";
                }
                else if (breakSpan.Seconds < 10 & breakSpan.Minutes >= 10)
                {
                    tbxBreak.Text = $"00:{breakSpan.Minutes}:0{breakSpan.Seconds}";
                }
                else if (ts.Minutes >= 90)
                {
                    tbxBreak.Text = "00:15:00";
                }
                else
                {
                    tbxBreak.Text = $"{breakSpan.Minutes}:{breakSpan.Seconds}";
                }

            }
            #endregion
        }

        public void tmrBreak_Tick(object sender, EventArgs e)
        {
            string breakTimeString = tbxBreak.Text;
            TimeSpan newTime = TimeSpan.Parse($"00:{breakTimeString}");
            double totSeconds = newTime.TotalSeconds;
            bool endSoundPlayed = false;

            if (totSeconds != 0)
            {
                tbxBreak.Text = newTime.Subtract(TimeSpan.FromSeconds(1)).ToString();
            }
            else if (totSeconds == 0 & endSoundPlayed == false)
            {
                soundBreakFin.SoundLocation = soundEndLoc;
                soundBreakFin.Play();

                tmrBreak.Stop();
            }
        }
        #endregion

        #region TOOLSTRIP_MENU_ITEMS
        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd2 = new OpenFileDialog()
                {
                    Filter = "Wave File (*.WAV)|*.WAV",
                    Multiselect = false,
                    ValidateNames = true
                })
                {
                    if (ofd2.ShowDialog() == DialogResult.OK)
                    {
                        soundStartLoc = DatabaseInit.AddFile("sounds", ofd2.FileName, ofd2.SafeFileName, "start");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd2 = new OpenFileDialog()
                {
                    Filter = "Wave File (*.WAV)|*.WAV",
                    Multiselect = false,
                    ValidateNames = true
                })
                {
                    if (ofd2.ShowDialog() == DialogResult.OK)
                    {
                        soundPauseLoc = DatabaseInit.AddFile("sounds", ofd2.FileName, ofd2.SafeFileName, "pause");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void finishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd2 = new OpenFileDialog()
                {
                    Filter = "Wave File (*.WAV)|*.WAV",
                    Multiselect = false,
                    ValidateNames = true
                })
                {
                    if (ofd2.ShowDialog() == DialogResult.OK)
                    {
                        soundEndLoc = DatabaseInit.AddFile("sounds", ofd2.FileName, ofd2.SafeFileName, "finish");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void breakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd2 = new OpenFileDialog()
                {
                    Filter = "Wave File (*.WAV)|*.WAV",
                    Multiselect = false,
                    ValidateNames = true
                })
                {
                    if (ofd2.ShowDialog() == DialogResult.OK)
                    {
                        soundBreakLoc = DatabaseInit.AddFile("sounds", ofd2.FileName, ofd2.SafeFileName, "break");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Developed by Michael Cullen, 2021.
                        Pause icon made by bqlqn from www.flaticon.com
                        Other icons made by Freepik from www.flaticon.com");
        }

        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                @"This app awards you 20 minutes of break time for every 90 minutes of work.
                This amount will scale up and down, depending on how long you work for.
                Work hard ;)", 
                "FlowTimer Rules", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information
                );
        }
        #endregion

        #region OTHERS
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void chbxShowBreak_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxShowBreak.Checked)
            {
                lblBreak.Visible = true;
                tbxBreak.Visible = true;
            }

            if (!chbxShowBreak.Checked)
            {
                lblBreak.Visible = false;
                tbxBreak.Visible = false;
            }
        }

        private void ResetTimer()
        {
            enlapsedTime.Reset();
            btnBreak.Enabled = false;
            btnFinish.Enabled = false;
            btnPause.Enabled = false;
            btnStart.Enabled = true;
            tbxTimeEnlapsed.Text = "00:00:00";
            tbxBreak.Text = "00:00:00";
        }

        #endregion

        public FlowTimer()
        {
            InitializeComponent();
        }

        
    }

    class Session
    {
        TimeSpan timeWork;
        TimeSpan timeBreak;

        public Session(TimeSpan timeWork, TimeSpan timeBreak)
        {
            this.timeBreak = timeBreak;
            this.timeWork = timeWork;
        }

        public TimeSpan TimeWork
        {
            get { return timeWork; }
            set { value = timeWork; }
        }

        public TimeSpan TimeBreak
        {
            get { return timeBreak; }
            set { value = timeBreak; }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
