using System.Threading;

namespace SyncAsyncForm
{
    public class ParallelProcessor
    {
        private readonly Form1 _form;
        public ParallelProcessor(Form1 mainForm)
        {
            _form = mainForm;
        }

        public void StartParallelExecution()
        {
            var newThread = new Thread(MainJob);
            newThread.Start();
            SubJob();
            newThread.Join();
        }

        private void MainJob()
        {
            for (var count = 0; count <= 100; count++)
            {
                _form.ReportStatus("Main Job "+count);
            }
        }

        private void SubJob()
        {
            for (var count = 0; count <= 100; count++)
            {
                _form.ReportStatus("Sub Job " + count);
            }
        }
    }
}
