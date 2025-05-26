using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace executor
{
    internal class Api
    {
        public static bool IsRobloxOpen()
        {
            return IsTargetProcessOpen();
        }
        public static bool IsTargetProcessOpen()
        {
            try
            {
                string[] targetSubstrings = { "roblox", "blox", "Roblox", "Roblox Game Client", "RobloxGameClient", "robloxplayerbeta", "gameclient", "RobloxPlayerBeta", "robloxplayerbeta", "gameclient", "Roblox Player" };

                // Use LINQ with safer access to process names
                return Process.GetProcesses()
                    .Where(p => !string.IsNullOrEmpty(p.ProcessName)) // Avoid processes without a name
                    .Any(p => targetSubstrings.Any(substring => p.ProcessName.IndexOf(substring, StringComparison.OrdinalIgnoreCase) >= 0));
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
