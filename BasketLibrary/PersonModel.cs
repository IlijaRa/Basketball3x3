using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketLibrary
{
    public class PersonModel
    {
        /// <summary>
        /// Persons first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Persons last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Persons contact email
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Persons contact number
        /// </summary>
        public string CellphoneNumber { get; set; }
    }
}
