using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// The Unique identificator for the person
        /// </summary>
        public int Id { get; set; }

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

        public string FullName
        {
            get 
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
