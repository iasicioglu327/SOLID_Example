using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Example
{
    internal class SRP_MovieVoting
    {
        public int MovieVoting { get; set; }
        public int Vote(int newVote)
        {
            MovieVoting = newVote;
            return MovieVoting;
        }
    }
}
