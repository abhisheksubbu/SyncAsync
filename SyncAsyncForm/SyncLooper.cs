using System.Net;

namespace SyncAsyncForm
{
    /// <summary>
    /// SyncLooper Class performs operations in synchronous mode
    /// </summary>
    public class SyncLooper
    {
        private readonly Form1 _form;

        public SyncLooper(Form1 mainForm)
        {
            _form = mainForm;
        }
        /// <summary>
        /// Downloads the web response as string in synchronous mode
        /// </summary>
        /// <param name="webAddress">Website URI</param>
        /// <returns>Web Response as string</returns>
        public string DownloadData(string webAddress)
        {
            var data = new WebClient().DownloadString(webAddress);
            _form.ReportStatus("Data has been downloaded");
            return data;
        }
    }
}