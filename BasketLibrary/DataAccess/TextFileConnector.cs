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
        private const string TeamFile = "TeamModels.csv";
        private const string TournamentFile = "TournamentModels.csv";
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

        public TeamModel CreateTeam(TeamModel model)
        {
            // Load the text file and convert the text to List<TeamModel>
            List<TeamModel> teams = TeamFile.FullFilePath().LoadFile().ConvertToTeamModel(PersonFile);

            // Find the max Id
            int currentId = 1;

            if (teams.Count > 0) // in case that text file does not exist
                currentId = teams.OrderByDescending(x => x.Id).First().Id + 1;

            model.Id = currentId;

            // Add the new record with the new Id (max + 1)
            teams.Add(model);

            // Convert the prizes to List<string>
            // Save the List<string> to the text file
            teams.SaveToTeamFile(TeamFile);

            return model;
        }

        public void CreateTournament(TournamentModel model)
        {
            // Load the text file and convert the text to List<TeamModel>
            List<TournamentModel> tournaments = TournamentFile.FullFilePath()
                                                              .LoadFile()
                                                              .ConvertToTournamentModel(PersonFile, TeamFile, PrizeFile);

            // Find the max Id
            int currentId = 1;

            if (tournaments.Count > 0) // in case that text file does not exist
                currentId = tournaments.OrderByDescending(x => x.Id).First().Id + 1;

            model.Id = currentId;

            // Add the new record with the new Id (max + 1)
            tournaments.Add(model);

            // Convert the prizes to List<string>
            // Save the List<string> to the text file
            tournaments.SaveToTournamentFile(TournamentFile);
        }

        public List<PersonModel> GetPerson_All()
        {
            return PersonFile.FullFilePath().LoadFile().ConvertToPersonModel();
        }

        public List<TeamModel> GetTeam_All()
        {
            return TeamFile.FullFilePath().LoadFile().ConvertToTeamModel(PersonFile);
        }
    }
}
