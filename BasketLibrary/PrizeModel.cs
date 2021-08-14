using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// The Unique identificator for the prize
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Place number (for examle 1, 2, 3, 4, etc.)
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Besides number, place can have a name
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Prize for exact amount of money (20$, 50$, etc.)
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Reward that depends on the percentage of money paid through entryfee
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }

        public PrizeModel(string PlaceName, string PlaceNumber, string PrizeAmount, string PrizePercentage)
        {

            this.PlaceName = PlaceName;

            int PlaceNumberValue = 0;
            int.TryParse(PlaceNumber,out PlaceNumberValue);
            this.PlaceNumber = PlaceNumberValue;

            decimal PrizeAmountValue = 0;
            decimal.TryParse(PrizeAmount, out PrizeAmountValue);
            this.PrizeAmount = PrizeAmountValue;

            double PrizePercentageValue = 0;
            double.TryParse(PrizePercentage, out PrizePercentageValue);
            this.PrizePercentage = PrizePercentageValue;
        }
    }
}
