using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kocaeli_Travel_App
{
    public class Commander
    {
        NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public void InfoLogger(string text)
        {
            logger.Info(text);
        }
        public void FatalErrorLogger(string text)
        {
            logger.Fatal(text);
            logger.Error(text);
        }
        public void WarnLogger(string text)
        {
            logger.Warn(text);
        }
        public void DebugLogger(string text)
        {
            logger.Debug(text);
        }
        public void TraceLogger(string text)
        {
            logger.Trace(text);
        }
    }
}
