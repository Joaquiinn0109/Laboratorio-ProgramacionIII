
namespace GestorMails
{
    public class Contacto
    {
        public string Nombre { get; set; }

        public string Email { get; set; }

        public Contacto(string nombre, string email)
        {
            Nombre = nombre;
            Email = email;
        }
        public Contacto() { }
    }
}
