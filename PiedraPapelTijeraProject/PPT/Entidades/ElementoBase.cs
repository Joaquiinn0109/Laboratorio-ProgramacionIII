using PPT.Entidades;
namespace PPT.Entidades
{
    public abstract class ElementoBase
    {
        public string Tipo { get; set; }

        public virtual string ResultadoCon(ElementoBase e)
        {
            return "";
        }

        public virtual string ResultadoParaPiedra()
        {
            return "";
        }

        public virtual string ResultadoParaPapel()
        {
            return "";
        }

        public virtual string ResultadoParaTijera()
        {
            return "";
        }
    }
}
