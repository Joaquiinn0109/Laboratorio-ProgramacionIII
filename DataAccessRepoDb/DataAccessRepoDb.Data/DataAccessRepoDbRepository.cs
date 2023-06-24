using DataAccessRepoDb.Entities;
using Microsoft.Data.SqlClient;
using RepoDb;

GlobalConfiguration
    .Setup()
    .UseSqlServer();

namespace DataAccessRepoDb.Data
{
    public class DataAccessRepoDbRepository
    {
        string _connectionString = "Persist Security Info=True;Initial Catalog=Demo;Data Source=.; Integrated Security=True;TrustServerCertificate=True;";

        public IEnumerable<Movie> GetAll()
        {
            IEnumerable<Movie> movies;

            using (var connection = new SqlConnection(_connectionString))
            {
                movies = connection.QueryAll<Movie>();
            }
            var moviescopy = movies.ToList();
            return moviescopy;
        }
    }
}