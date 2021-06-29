using System.Diagnostics;

namespace ValheimCharacterEditor.Utilities
{
    public class ValheimInstanceTools
    {
        public static bool IsValheimRunning()
        {
            Process[] processes = Process.GetProcessesByName("valheim");
            return processes.Length > 0;
        }

        public static bool TryKillValheim()
        {
            Process[] processes = Process.GetProcessesByName("valheim");
            if (processes.Length == 0) return false;
            
            try
            {
                foreach (Process process in processes)
                    process.Kill();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
