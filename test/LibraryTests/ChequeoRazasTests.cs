using NUnit.Framework;
using Library;

namespace LibraryTests
{
    public class ChequeoRazasTests
    {
        // Test genérico para todas las razas válidas
        [TestCase("Mago", 70, 30)]
        [TestCase("Enano", 50, 60)]
        [TestCase("Elfo", 55, 55)]
        [TestCase("Guerrero", 60, 50)]
        [TestCase("Hada", 65, 45)]
        public void Estadistica_DeberiaAsignarEstadisticas_Correctamente(string raza, int ataqueEsperado, int defensaEsperada)
        {
            // Arrange
            var chequeoRazas = new ChequeoRazas(); // Inicializado dentro del test
            var personaje = new Personaje("NombrePrueba", raza);

            // Act
            chequeoRazas.Estadistica(personaje);

            // Assert
            Assert.AreEqual(ataqueEsperado, personaje.Ataque, $"Ataque esperado para raza {raza}");
            Assert.AreEqual(defensaEsperada, personaje.Defensa, $"Defensa esperada para raza {raza}");
        }

        // Test para raza desconocida
        [Test]
        public void Estadistica_DeberiaMostrarMensajeParaRazaDesconocida()
        {
            // Arrange
            var chequeoRazas = new ChequeoRazas(); // Inicializado dentro del test
            var personaje = new Personaje("Desconocido", "Alien");

            // Capturar la salida de consola
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                chequeoRazas.Estadistica(personaje);

                // Assert
                var expectedMessage = $"La raza del personaje llamado {personaje.Nombre} no existe\r\n";
                Assert.AreEqual(expectedMessage, sw.ToString());
            }
        }
    }
}
