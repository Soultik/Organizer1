using OrganizerLibrary.DataConnection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace OrganizerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; }
            = new List<IDataConnection>();

        public static void InitializeConnections (bool MySQL, bool PostgreSQL)
        {
            if (MySQL)
            {

                MySqlConnector mysql = new MySqlConnector();
                Connections.Add(mysql);
            }   
            if (PostgreSQL)
            {
                // TODO - Create the PostgreSQL connection
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
