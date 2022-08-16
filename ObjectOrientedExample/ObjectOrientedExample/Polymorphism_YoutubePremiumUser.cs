using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedExample
{
    internal class Polymorphism_YoutubePremiumUser:Polymorphism_YoutubeUser
    {
        public override void WatchVideo()
        {
            Console.WriteLine("Youtube premium user watched the video without ads");
        }
    }
}
