namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Miedad()
        {
            var cumplea�os = new DateTime(1998, 09, 01);
            var hoy = new DateTime(2023, 03, 30);

            var edad = hoy.Year - cumplea�os.Year;

            if(hoy.Month < cumplea�os.Month)
            {
                edad = edad - 1;
            }
            else if (hoy.Month == cumplea�os.Month)
            {
                if (hoy.Day < cumplea�os.Day)
                {
                    edad = edad - 1;
                }
            }
            Assert.Equal(24, edad);
        }
        [Fact]
        public void Miedad2()
        {
            var f1 = new DateTime(1998, 09, 01);
            var hoy = DateTime.Today;

            var diferencia = hoy.Subtract(f1);

            var edad = diferencia.Days / 365;

            Assert.Equal(24, edad);
        }
        [Fact]
        public void Miedad3()
        {
            var f1 = new DateTime(1998, 09, 01);
            var hoy = DateTime.Today;

            var diferencia = hoy.Subtract(f1);

            var f2 = new DateTime(diferencia.Ticks);

            Assert.Equal(25, f2.Year);
        }
    }
}