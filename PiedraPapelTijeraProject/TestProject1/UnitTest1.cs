using PPT.Entidades;

namespace TestProject1
{
    public class UnitTest1
    {
        //EMPATAR c/u
        [Fact]
        public void DebeEmpatarPiedraconPiedra()
        {
            var p1 = new Piedra();
            var p2 = new Piedra();

            var resultado = p1.ResultadoCon(p2);

            Assert.Equal("empata", resultado);
        }
        [Fact]
        public void DebeEmpatarPapelconPapel()
        {
            var pa1 = new Papel();
            var pa2 = new Papel();

            var resultado = pa1.ResultadoCon(pa2);

            Assert.Equal("empata", resultado);
        }
        [Fact]
        public void DebeEmpatarTijeraconTijera()
        {
            var t1 = new Tijera();
            var t2 = new Tijera();

            var resultado = t1.ResultadoCon(t2);

            Assert.Equal("empata", resultado);
        }
        //GANAR c/u
        [Fact]
        public void DebeGanarLaPiedraalaTijera()
        {
            var p = new Piedra();
            var t = new Tijera();

            var resultado = p.ResultadoCon(t);

            Assert.Equal("pierde", resultado);
        }
        [Fact]
        public void DebeGanarElPapelALaPiedra()
        {
            var pa = new Papel();
            var p = new Piedra();

            var resultado = pa.ResultadoCon(p);

            Assert.Equal("pierde", resultado);
        }
        [Fact]
        public void DebeGanarLaTijeraAlPapel()
        {
            var t = new Tijera();
            var pa = new Papel();

            var resultado = t.ResultadoCon(pa);

            Assert.Equal("pierde", resultado);
        }
        //PERDER c/u 
        [Fact]
        public void DebePerderLaPiedraConElPapel()
        {
            var p = new Piedra();
            var pa = new Papel();

            var resultado = p.ResultadoCon(pa);

            Assert.Equal("gana", resultado);
        }
        [Fact]
        public void DebePerderElPapelConLaTijera()
        {
            var pa = new Papel();
            var t = new Tijera();

            var resultado = pa.ResultadoCon(t);

            Assert.Equal("gana", resultado);
        }
        [Fact]
        public void DebePerderLaTijeraConLaPiedra()
        {
            var t = new Tijera();
            var p = new Piedra();

            var resultado = t.ResultadoCon(p);

            Assert.Equal("gana", resultado);
        }
    }
}