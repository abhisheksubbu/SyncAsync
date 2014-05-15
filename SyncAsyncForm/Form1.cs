using System;
using System.Windows.Forms;

namespace SyncAsyncForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button that downloads requested resource as string in asynchronous mode 
        /// </summary>
        /// <param name="sender">Bsutton object in Form</param>
        /// <param name="e">Mouse click event args</param>
        private async void btn_StartAsyncLooping_Click(object sender, EventArgs e)
        {
            txt_Status.Text = String.Empty;
            ReportStatus("Before starting the DownloadData method");
            ReportStatus(await new AsyncLooper(this).DownloadDataAsyncTask("http://www.msdn.com"));
            ReportStatus("After calling the DownloadData method");
        }

        /// <summary>
        /// Button that downloads requested resource as string in synchronous mode
        /// </summary>
        /// <param name="sender">Button object in Form</param>
        /// <param name="e">Mouse click event args</param>
        private void btn_StartSyncLooping_Click(object sender, EventArgs e)
        {
            txt_Status.Text = String.Empty;
            ReportStatus("Before starting the DownloadData method");
            ReportStatus(new SyncLooper(this).DownloadData("http://www.msdn.com"));
            ReportStatus("After calling the DownloadData method");
        }

        /// <summary>
        /// Button that executes jobs on pre-emptive multitasking
        /// </summary>
        /// <param name="sender">Button object in Form</param>
        /// <param name="e">Mouse click event args</param>
        private void btn_StartParallelExecution_Click(object sender, EventArgs e)
        {
            txt_Status.Text = String.Empty;
            var processor = new ParallelProcessor(this);
            processor.StartParallelExecution();
        }

        /// <summary>
        /// Method to update status messages on the textbox in a different thread
        /// </summary>
        /// <param name="status"></param>
        public void ReportStatus(string status)
        {
            MethodInvoker action = delegate
            {
                txt_Status.Text += status + Environment.NewLine;

            };
            txt_Status.BeginInvoke(action);
        }
    }
}