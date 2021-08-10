using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketLibrary
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents a team that play in a matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Score of the team that played a matchup
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Matchup that this team came as a winner
        /// </summary>
        public MatchupModel PreviousMatchup { get; set; }

    }
}
