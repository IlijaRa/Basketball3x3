using BasketLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnections(DatabaseType dbType)
        {
            if (dbType == DatabaseType.MSSQL)
            {
                // TODO: Set up the MicrosoftSQL connection
                MicrosoftSQLConnector mssql = new MicrosoftSQLConnector();
                Connection = mssql;
            }

            else if (dbType == DatabaseType.JsonFile)
            {
                // TODO: Set up the json file connection
                JsonFileConnerctor json = new JsonFileConnerctor();
                Connection = json;
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
