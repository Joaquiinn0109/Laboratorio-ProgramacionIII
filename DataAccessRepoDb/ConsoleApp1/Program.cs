using DataAccessRepoDb.Entities;
using Microsoft.Data.SqlClient;
using RepoDb;

GlobalConfiguration
    .Setup()
    .UseSqlServer();

string _connectionString =
            "Persist Security Info=True;Initial Catalog=Demo;Data Source=.; Integrated Security=True;TrustServerCertificate=True;";

//Movies
IEnumerable<Movie> movies;

//ORM
using (var connection = new SqlConnection(_connectionString))
{
    movies = connection.QueryAll<Movie>();
}

var count = movies.Count();

Console.WriteLine($"Total de peliculas: {count}");

//Query
IEnumerable<Movie> moviesSearch;

using (var connection = new SqlConnection(_connectionString))
{
    moviesSearch = connection.Query<Movie>(m => m.Name.Contains("Pelicula 1"));
}
var countSearch = moviesSearch.Count();

Console.WriteLine($"Peliculas que contiene \"Pelicula 1\" son: {countSearch}");

int count2;
using (var connection = new SqlConnection(_connectionString))
{
    var sql = "SELECT COUNT(*) FROM [dbo].[Movie]";
    count2 = connection.ExecuteScalar<int>(sql);
}
Console.WriteLine($"Total de Peliculas 2: {count2}");

Console.ReadKey();