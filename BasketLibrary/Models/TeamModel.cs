using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketLibrary.Models
{
    public class TeamModel
    {
        /// <summary>
        /// Name for a team
        /// </summary>
        public string TeamName { get; set; }

        /// <summary>
        /// Members that play in this team
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; }
    }
}
