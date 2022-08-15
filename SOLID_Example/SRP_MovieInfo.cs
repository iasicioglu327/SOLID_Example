using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Example
{
    internal class SRP_MovieInfo
    {
        public int ID { get; set; }
        public string MovieTitle { get; set; }
        public string MovieGenre { get; set; }
        public SRP_AddWatchlist Watchlist { get; set; }
        public SRP_MovieVoting MovieVoting { get; set; }

        public void GetMovieInfos()
        {
            Console.WriteLine("Movie info: {0},{1},{2},{3},{4}", ID, MovieTitle, MovieGenre, Watchlist, MovieVoting);

        }
    }
}
