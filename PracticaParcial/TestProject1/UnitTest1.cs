using Practica;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void DebeFormatearUnaFecha()
        {
            var fechaHoy =  new DateTime(2023,4,12,22,10,0);

            //"Lunes 8 de Mayo de 2023 a las 'hora actual'"

            var fechaString = fechaHoy.ToString("dddd dd 'de' MMMM 'de' yyyy 'a' 'las:' HH:mm");

            Assert.Equal("miércoles 12 de abril de 2023 a las: 22:10", fechaString);

        }
        [Fact]
        public void DebeDarNombreAlArchivoYDirectorioYCrearlo()
        {

            var fechaHoy = DateTime.Now.ToString("D");

            var a = new Class1();

            a.Fecha = fechaHoy;

            a.NombreDeArchivo = fechaHoy;

            var d = Directory.CreateDirectory($"C:/Users/CellComp/Desktop/{fechaHoy}");
            d.CreateSubdirectory("OtroMas");

            var swriter = new StreamWriter($"C:/Users/CellComp/Desktop/{fechaHoy}/OtroMas/{a.NombreDeArchivo}.txt" , false);

            swriter.Write(a.Fecha);

            swriter.Close();

            Assert.True(true);

            var sreader = new StreamReader($"C:/Users/CellComp/Desktop/{fechaHoy}/OtroMas/{a.NombreDeArchivo}.txt");
            var s = sreader.ReadToEnd();

            sreader.Close();

            Assert.Equal("miércoles, 10 de mayo de 2023", s);

            //Eze
            //var d = Directory.CreateDirectory("C:/Users/CellComp/Desktop/Archivo");
            //d.CreateSubdirectory("a01");

            //Assert.True(true);
            //var fechadehoy = DateTime.Now.ToString("D");

            //var a = new Class1();
            //a.Fecha = fechadehoy;
            //a.NombreDeArchivo = fechadehoy;
            //var writer = new StreamWriter($"C:/Users/CellComp/Desktop/Archivo/a01/{a.NombreDeArchivo}.txt");

            //writer.WriteLine(a.Fecha);
            //writer.Close();
        }
        //FaltaPracticarColeccionesyLINQ
        [Fact]
        public void DebeAgregar100AlumnosALaListaYLuegoBuscarUnoYEliminarlo()
        {
            var lista = new LinkedList<Alumno>();

            //Agrego items a la lista
            for (int i = 1; i < 101; i++)
            {
                lista.AddLast(new Alumno {
                    Nombre = "Alumno " + i , Edad = 20 + i
                });
            }
            //Compruebo que la lista contenga los elementos
            Assert.NotNull(lista);
            Assert.Equal(100, lista.Count());

            //Busqueda del alumno segun su nombre para luego eliminarlo
            var alumnoBuscado = lista.SingleOrDefault(alumno => alumno.Nombre == "Alumno 50");

            if(alumnoBuscado != null)
            {
                lista.Remove(alumnoBuscado);
            }
            //Compruebo que el "Alumno 50" alla sido eliminado 
            Assert.DoesNotContain(new Alumno { Nombre = "Alumno 50" }, lista);
            Assert.Equal(99, lista.Count());
        }
        [Fact]
        public async void DebeAgregarUnAlumnoEnUnaPosicionEspecifica()
        {
            var lista = new LinkedList<Alumno>();

            //Agrego items a la lista
            for (int i = 1; i < 101; i++)
            {
                lista.AddLast(new Alumno
                {
                    Nombre = "Alumno " + i,
                    Edad = 20 + i
                });
            }

            //Compruebo que la lista contenga los elementos
            Assert.NotNull(lista);
            Assert.Equal(100, lista.Count());

            //Busqueda de un alumno para luego agregar un nuevo alumno en su lugar
            var alumno = lista.SingleOrDefault(alumno => alumno.Nombre == "Alumno 30");
            
            var nodoActual = lista.Find(alumno);
            
            var alumnoNuevo = new Alumno { Nombre = "Alumno Nuevo", Edad = 67 };

            if(nodoActual != null)
            {
                lista.AddBefore(nodoActual, alumnoNuevo);
            }

            //Compruebo que el alumno se alla agregado en la posicion correcta
            Assert.Equal(101, lista.Count());
            if(nodoActual != null && nodoActual.Previous != null && nodoActual.Previous.Previous != null)
            {
                Assert.Equal(alumnoNuevo, nodoActual.Previous.Value);
                var alumno2 = lista.SingleOrDefault(alumno => alumno.Nombre == "Alumno 29");
                Assert.Equal(alumno2, nodoActual.Previous.Previous.Value);
            }
        }
        [Fact]
        public void DebeOrdenarLaLista()
        {
            var lista = new LinkedList<Alumno>();

            //Agrego items a la lista
            for (int i = 1; i < 101; i++)
            {
                lista.AddLast(new Alumno
                {
                    Nombre = "Alumno " + i,
                    Edad = 20 + i
                });
            }

            //Compruebo que la lista contenga los elementos
            Assert.NotNull(lista);
            Assert.Equal(100, lista.Count());

            //Ordeno la lista de mayor a menor
            var listaOrdenada = lista.OrderByDescending(lista => lista.Edad).ToList();

            var alumno = listaOrdenada.Last();

            var alumno2 = listaOrdenada.First();

            Assert.Equal(21, alumno.Edad);

            Assert.Equal(120, alumno2.Edad);
        }
    }
}