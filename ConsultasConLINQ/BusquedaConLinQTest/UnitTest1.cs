using ConsultasLINQ;

namespace BusquedaConLinQTest
{
    public class UnitTest1
    {
        [Fact]
        public void DebeBuscarJugadoresConEdadMayorA25()
        {
            var lista = new LinkedList<Jugador>();

            lista.AddLast(new Jugador("Juan", 24, "River", "Delantero"));
            lista.AddLast(new Jugador("Joaquin", 27, "Boca", "Mediocampista"));
            lista.AddLast(new Jugador("Pedro", 28, "Rosario Central", "Defensor"));
            lista.AddLast(new Jugador("Jose", 30, "Independiente", "Arquero"));

            var jugadoresMayoresDe25 = (from j in lista
                                        where j.Edad > 25
                                        select j).Count();
            Assert.Equal(4, lista.Count());
            Assert.Equal(3, jugadoresMayoresDe25);
        }
        [Fact]
        public void DebeBuscarJugadoresConPosicionesIguales()
        {
            var lista = new LinkedList<Jugador>();

            lista.AddLast(new Jugador("Juan", 24, "River", "Defensor"));
            lista.AddLast(new Jugador("Joaquin", 27, "Boca", "Mediocampista"));
            lista.AddLast(new Jugador("Pedro", 28, "Rosario Central", "Defensor"));
            lista.AddLast(new Jugador("Jose", 30, "Independiente", "Arquero"));

            var jugadoresConPosicionesIguales = (from j in lista
                                        where j.Posicion == "Defensor"
                                        select j).Count();
            Assert.Equal(4, lista.Count());
            Assert.Equal(2, jugadoresConPosicionesIguales);
        }
        [Fact]
        public void DebeBuscarJugadoresConNombresTerminadosEnN()
        {
            var lista = new LinkedList<Jugador>();

            lista.AddLast(new Jugador("Juan", 24, "River", "Delantero"));
            lista.AddLast(new Jugador("Joaquin", 27, "Boca", "Mediocampista"));
            lista.AddLast(new Jugador("Pedro", 28, "Rosario Central", "Defensor"));
            lista.AddLast(new Jugador("Jose", 30, "Independiente", "Arquero"));

            var jugadoresConNombresTerminadosEnN = (from j in lista
                                        where j.Nombre.EndsWith("n")
                                        select j).Count();
            Assert.Equal(4, lista.Count());
            Assert.Equal(2, jugadoresConNombresTerminadosEnN);
        }
        [Fact]
        public void DebeBuscarJugadoresConNombresTerminadosEnO()
        {
            var lista = new LinkedList<Jugador>();

            for (int i = 0; i < 1000; i++)
            {
                if(i % 2 == 0)
                {
                    lista.AddLast(new Jugador("Juan", i, "River", "Delantero"));
                }
                else
                    lista.AddLast(new Jugador("Pedro", i * 2, "Boca", "Defensor"));
            }

            var jugadorConNombresTerminadosEnO = (from j in lista
                                   where j.Nombre.EndsWith("o")
                                   select j).Count();

            Assert.Equal(1000, lista.Count());
            Assert.Equal(500, jugadorConNombresTerminadosEnO);
            
        }
        [Fact]
        public void DebeBuscarJugadoresConEdadesMenoresA100()
        {
            var lista = new LinkedList<Jugador>();

            for (int i = 0; i < 1000; i++)
            {
                if (i % 2 == 0)
                {
                    lista.AddLast(new Jugador("Juan", i, "River", "Delantero"));
                }
                else
                    lista.AddLast(new Jugador("Pedro", i * 2, "Boca", "Defensor"));
            }

            var jugadorConEdadMenorA100 = (from j in lista
                                                  where j.Edad < 100
                                                  select j).Count();

            Assert.Equal(1000, lista.Count());
            Assert.Equal(75, jugadorConEdadMenorA100);
        }
        [Fact]
        public void DebeBuscarJugadoresConLaMayorEdad()
        {
            var lista = new LinkedList<Jugador>();

            for (int i = 0; i < 1000; i++)
            {
                if (i % 2 == 0)
                {
                    lista.AddLast(new Jugador("Juan", i, "River", "Delantero"));
                }
                else
                    lista.AddLast(new Jugador("Pedro", i * 2, "Boca", "Defensor"));
            }

            var jugadorMayor = lista.Max(j => j.Edad);

            var jugadorConMayorEdad = (from j in lista 
                                       select j.Edad).Max();

            Assert.Equal(1000, lista.Count());
            Assert.Equal(2000, jugadorMayor);
            Assert.Equal(2000, jugadorConMayorEdad);
        }
    }
}