using BasketLibrary.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// "TextHelpers" in namespace so that only class "TextConnector" can use this extension method
namespace BasketLibrary.DataAccess.TextHelpers
{
    public static class TextFileConnectorProcessor
    {
        // this string file name - extension method.
        // Now we can call "fileName.FullFilePath()" and get the full path including "fileName" in it
        // but both class and function need to be static
        public static string FullFilePath(this string filename)
        {
            return $"{GlobalConfig.DefaultPath()}\\{filename}";
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        public static List<PrizeModel> ConvertToPrizeModel(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();

            foreach(var line in lines)
            {
                string[] cols = line.Split(',');
                PrizeModel p = new PrizeModel();

                p.Id = int.Parse(cols[0]);
                p.PlaceNumber = int.Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PrizePercentage = double.Parse(cols[4]);
                output.Add(p);
            }

            return output;
        }

        public static List<PersonModel> ConvertToPersonModel(this List<string> lines)
        {
            List<PersonModel> output = new List<PersonModel>();

            foreach (var line in lines)
            {
                string[] cols = line.Split(',');
                PersonModel p = new PersonModel();

                p.Id = int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.EmailAddress = cols[3];
                p.CellphoneNumber = cols[4];
                output.Add(p);
            }

            return output;
        }

        public static List<TeamModel> ConvertToTeamModel(this List<string> lines, string personFileName)
        {
            // TODO: DOESN'T WORKK!!
            // id, team name, list of members separated by the pipe
            List<TeamModel> output = new List<TeamModel>();
            //List<PersonModel> people = personFileName.FullFilePath().LoadFile().ConvertToPersonModel();

            //foreach(var line in lines)
            //{
            //    string[] cols = line.Split(',');
            //    TeamModel t = new TeamModel();
            //    t.Id = int.Parse(cols[0]);
            //    t.TeamName = cols[1];

            //    string[] personIds = cols[2].Split('|');

            //    foreach (string id in personIds)
            //    {
            //        int person_id = int.Parse(id);
            //        foreach (PersonModel p in people)
            //        {
            //            if(p.Id == person_id)
            //                t.TeamMembers.Add(p);
            //        }
            //    }
            //    output.Add(t);
            //}

            return output;
        }

        public static void SaveToPrizeFile(this List<PrizeModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach(PrizeModel p in models)
            {
                lines.Add($"{p.Id},{p.PlaceNumber},{p.PlaceName},{p.PrizeAmount},{p.PrizePercentage}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveToPersonFile(this List<PersonModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PersonModel p in models)
            {
                lines.Add($"{p.Id},{p.FirstName},{p.LastName},{p.EmailAddress},{p.CellphoneNumber}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveToTeamFile(this List<TeamModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (TeamModel t in models)
            {
                lines.Add($"{t.Id},{t.TeamName},{ConvertPeopleListToString(t.TeamMembers)}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        private static string ConvertPeopleListToString(List<PersonModel> people)
        {
            string output = "";

            if (people.Count == 0)
            {
                return "";
            }

            foreach(PersonModel p in people)
            {
                output += $"{p.Id}|";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }
    }
}
