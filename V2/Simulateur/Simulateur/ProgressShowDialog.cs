using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
namespace Simulateur
{
    public partial class ProgressShowDialog : Form
    {
        // Flag that indcates if a process is running
        private bool isProcessRunning = false;
        public ProgressShowDialog()
        {
            InitializeComponent();
        }
        public Label LabelTitle { get { return this.Title; } set { this.Title = value; } }
       // public ProgressShowDialog(Label lb) { this.Title = lb; }
        private void ProgressShowDialog_Load(object sender, EventArgs e)
        {
           
        }

        public void UpdateProgress(int progress)
        {
            if (progressBar1.InvokeRequired)
                progressBar1.BeginInvoke(new Action(() => progressBar1.Value = progress));
            else
                progressBar1.Value = progress;

        }

        public void SetIndeterminate(bool isIndeterminate)
        {
            if (progressBar1.InvokeRequired)
            {
                progressBar1.BeginInvoke(new Action(() =>
                {
                    if (isIndeterminate)
                        progressBar1.Style = ProgressBarStyle.Marquee;
                    else
                        progressBar1.Style = ProgressBarStyle.Blocks;
                }
                ));
            }
            else
            {
                if (isIndeterminate)
                    progressBar1.Style = ProgressBarStyle.Marquee;
                else
                    progressBar1.Style = ProgressBarStyle.Blocks;
            }
        }

        public void StartProgress(ProgressShowDialog progressDialog)
        {

            // If a process is already running, warn the user and cancel the operation
            if (isProcessRunning)
            {
              
                return;
            }

          

            // Initialize the thread that will handle the background process
            Thread backgroundThread = new Thread(
                new ThreadStart(() =>
                {
                    // Set the flag that indicates if a process is currently running
                    isProcessRunning = true;

                    // Iterate from 0 - 99
                    // On each iteration, pause the thread for .05 seconds, then update the dialog's progress bar
                    for (int n = 0; n < 100; n++)
                    {
                        Thread.Sleep(20);
                        progressDialog.UpdateProgress(n);
                    }

                    // Show a dialog box that confirms the process has completed
                 //   MessageBox.Show("Thread completed!");

                    // Close the dialog if it hasn't been already
                    if (progressDialog.InvokeRequired)
                        progressDialog.BeginInvoke(new Action(() => progressDialog.Close()));

                    // Reset the flag that indicates if a process is currently running
                    isProcessRunning = false;
                }
            ));

            // Start the background process thread
            backgroundThread.Start();

            // Open the dialog
            progressDialog.ShowDialog();
        }


        private void ProgressShowDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
