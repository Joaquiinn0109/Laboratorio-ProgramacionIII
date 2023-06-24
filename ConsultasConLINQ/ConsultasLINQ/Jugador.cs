
namespace ConsultasLINQ
{
    public class Jugador
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Club { get; set; }
        public string Posicion { get; set; }
        public Jugador(string nombre, int edad, string club, string posicion) 
        {
            Nombre = nombre;
            Edad = edad;
            Club = club;
            Posicion = posicion;
        }
    }
}
