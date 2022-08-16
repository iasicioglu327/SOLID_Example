using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedExample
{
    internal class Interface_UserClass : Interface_VoteMovieInterface, Interface_AddWatchlistInterface
    {
        public void AddWatchList()
        {
            Console.WriteLine("User added the movie to watch");
        }

        public void VoteMovie()
        {
            Console.WriteLine("User voted the movie");
        }
    }
}
