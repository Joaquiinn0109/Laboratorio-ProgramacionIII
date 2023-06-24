// See https://aka.ms/new-console-template for more information
using GestorMails;
using System.Data.SqlClient;

string connectionString =
            "Persist Security Info=True;Initial Catalog=Demo;Data Source=.; Integrated Security=True;TrustServerCertificate=True;";

string querySql = "SELECT CorreoID, Nombre, Email, Asunto, Cuerpo FROM dbo.GestorCorreo";

Gestor gestor = new Gestor();

using (var connection =
    new SqlConnection(connectionString))
{
    var command = new SqlCommand(querySql, connection);

    try
    {
        connection.Open();

        SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            var contacto = new Contacto();
            var mensaje = new Mensaje();

            contacto.Nombre = reader[1].ToString();
            contacto.Email = reader[2].ToString();

            mensaje.Remitente = contacto;

            mensaje.Asunto = reader[3].ToString();
            mensaje.Cuerpo = reader[4].ToString();

            gestor.AgregarBDE(mensaje);
        }
        reader.Close();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"[ERROR] {ex.Message}");
    }
    foreach (var item in gestor.BandejaDeEntrada)
    {
        Console.WriteLine($" Asunto: {item.Asunto}\n Nombre: {item.Remitente.Nombre}\n Email: {item.Remitente.Email}\n Mensaje: {item.Cuerpo}\n -----------------------");
    }
}
