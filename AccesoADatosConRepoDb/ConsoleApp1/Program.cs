// See https://aka.ms/new-console-template for more information
using AccesoADatosConRepoDb.Business;

Console.WriteLine("Acceso a datos con RepoDb!");
Console.WriteLine("Lista de peliculas: \n");

var dataAccessRepoDbBusiness = new RepoDbBusiness();

var movies = dataAccessRepoDbBusiness.GetAll();

foreach (var m in movies)
{
    Console.WriteLine($" Titulo: {m.Name}\n Identificador: {m.MovieId}\n Imagen: {m.ImageUrl}\n ----------------");
}
Console.ReadKey();
