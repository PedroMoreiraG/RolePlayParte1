using Library;

namespace LibraryTests;

[TestFixture]
public class PersonajeTests
{
    [Test]
    [TestCase("Luis", "Guerrero")]
    public void Constructor_WithValidParameters_SetsProperties(string nombre, string raza)
    {
        Personaje pj = new Personaje(nombre, raza);
        
        Assert.That(pj.Nombre, Is.EqualTo(nombre));
        Assert.That(pj.Raza, Is.EqualTo(raza));
    }
}