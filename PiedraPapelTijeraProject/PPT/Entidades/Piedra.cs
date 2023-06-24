using PPT.Entidades;
namespace PPT.Entidades
{
    public class Piedra:ElementoBase
    {
        public Piedra()
        {
            Tipo = "Piedra";
        }

        public override string ResultadoCon(ElementoBase e)
        {
            return e.ResultadoParaPiedra();
        }

        public override string ResultadoParaPiedra()
        {
            return "empata";
        }

        public override string ResultadoParaPapel()
        {
            return "pierde";
        }

        public override string ResultadoParaTijera()
        {
            return "gana";
        }
    }
}
