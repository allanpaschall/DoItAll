using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Timers;
using System.Diagnostics;

namespace CopyFiletoWebserver
{
    public partial class Form1 : Form
    {
        static System.Windows.Forms.Timer _timer;
        public Form1()
        {
            InitializeComponent();
        }
        public void copyAssessment()
        {
            try
            {
                File.Copy("\\\\nmmi.local\\Academic\\Assessment\\NMMIAssessmentDatabase.accdb", "\\\\cub\\inetpub\\wwwroot\\intranet\\NMMIAssessmentDatabase.accdb", true);
                lblResult.Text = "Result: Success!";
                resetResult();
            }
            catch (Exception)
            {
                lblResult.Text = "Result: Failed!";
                resetResult();
                throw;
            }
            
        }

        public void copyAssurance()
        {
            try
            {
                File.Copy("\\\\nmmi.local\\Academic\\Assessment\\AssuranceSystemDatabaseInterface.accdb", "\\\\cub\\inetpub\\wwwroot\\intranet\\NMMIAssuranceSystemDatabase.accdb", true);
                lblResult.Text = "Result: Success!";
                resetResult();
            }
            catch (Exception)
            {
                lblResult.Text = "Result: Failed!";
                resetResult();
                throw;
            }

        }

        public void resetResult()
        {
            _timer = new System.Windows.Forms.Timer();
            _timer.Tick += _timer_Tick;
            _timer.Interval = 3000;
            _timer.Start();
        }

        void _timer_Tick(object sender, EventArgs e)
        {
            lblResult.Text = "Result: ";
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            copyAssessment();
        }

        private void btnCopyAssurance_Click(object sender, EventArgs e)
        {
            copyAssurance();
        }

        private void btnSomeMath_Click(object sender, EventArgs e)
        {
            int counter = 0;
            for (int i = 0; i <= 1000; i++)
            {
                if (i % 3 == 0)
                {
                    counter++;
                }
            }
            label3.Text = counter.ToString();
        }

        private void btnContrLog_Click(object sender, EventArgs e)
        {
            Process perl = new Process();
            perl.StartInfo.FileName = "C:\\Perl\\bin\\perl.exe";
            perl.StartInfo.Arguments = "C:\\Users\\Paschall\\desktop\\ctnetperformancelog\\ContributeLogParser.pl";
            perl.StartInfo.WorkingDirectory = "C:\\Users\\Paschall\\desktop\\ctnetperformancelog\\";
            perl.StartInfo.UseShellExecute = true;
            perl.StartInfo.RedirectStandardOutput = false;
            perl.Start();

            //string output = perl.StandardOutput.ReadToEnd();
            perl.WaitForExit();

            Console.WriteLine("Output:");
            //Console.WriteLine(output);
        }

    }
}
