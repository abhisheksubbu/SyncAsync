using System.Threading.Tasks;

namespace SyncAsyncForm
{
    /// <summary>
    /// AsyncLooper Class performs operations in asynchronous mode
    /// </summary>
    public class AsyncLooper
    {
        private readonly Form1 _form;

        public AsyncLooper(Form1 mainForm)
        {
            _form = mainForm;
        }
        private string _webAddress = string.Empty;

        /// <summary>
        /// Starts an task for downloading the web response as string in asynchronous mode
        /// </summary>
        /// <param name="webAddress">Website URI</param>
        /// <returns>Task that yields a string response</returns>
        public Task<string> DownloadDataAsyncTask(string webAddress)
        {
            _form.ReportStatus("Data method has been invoked");
            _webAddress = webAddress;
            var task = new Task<string>(DownloadWebString);
            task.Start();
            _form.ReportStatus("Data has started to download.");
            return task;
        }

        /// <summary>
        /// Downloads the web response as string in synchronous mode
        /// </summary>
        /// <returns>Web response as string</returns>
        private string DownloadWebString()
        {
            return new SyncLooper(_form).DownloadData(_webAddress);
        }
    }
}