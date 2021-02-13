

using System;
using System.Configuration;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;

namespace HomeWork7.DbContext
{
    public class Connection
    {
        public string GetUserConnectionString()
        {
            var connectionBuilder = new SqlConnectionStringBuilder
            {
                DataSource =
                    $"{ConfigurationManager.AppSettings["Server"]}\\{ConfigurationManager.AppSettings["SqlInstance"]}",
                InitialCatalog = ConfigurationManager.AppSettings["Database"],
                UserID = ConfigurationManager.AppSettings["User"],
                Password = ConfigurationManager.AppSettings["Password"],
                MultipleActiveResultSets = true,
                IntegratedSecurity = Convert.ToBoolean(ConfigurationManager.AppSettings["IntegratedSecurity"]),
                Pooling = true,
                ApplicationName = ConfigurationManager.AppSettings["ApplicationName"]
            };
            return connectionBuilder.ConnectionString;

        }
    }
}
