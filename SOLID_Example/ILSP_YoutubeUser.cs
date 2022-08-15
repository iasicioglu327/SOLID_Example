using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Example
{
    internal interface ILSP_YoutubeUser
    {
        public void WatchVideo();
        public void Comment();
        public void Subscribe();
        public void Unsubscribe();
        public void LogIn();
        public void LogOut();
    }
}
