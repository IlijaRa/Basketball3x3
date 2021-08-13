using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnections(bool MicrosoftSQLDB, bool jsonFile)
        {
            if (MicrosoftSQLDB)
            {
                // TODO: Set up the MicrosoftSQL connection
                MicrosoftSQLConnector mssql = new MicrosoftSQLConnector();
                Connections.Add(mssql);
            }

            if (jsonFile)
            {
                // TODO: Set up the json file connection
                JsonFileConnerctor json = new JsonFileConnerctor();
                Connections.Add(json);
            }
        }
    }
}
