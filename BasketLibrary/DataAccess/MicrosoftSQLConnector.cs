﻿using BasketLibrary.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketLibrary.DataAccess
{
    public class MicrosoftSQLConnector : IDataConnection
    {
        private const string dbName = "Basketball3x3";

        public PersonModel CreatePerson(PersonModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(dbName)))
            {
                var p = new DynamicParameters();
                p.Add("@FirstName", model.FirstName);
                p.Add("@LastName", model.LastName);
                p.Add("@EmailAddress", model.EmailAddress);
                p.Add("@CellphoneNumber", model.CellphoneNumber);
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPerson_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@Id");

                return model;
            }
        }

        /// <summary>
        /// Saves a new prize to the MicrosoftSQLDB.
        /// </summary>
        /// <param name="model">The prize information.</param>
        /// <returns>The prize information, including the unique identifier.</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(dbName)))
            {
                var p = new DynamicParameters();
                p.Add("@PlaceNumber", model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.PrizeAmount);
                p.Add("@PrizePercentage", model.PrizePercentage);
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPrize_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@Id");

                return model;
            }
        }

        public List<PersonModel> GetPerson_All()
        {
            List<PersonModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(dbName)))
            {
                output = connection.Query<PersonModel>("dbo.spPerson_GetAll").ToList();
            }

            return output;
        }
    }
}
