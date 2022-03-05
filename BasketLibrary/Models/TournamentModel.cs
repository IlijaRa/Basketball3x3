using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketLibrary.Models
{
    public class TournamentModel
    {

        /// <summary>
        /// The Unique identificator for the tournament
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the tournament
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Amount of money that every team need to pay in order to play the tournament
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// List of teams that play the tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; }

        /// <summary>
        /// Rewards that this tournament has to offer
        /// </summary>
        public List<PrizeModel> Prizes { get; set; }

        /// <summary>
        /// Number of rounds that the tournament has
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; }

    }
}
