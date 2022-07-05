using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ShutdownTimer {
    public partial class ShutdownTimer : Form {
        public ShutdownTimer() {
            InitializeComponent();
            DateTime dt = DateTime.Now;
            radioButtonTimer.Checked = true;
            textBoxDYear.Text = dt.ToString("yyyy");
            textBoxDMonth.Text = dt.ToString("MM");
            textBoxDDate.Text = dt.ToString("dd");
            int hour = int.Parse(dt.ToString("HH")) + 1;
            ;
            textBoxDHour.Text = hour.ToString();
            textBoxDMin.Text = "0";
        }

        private void buttonShutdown_Click(object sender, EventArgs e) {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "shutdown.exe";
            if (radioButtonTimer.Checked) {
                int hour = int.Parse(textBoxTHour.Text);
                int min = int.Parse(textBoxTMin.Text);
                int sec = int.Parse(textBoxTSec.Text);

                long time = hour * 3600 + min * 60 + sec;
                string times = time.ToString();

                if (checkBoxReboot.Checked) {
                    psi.Arguments = "-r -t " + times;
                } else {
                    psi.Arguments = "-s -t " + times;
                }
            }
            if (radioButtonDate.Checked) {
                int year = int.Parse(textBoxDYear.Text);
                int month = int.Parse(textBoxDMonth.Text);
                int date = int.Parse(textBoxDDate.Text);
                int hour = int.Parse(textBoxDHour.Text);
                int min = int.Parse(textBoxDMin.Text);
                DateTime dt = DateTime.Now;
                DateTime dtset = new DateTime(year, month, date, hour, min, 0);
                TimeSpan ts = dtset - dt;
                long time = (long)ts.TotalSeconds + 1;
                String times = time.ToString();

                if (checkBoxReboot.Checked) {
                    psi.Arguments = "-r -t " + times;
                } else {
                    psi.Arguments = "-s -t " + times;
                }
                psi.CreateNoWindow = true;
            }
            if (radioButtonSoon.Checked) {   
                if (checkBoxReboot.Checked) {
                    psi.Arguments = "-r -t 0";
                } else {
                    psi.Arguments = "-s -t 0";
                }              
            }
            if (checkBoxForce.Checked) {
                psi.Arguments += " -f";
            }
            psi.CreateNoWindow = true;
            Process p = Process.Start(psi);
        }


        private void buttonCancel_Click(object sender, EventArgs e) {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "shutdown.exe";
            psi.Arguments = "-a";
            psi.CreateNoWindow = true;
            Process p = Process.Start(psi);
        }
    }
}
