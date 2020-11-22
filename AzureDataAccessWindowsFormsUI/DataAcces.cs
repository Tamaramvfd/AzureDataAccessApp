using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureDataAccessWindowsFormsUI
{
    public static class DataAcces
    {
        public static List<GameModel> GetGames()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["PersonGamesDB"].ConnectionString;
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                List<GameModel> games = new List<GameModel>();

                string sql = "SELECT Id, NameOfGame, Description FROM dbo.Games";
                games = connection.Query<GameModel>(sql).ToList();
                return games;
            }
        }
    }
}
