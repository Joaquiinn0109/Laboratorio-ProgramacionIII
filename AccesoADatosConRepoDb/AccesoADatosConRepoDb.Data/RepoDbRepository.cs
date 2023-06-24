using AccesoADatosConRepoDb.Entities;
using Microsoft.Data.SqlClient;
using RepoDb;

GlobalConfiguration
    .Setup()
    .UseSqlServer();
namespace AccesoADatosConRepoDb.Data
{
    public class RepoDbRepository
    {
        string _connectionString = "Persist Security Info=True;Initial Catalog=Demo;Data Source=.; Integrated Security=True;TrustServerCertificate=True;";

        public IEnumerable<Movie> GetAll()
        {
            IEnumerable<Movie> result = new List<Movie>();

            using (var connection = new SqlConnection(_connectionString))
            {
                result = connection.QueryAll<Movie>();
            }
            return result;
        }
    }
}