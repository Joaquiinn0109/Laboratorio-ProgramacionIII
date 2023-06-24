using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FileManager.Tests
{
    public class EjercicioTest
    {
        [Fact]
        public void CarpetasAPartirDeUnaFecha()
        {
            var fecha = DateTime.Now;
            string archivo = string.Format("2023-05-06");

            Directory.CreateDirectory($"{fecha.Year}/{fecha.ToString("MM")}/{fecha.ToString("dd")}");

            File.AppendAllText(path: $"{fecha.Year}/{fecha.ToString("MM")}/{fecha.ToString("dd")}/{archivo}.txt","Demo Demo");

            Assert.True(true);        
        }
    }
}