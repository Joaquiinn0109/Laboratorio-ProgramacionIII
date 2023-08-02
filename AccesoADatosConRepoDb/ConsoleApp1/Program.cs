// See https://aka.ms/new-console-template for more information
using AccesoADatosConRepoDb.Business;

Console.WriteLine("Acceso a datos con RepoDb!\n");
Console.WriteLine(" Seleccione una opcion: \n");
Console.WriteLine(" 1 - Agregar Peliculas\n");
Console.WriteLine(" 2 - Editar Peliculas\n");
Console.WriteLine(" 3 - Buscar Peliculas\n");
Console.WriteLine(" 4 - Mostrar lista de peliculas\n");
Console.WriteLine(" 5 - Eliminar peliculas");

var opcion = Convert.ToInt32(Console.ReadLine());

var movies = new RepoDbBusiness();

if (opcion == 1 || opcion == 2 || opcion == 3 || opcion == 4 || opcion == 5)
{
    switch (opcion)
    {
        case 1:
            Console.WriteLine($"\n Usted seleccionó la opcion de Agregar peliculas.\n Por favor ingrese la cantidad de peliculas que desea agregar.");
            var num = Convert.ToInt32(Console.ReadLine());
            movies.Agregar(num);
            break;
        case 2:
            Console.WriteLine("\n Usted seleccionó la opcion de Editar las peliculas.\n");
            movies.Editar();
            break;
        case 3:
            Console.WriteLine("\n Usted selecionó la opcion de Buscar entre las peliculas.\n Por favor ingrese el nombre de la pelicula: ");
            var texto = Console.ReadLine();
            if(texto != null)
            {
                movies.Busqueda(texto);
            }
            break;
        case 4:
            Console.WriteLine("\n Usted seleccionó la opcion de Mostrar la lista de peliculas.\n");
            movies.TraerTodasLasPeliculas();
            break;
        case 5:
            Console.WriteLine("\n Usted selecionó la opcion de Eliminar las peliculas.");
            Console.WriteLine("\n ----- ADVERTENCIA -----\n Las peliculas se eliminaran de forma permanente.\n Esta seguro que desea eliminarlas?\n");
            Console.WriteLine("Si es asi precione 1.\n");
            var elecion = Convert.ToInt32(Console.ReadLine());
            if(elecion == 1)
            {
                movies.Eliminar();
            }
            break;
    }
    if (opcion == 1 || opcion == 2)
    {
        Console.WriteLine("\n ¿Desea ver la lista actulizada?\n");
        Console.WriteLine(" 1 - SI\n");
        Console.WriteLine(" 2 - NO");
        var num = Convert.ToInt32(Console.ReadLine());

        if (num == 1)
        {
            movies.TraerTodasLasPeliculas();
        }
        else Console.WriteLine("----- MUCHAS GRACIAS -----");
    }
    else Console.WriteLine("----- MUCHAS GRACIAS -----");
}
else Console.WriteLine(" ------- ERROR -------\n Usted selecciono una opcion incorrecta.");

Console.ReadKey();
