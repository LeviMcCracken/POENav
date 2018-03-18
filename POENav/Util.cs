using System.ComponentModel;

namespace nav
{
    class Util
    {        
        public static BackgroundWorker createBackgroundWorker()
        {
            var bw = new BackgroundWorker();
            bw.WorkerSupportsCancellation = true;
            return bw;
        }
    }
}
