using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketLibrary.Models
{
    public class MatchupModel
    {
        /// <summary>
        /// Teams that play against each other
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; }

        /// <summary>
        /// Team that won the match
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Round of this matchup
        /// </summary>
        public int MatchupRound { get; set; }

    }
}
