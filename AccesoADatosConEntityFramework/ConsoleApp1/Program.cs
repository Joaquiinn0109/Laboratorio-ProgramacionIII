// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using DataAccess.Entities;

Console.WriteLine("Acceso a Datos con Entity Frameework!");


//Contador
var moviesCount = 0;

using (var context = new MoviesContext())
{
    moviesCount = context.Movies.Count();
}

Console.WriteLine($"Movies count: {moviesCount}");

//QUERY
//using (var context = new MoviesContext())
//{
//    var query = from m in context.Movies
//                where m.Name.Contains("Starwars")
//                select new { NameMovie = m.Name};
//    foreach (var item in query.ToList())
//    {
//        Console.WriteLine($"Movies: {item.NameMovie}");
//    }
//}

//var movieStarWars2 = new Movie()
//{
//    Name = "StarWars 2",
//    ImageUrl = null
//};

//using (var context = new MoviesContext())
//{
//    context.Add(movieStarWars2);

//    context.SaveChanges();
//}

//Console.WriteLine("Fin...");

//Cargar 10000
//Editar Los titulos que terminen en "666" 

// CARGA DE 10000

using (var context = new MoviesContext())
{
    
    for (int i = 1; i <= 10000; i++)
    {
        var movie = new Movie()
        {
        Name = $"Pelicula {i}",
        ImageUrl = i.ToString(),
        };
        context.Add(movie);
    }
    context.SaveChanges();
}

//EDICION DE TITULOS

using (var context = new MoviesContext())
{
    var query = from movie in context.Movies
                where movie.Name.EndsWith("666")
                select new { movieName = $"{movie.Name} (X)" };
    foreach (var m in query.ToList())
    {
        Console.WriteLine($"Movies: {m.movieName}");
    }
}



