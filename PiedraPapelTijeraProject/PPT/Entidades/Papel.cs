using PPT.Entidades;
namespace PPT.Entidades
{
    public class Papel:ElementoBase 
    {
        public Papel()
        {
            Tipo = "Papel";
        }

        public override string ResultadoCon(ElementoBase e)
        {
            return e.ResultadoParaPapel();
        }

        public override string ResultadoParaPiedra()
        {
            return "gana";
        }

        public override string ResultadoParaPapel()
        {
            return "empata";
        }

        public override string ResultadoParaTijera()
        {
            return "pierde";
        }
    }
}
