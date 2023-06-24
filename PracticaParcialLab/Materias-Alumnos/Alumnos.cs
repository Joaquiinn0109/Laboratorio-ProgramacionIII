
namespace Materias_Alumnos
{
    public class Alumnos
    {
        public int AlumnoId { get; set; }
        public string Legajo { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string NombreCompleto()
        {
            return $"{Nombre}, {Apellido}";
        }
        public Alumnos() { }
    }
}
