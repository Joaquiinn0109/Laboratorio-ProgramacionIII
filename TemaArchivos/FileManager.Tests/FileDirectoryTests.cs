namespace FileManager.Tests
{
    public class FileDirectoryTests
    {
        [Fact]
        public void CrearUnArchivo()
        {
            var writer = new System.IO.StreamWriter(path: "demo.txt", append: false);

            writer.Write("Demo Demo");

            writer.Close();

            Assert.True(true);
        }
        [Fact]
        public void LeerUnArchivo()
        {
            var reader = new System.IO.StreamReader(path: "demo.txt");

            var contenido = reader.ReadToEnd();
            reader.Close();

            Assert.Equal("Demo Demo", contenido);

            Assert.True(true);
        }
        [Fact]
        public void EscribirUnArchivoAppendAllText()
        {
            File.AppendAllText(path: "demo-2.txt", "Otro Archivo");

            Assert.True(true);
        }
        [Fact]
        public void DirectorioCrear()
        {
            Directory.CreateDirectory("Starwars");

            var d = new DirectoryInfo("Starwars");

            //d.CreateSubdirectory("Galaxy");

            Assert.True(true);
        }
        [Fact]
        public void DirectorioEliminar()
        {
            var d = new DirectoryInfo("Starwars");

            d.Delete();
            //d.CreateSubdirectory("Galaxy");

            Assert.True(true);
        }
    }
}