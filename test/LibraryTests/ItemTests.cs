using Library
namespace LibraryTests
{
    [TestFixture]
    public class ItemTests
    {
        [Test]
        public void TestAgregarYQuitarItems()
        {
            // Crear un personaje para las pruebas
            Personaje pj = new Personaje("Hada", 100, new ChequeoRaza());
            ChequeoRaza chequeo = new ChequeoRaza();
            chequeo.Estadisticas(pj);

            // Mostrar estadísticas iniciales del personaje
            Assert.AreEqual(300, pj.Ataque);  // Ataque del Hada después del chequeo de raza
            Assert.AreEqual(150, pj.Defensa); // Defensa del Hada después del chequeo de raza

            // Crear algunos items para agregar al personaje
            Item alas = new Item("Alas", 0, 50); //con las alas el hada puede volar y esquivar el ataque 
            Item barita = new Item("Barita", 60, 10);

            // Agregar las alas al personaje
            alas.agregar_item(pj);
            Assert.AreEqual(200, pj.Defensa); // Defensa debe aumentar a 200 con las alas
            Assert.AreEqual(300, pj.Ataque);  // Ataque no cambia con las alas

            // Agregar la barita al personaje
            barita.agregar_item(pj);
            Assert.AreEqual(210, pj.Defensa); // Defensa aumenta a 210 con la barita
            Assert.AreEqual(360, pj.Ataque);  // Ataque aumenta a 360 con la barita

            // Intentar agregar de nuevo las alas (debe mostrar un mensaje de que ya las tiene)
            alas.agregar_item(pj);
            Assert.AreEqual(200, pj.Defensa); // Defensa debe mantenerse en 200 (no duplicar)
            Assert.AreEqual(360, pj.Ataque);  // Ataque debe mantenerse en 360

            // Quitarle las alas
            alas.quitar_item(pj);
            Assert.AreEqual(160, pj.Defensa); // Defensa debe bajar a 160 al quitar las alas
            Assert.AreEqual(360, pj.Ataque);  // Ataque se mantiene

            // Intentar quitar las alas de nuevo (debe mostrar un mensaje de que no las tiene)
            alas.quitar_item(pj);
            Assert.AreEqual(160, pj.Defensa); // Defensa no cambia al intentar quitar algo que no tiene
            Assert.AreEqual(360, pj.Ataque);  // Ataque se mantiene igual
        }
    }
}
