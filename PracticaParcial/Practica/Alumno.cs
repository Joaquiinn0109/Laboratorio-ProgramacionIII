
namespace Practica
{
    public class Alumno
    {
        public string Nombre { get; set; }
        public int Edad { get; set;}
        public Alumno(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }
        public Alumno() { }
    }
}
