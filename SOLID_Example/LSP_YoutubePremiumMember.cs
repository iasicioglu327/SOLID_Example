using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Example
{
    internal class LSP_YoutubePremiumMember
    : ILSP_YoutubeUser
    {
        public void Comment()
        {
            Console.WriteLine("User commented");
        }

        public void LogIn()
        {
            Console.WriteLine("User logged in");
        }

        public void LogOut()
        {
            Console.WriteLine("User logged out");
        }

        public void Subscribe()
        {
            Console.WriteLine("User subscribed the channel");
        }

        public void Unsubscribe()
        {
            Console.WriteLine("User unsubscribed the channel");
        }

        public void WatchVideo()
        {
            Console.WriteLine("User watched the video");
        }

        public void SkipAds()
        {
            Console.WriteLine("User skipped the ads");
        }

        public void LockScreen()
        {
            Console.WriteLine("User locked the screen and used the app");
        }
    }
}
