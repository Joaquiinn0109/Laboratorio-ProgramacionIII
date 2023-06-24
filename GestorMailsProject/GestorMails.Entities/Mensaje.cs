
namespace GestorMails
{
    public class Mensaje
    {
        public string Asunto { get; set; }
        public string Cuerpo { get; set; }
        public Contacto Remitente { get; set; }
        public Contacto Para { get; set; }
        public Mensaje(string asunto, string cuerpo) 
        {
            Asunto = asunto;
            Cuerpo = cuerpo;
        }
        public Mensaje() { }
    }
}
