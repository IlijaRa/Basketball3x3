using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get ; private set; }

        public static void InitializeConnections(bool MicrosoftSQLDB, bool jsonFile)
        {
            if (MicrosoftSQLDB)
            {
                // TODO: Create the MicrosoftSQL connection
            }

            if (jsonFile)
            {
                // TODO: Create the json file connection
            }
        }
    }
}
