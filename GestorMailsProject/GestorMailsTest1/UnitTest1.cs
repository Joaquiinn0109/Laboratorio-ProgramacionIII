using GestorMails;

namespace GestorMailsTest1
{
    public class UnitTest1
    {
        [Fact]
        public void MensajeTest()
        {
            var mensaje = new Mensaje("Nota Lab 3", "Su nota es: 9");
            var remitente = new Contacto("Joaquin", "joaquin23@gmail.com");
            var para = new Contacto("Pedro", "pedrito_45@hotmail.com");
            
            mensaje.Remitente = remitente;
            mensaje.Para = para;

            Assert.Equal("Nota Lab 3", mensaje.Asunto);
            Assert.Equal("Su nota es: 9", mensaje.Cuerpo);
            Assert.Equal("Joaquin", remitente.Nombre);
            Assert.Equal("joaquin23@gmail.com", remitente.Email);
            Assert.Equal("Pedro", para.Nombre);
            Assert.Equal("pedrito_45@hotmail.com", para.Email);

        }
        [Fact]
        public void GestorTest()
        {
            var gestor = new Gestor();
            var mensaje = new Mensaje("Nota Lab 3", "Su nota es: 8");

            gestor.AgregarBDE(mensaje);
            gestor.AgregarBDS(mensaje);

            Assert.Equal("Nota Lab 3", gestor.BandejaDeEntrada[0].Asunto);
            Assert.Equal("Su nota es: 8", gestor.BandejaDeEntrada[0].Cuerpo);
            Assert.Equal("Nota Lab 3", gestor.BandejaDeSalida[0].Asunto);
            Assert.Equal("Su nota es: 8", gestor.BandejaDeSalida[0].Cuerpo);
        }
    }
}