
namespace Materias_Alumnos
{
    public class Materias
    {
        public string MateriaId { get; set; }
        public List<Alumnos> AlumnoList { get; set;}
        public Materias() 
        { 
            AlumnoList = new List<Alumnos>();
        }

    }
}
