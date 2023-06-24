namespace Materias_Alumnos
{
    public class Generador
    {
        public List<Materias> GenerarAlumnos(int cantMaterias, int cantAlumnos)
        {
            var listaMaterias = new List<Materias>();
            
            for (int i = 0; i < cantMaterias; i++)
            {
                var materia = new Materias()
                {
                    MateriaId = $"Materia n°: {i}"
                };
                for (int j = 1; j < cantAlumnos+1; j++)
                {
                    var alumno = new Alumnos()
                    {
                        AlumnoId = j,
                        Nombre = $"Alumno: {j}",
                        Apellido = $"Apellido: {j}",
                        Legajo = $"Legajo: {j}/2023 - {materia.MateriaId}"
                    };
                    materia.AlumnoList.Add( alumno );
                }
                listaMaterias.Add(materia);
            }
            return listaMaterias;
        }
    }
}