// See https://aka.ms/new-console-template for more information
using Movies.Business;

Console.WriteLine("App N-Layer");

Console.WriteLine("Movies List \n");

var movieBusiness = new MovieBusiness();

var movies = movieBusiness.GetAll();

Console.WriteLine(" Busqueda de Peliculas: \n");

Console.WriteLine(" Ingrese un número,letra o palabra para buscar en la lista de peliculas: ");

var texto = Console.ReadLine();

if (texto != null)
{
    var moviesSearch = movieBusiness.Search(texto);

    Console.WriteLine($"---- Hay {moviesSearch.Count()} peliculas que contienen \"{texto}\" en su titulo. ----\n");

    Console.WriteLine(" Coincidencias: \n");

    foreach (var m in moviesSearch)
    {
        Console.WriteLine($" {m.Name}\n -----------");
    }
}

Console.WriteLine(" Lista completa de Peliculas: \n");

foreach (var m in movies)
{
    Console.WriteLine($" Nombre:{m.Name}\n Identificador: {m.MovieId}\n ImageURL: {m.ImageUrl}\n ----------------");
}

Console.ReadKey();


