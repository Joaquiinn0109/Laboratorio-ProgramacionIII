using Colecciones;
using System.Net.NetworkInformation;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void DebeAgregarAlumnosALaLista()
        {
            var ListaAlumnos = new LinkedList<Alumno>();

            var p1 = new Alumno("Juan", 25);
            var p2 = new Alumno("Pedro", 20);
            var p3 = new Alumno("Juana", 18);

            ListaAlumnos.AddLast(p1);
            ListaAlumnos.AddLast(p2);
            ListaAlumnos.AddLast(p3);

            Assert.Equal(3, ListaAlumnos.Count);
            Assert.Equal(p1, ListaAlumnos.First.Value);
            Assert.Equal(p3, ListaAlumnos.Last.Value);
        }
        [Fact]
        public void DebeAgregarUnAlumnoDespuesDeUnNodoEspecifico()
        {
            var ListaAlumnos = new LinkedList<Alumno>();

            var p1 = new Alumno("Juan", 25);
            var p2 = new Alumno("Pedro", 20);
            var p3 = new Alumno("Juana", 18);

            ListaAlumnos.AddLast(p1);
            ListaAlumnos.AddLast(p2);
            ListaAlumnos.AddLast(p3);

            var node = ListaAlumnos.Find(p2);
            var nuevoAlumno = new Alumno("Lucia", 21);
            ListaAlumnos.AddBefore(node, nuevoAlumno);

            Assert.Equal(4, ListaAlumnos.Count);
            Assert.Equal(nuevoAlumno, node.Previous.Value);
            Assert.Equal(p1, node.Previous.Previous.Value);

            ListaAlumnos.RemoveLast();

            Assert.Equal(3, ListaAlumnos.Count);

            ListaAlumnos.Clear();

            Assert.Equal(0, ListaAlumnos.Count);
        }
        [Fact]
        public void DebeDeterminarSiUnAlumnoSeEncuentraONo()
        {
            var ListaAlumnos = new LinkedList<Alumno>();

            ListaAlumnos.AddFirst(new Alumno("Juana", 18));
            ListaAlumnos.AddFirst(new Alumno("Pedro",22));
            ListaAlumnos.AddFirst(new Alumno("Lucia",20));

            var p4 = new Alumno("Jose", 24);

            if (ListaAlumnos.Contains(p4) == true)
            {
                Assert.False(ListaAlumnos.Contains(p4));
            }
            else
            {
                ListaAlumnos.AddLast(p4);

                Assert.True(ListaAlumnos.Contains(p4));
            }

        }

    }
}