using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Example
{
    internal class SRP_AddWatchlist
    {
        public bool Watchlist { get; set; }
        public bool AddtoWatchlist(SRP_AddWatchlist movie)
        {
            if (movie.Watchlist == true)
            {
                movie.Watchlist = false;
            }
            else
            {
                movie.Watchlist = true;
            }
            return movie.Watchlist;
        }
    }
}
