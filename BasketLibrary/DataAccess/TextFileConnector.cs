using BasketLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasketLibrary.DataAccess.TextHelpers;

namespace BasketLibrary.DataAccess
{
    public class TextFileConnector : IDataConnection
    {
        private const string PrizeFile = "PrizeModels.csv";
        private const string PersonFile = "PersonModels.csv";

        public PersonModel CreatePerson(PersonModel model)
        {
            // Load the text file and convert the text to List<PersonModel>
            List<PersonModel> people = PersonFile.FullFilePath().LoadFile().ConvertToPersonModel();

            // Find the max Id
            int currentId = 1;

            if (people.Count > 0) // in case that text file does not exist
                currentId = people.OrderByDescending(x => x.Id).First().Id + 1;

            model.Id = currentId;

            // Add the new record with the new Id (max + 1)
            people.Add(model);

            // Convert the prizes to List<string>
            // Save the List<string> to the text file
            people.SaveToPersonFile(PersonFile);

            return model;
        }

        public PrizeModel CreatePrize(PrizeModel model)
        {
            // Load the text file and convert the text to List<PrizeModel>
            List<PrizeModel> prizes = PrizeFile.FullFilePath().LoadFile().ConvertToPrizeModel();

            // Find the max Id
            int currentId = 1;

            if(prizes.Count > 0) // in case that text file does not exist
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;

            model.Id = currentId;

            // Add the new record with the new Id (max + 1)
            prizes.Add(model);

            // Convert the prizes to List<string>
            // Save the List<string> to the text file
            prizes.SaveToPrizeFile(PrizeFile);

            return model;
        }
    }
}
