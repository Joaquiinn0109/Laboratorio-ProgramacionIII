namespace TestProject1
{
    public class FormateoTest
    {
        [Fact]
        public void Formatear()
        {
            var f1 = new DateTime(1998, 9, 1, 17, 52, 0, 0);

            Assert.Equal("1/9/1998", f1.ToShortDateString());
            Assert.Equal("martes, 1 de septiembre de 1998",f1.ToLongDateString());

            Assert.Equal("martes", f1.ToString("dddd"));
            Assert.Equal(DayOfWeek.Tuesday, f1.DayOfWeek);
            Assert.Equal("martes, 1 de septiembre de 1998", f1.ToString("D"));

            const string FORMAT = "ddd d \\de MMMM \\de yyyy \\a la\\s HH:mm";

            const string FORMAT2 = @"ddd d \de MMMM \de yyyy \a la\s HH:mm";

            Assert.Equal("mar. 1 de septiembre de 1998 a las 17:52", f1.ToString(FORMAT));

            Assert.Equal("mar. 1 de septiembre de 1998 a las 17:52", f1.ToString(FORMAT2));

            Assert.Equal("mar. 1 de septiembre de 1998 a las 17:52", f1.ToString("ddd d 'de' MMMM 'de' yyyy 'a las' HH:mm"));
        }    
    }
}