using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System;

namespace W10Examples.ToSolve
{
    public class LaunchNavigator
    {
        /// <summary>
        /// Issues
        /// 1.- How to set PreferredApplicationDisplayName to Firefox for instance
        /// 2.- Requires both PreferredApplicationDisplayName &  PreferredApplicationPackageFamilyName
        /// 3.- Open Files
        /// 4.- Open Explorer Folders
        /// </summary>
        /// <param name="uri"></param>
        public async void TestLauncher(string uri)
        {
            var options = new LauncherOptions();
            options.DisplayApplicationPicker = false;
            options.PreferredApplicationDisplayName = "Mozilla Firefox";
            var success = await Launcher.LaunchUriAsync(new Uri(uri, UriKind.Absolute), options);
        }
    }
}
