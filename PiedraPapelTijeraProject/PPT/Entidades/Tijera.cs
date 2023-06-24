using PPT.Entidades;
namespace PPT.Entidades
{
    public class Tijera:ElementoBase
    {
        public Tijera()
        {
            Tipo = "Tijera";
        }

        public override string ResultadoCon(ElementoBase e)
        {
            return e.ResultadoParaTijera();
        }

        public override string ResultadoParaPiedra()
        {
            return "pierde";
        }

        public override string ResultadoParaPapel()
        {
            return "gana";
        }

        public override string ResultadoParaTijera()
        {
            return "empata";
        }
    }
}
