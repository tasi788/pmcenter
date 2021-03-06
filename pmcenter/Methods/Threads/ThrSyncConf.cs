using System;
using System.Threading;

namespace pmcenter
{
    public partial class Methods
    {
        public static async void ThrSyncConf()
        {
            while (true)
            {
                try
                {
                    await Conf.SaveConf(false, true);
                    Log("Configurations saved.", "CONFSYNC");
                }
                catch (Exception ex)
                {
                    Log("Failed to write configurations to local disk: " + ex.Message, "CONFSYNC", LogLevel.ERROR);
                }
                Thread.Sleep(30000);
            }
        }
    }
}