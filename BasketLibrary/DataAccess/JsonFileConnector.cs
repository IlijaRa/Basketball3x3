using BasketLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketLibrary.DataAccess
{
    public class JsonFileConnector : IDataConnection
    {
        public PersonModel CreatePerson(PersonModel model)
        {
            throw new NotImplementedException();
        }

        //TODO: Wire up the CreatePrize for the textFile
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
