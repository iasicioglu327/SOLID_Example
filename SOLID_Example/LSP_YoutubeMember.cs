using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Example
{
    internal class LSP_YoutubeMember
    : ILSP_YoutubeUser
    {
        public string Email { get; set; }
        public int Username { get; set; }
        public int Subscribers { get; set; }

        public void WatchVideo()
        {
            Console.WriteLine("User watched the video");
        }

        public void Comment()
        {
            Console.WriteLine("User commented");
        }

        public void Subscribe()
        {
            Console.WriteLine("User subscribed the channel");
        }

        public void Unsubscribe()
        {
            Console.WriteLine("User unsubscribed the channel");
        }

        public void LogIn()
        {
            Console.WriteLine("User logged in");
        }

        public void LogOut()
        {
            Console.WriteLine("User logged out");
        }
    }
}

