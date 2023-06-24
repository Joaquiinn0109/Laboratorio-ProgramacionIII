using Movies.Entities;
using System.Data.SqlClient;
using System.Net.WebSockets;

namespace Movies.Data
{
    public class MovieRepository
    {
        string _connectionString =
            "Persist Security Info=True;Initial Catalog=Demo;Data Source=.; Integrated Security=True;TrustServerCertificate=True;";

        public List<Movie> GetAll()
        {

            string querySql = "SELECT MovieId, Name, ImageUrl FROM dbo.Movie";

            var movies = new List<Movie>();

            using (var connection =
            new SqlConnection(_connectionString))
            {

                var command = new SqlCommand(querySql, connection);

                try
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Movie movie = new Movie();

                        movie.MovieId = Convert.ToInt32(reader[0].ToString());
                        movie.Name = reader[1].ToString();
                        movie.ImageUrl = reader[2].ToString();

                        movies.Add(movie);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[ERROR] {ex.Message}");
                }
            }
            return movies;
        }
        public List<Movie> Search(string textToSearch)
        {
            string querySql = $"SELECT MovieId,Name,ImageURL FROM dbo.Movie WHERE Name LIKE '%{textToSearch}%'";

            var movies2 = new List<Movie>();

            using (var connection =
                new SqlConnection(_connectionString))
            {
                var command = new SqlCommand(querySql, connection);

                try
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Movie movie = new Movie();

                        movie.MovieId = Convert.ToInt32(reader[0].ToString());
                        movie.Name = reader[1].ToString();
                        movie.ImageUrl = reader[2].ToString();

                        movies2.Add(movie);

                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[ERROR]{ex.Message}");
                }

            }
            return movies2;
        }
    }
}