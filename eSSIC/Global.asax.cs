using System;
using System.ComponentModel;
using System.Web;

namespace eSSIC
{
    public class Global : HttpApplication
    {
        public static BackgroundWorker mosWorker = new BackgroundWorker();
        
        protected void Application_Start(object sender, EventArgs e)
        {
            InitializeBackgroundWorker();
            Application["mosOverrideTags"] = null;
            Application["mosOverrideTime"] = null;
            Application["mosOverrideStatus"] = false;
        }

        protected void Application_End(object sender, EventArgs e)
        {
            Application["mosOverrideTags"] = null;
            Application["mosOverrideTime"] = null;
            Application["mosOverrideStatus"] = null;
        }

        private void InitializeBackgroundWorker()
        {
            mosWorker.DoWork += new DoWorkEventHandler(AsyncStart);
            mosWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(AsyncCompleted);
            //mosWorker.ProgressChanged += new ProgressChangedEventHandler(AsyncProgress);

            mosWorker.WorkerReportsProgress = false;
            mosWorker.WorkerSupportsCancellation = false;
        }

        private void AsyncStart(object s, DoWorkEventArgs e)
        {
            try
            {
                Application["mosOverrideStatus"] = false;
                var holderArray = new admin.Helper().GetMosOverrideTag();

                Application["mosOverrideTags"] = holderArray;
                Application["mosOverrideStatus"] = true;
            }
            catch { }            
        }

        private void AsyncCompleted(object s, RunWorkerCompletedEventArgs e)
        {
            Application["mosOverrideTime"] = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
        }

        /*
        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }        
        */
    }
}