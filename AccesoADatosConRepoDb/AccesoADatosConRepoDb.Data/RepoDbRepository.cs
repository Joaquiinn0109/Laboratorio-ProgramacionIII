using AccesoADatosConRepoDb.Entities;
using Microsoft.Data.SqlClient;
using RepoDb;
using System;

namespace AccesoADatosConRepoDb.Data
{
    public class RepoDbRepository
    {
        //Para hacerlo por capas tenemos que poner la configuracion global en el constructor.
        public RepoDbRepository() 
        {
            GlobalConfiguration
                .Setup()
                .UseSqlServer();
        }
        string _connectionString = "Persist Security Info=True;Initial Catalog=Demo;Data Source=.; Integrated Security=True;TrustServerCertificate=True;";

        public List<Movie> TrearTodasLasPeliculas()
        {
             var movies = new List<Movie>();

            using (var connection = new SqlConnection(_connectionString))
            {
                movies = (List<Movie>)connection.QueryAll<Movie>();
            }
            foreach (var m in movies)
            {
                Console.WriteLine($" Titulo: {m.Name}\n Identificador: {m.MovieId}\n Imagen: {m.ImageUrl}\n ----------------");
            }
            return movies;
        }
        public void AgregarPeliculas(int numPeli)
        {
            var movies = new List<Movie>();

            for (int i = 1; i <= numPeli; i++)
            {
                var movie = new Movie();
                movie.Name = $"Pelicula nueva N° {i}";
                movie.ImageUrl = null;

                movies.Add(movie);
            }
            using (var connection = new SqlConnection(_connectionString))
            {
                var agregar = connection.InsertAll<Movie>(movies);
            }
            Console.WriteLine(" ---- Las peliculas ya fueron cargadas ----");
        }
        public void EditarPeliculas()
        {
            IEnumerable<Movie> movieUpdate;
            using (var connection = new SqlConnection(_connectionString))
            {
                movieUpdate = connection.Query<Movie>(m => m.Name.EndsWith("666"));

                foreach (var movie in movieUpdate)
                {
                    movie.Name = $"{movie.Name} (X)";
                }
                connection.UpdateAll<Movie>(movieUpdate);
            }
            Console.WriteLine("\n Todas las peliculas que tienen el titulo terminado en \"666\" se le agrego: (x).");
        }
        public List<Movie> Busqueda(string textToSearch)
        {
            var movies = new List<Movie>();

            using (var connection = new SqlConnection(_connectionString))
            {
                movies = (List<Movie>)connection.Query<Movie>(m => m.Name.Contains(textToSearch));
            }
            var countSearch = movies.Count();

            Console.WriteLine($"\n En total se encontraron {countSearch} Peliculas que contienen \"{textToSearch}\"  las cuales son:\n");
            foreach (var m in movies)
            {
                Console.WriteLine($" Titulo: {m.Name}\n Identificador: {m.MovieId}\n Imagen: {m.ImageUrl}\n ----------------");
            }
            return movies;
        }
        public void Eliminar()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var borrar = connection.DeleteAll<Movie>();
            }
            Console.WriteLine("\n Todas las peliculas fueron eliminadas con EXITO.\n");
        }
    }
}