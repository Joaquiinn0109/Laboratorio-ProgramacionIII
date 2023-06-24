using ConsoleApp1;
using System.Collections.Generic;

namespace TestProject2
{
    public class UnitTest1
    {
        [Fact]
        public void ListaAdd()
        {
            var alumnos = new List<Alumno>();

            alumnos.Add(new Alumno("Renata"));

            var juan = new Alumno();
            juan.Nombre = "Juan";

            var maria = new Alumno() { Nombre = "Maria" };

            alumnos.Add(juan);
            alumnos.Add(maria);

            Assert.NotNull(alumnos);
            Assert.Equal(3,alumnos.Count);
            Assert.Equal("Renata", alumnos.First().Nombre);
            Assert.Equal("Juan", alumnos[1].Nombre);
            Assert.Equal("Maria", alumnos.Last().Nombre);

        }
        [Fact]
        public void ListaAdd1000() 
        {
            var alumnos = new List<Alumno>();

            for (int i = 0; i < 1000; i++)
            {
                alumnos.Add(new Alumno($"Alumno {i}"));
            }

            Assert.NotNull(alumnos);
            Assert.Equal(1000, alumnos.Count);
        }
        [Theory]
        [InlineData(1000, "Lento")]
        [InlineData(10000, "Tranqui")]
        [InlineData(100000, "Super")]

        public void ListaAdd2( int cantidad, string nombreAlumno)
        {
            var alumnos = new List<Alumno>();

            for (int i = 0; i < cantidad; i++)
            {
                alumnos.Add(new Alumno($"{nombreAlumno} {i}"));
            }

            Assert.NotNull(alumnos);
            Assert.Equal(cantidad, alumnos.Count);
        }
        [Fact]
        public void ObtenerAlumnosConEdadPar()
        {
            var alumnos = new List<Alumno>();

            for (int i = 0; i < 1000; i++)
            {
                alumnos.Add(new Alumno($"Alumno {i}")
                {
                    Edad = i
                });
            }

            var alumnosConEdadPar = from a in alumnos
                                    where a.Edad % 2 == 0
                                    select a;

            var alumnosConEdadPar2 = alumnos.
                                            Where(x => x.Edad % 2 == 0)
                                            .Select(x => x);

            Assert.NotNull(alumnos);
            Assert.Equal(1000, alumnos.Count);
            Assert.Equal(500, alumnosConEdadPar.Count());
            Assert.True(alumnosConEdadPar.Any());
        }
    }
}