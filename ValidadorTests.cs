using Xunit;
using MiAppBlazor.Services;

namespace PruebasBlazor;

public class ValidadorTests
{
    [Fact]
    public void TestEmail()
    {
        Validador v = new Validador();
        bool r = v.ValidarEmail("test@mail.com");
        Assert.True(r);
    }

    [Fact]
    public void TestEmailMalo()
    {
        Validador v = new Validador();
        bool r = v.ValidarEmail("testmailcom");
        Assert.False(r);
    }

    [Fact]
    public void PruebaEdad()
    {
        Validador v = new Validador();
        Assert.True(v.ValidarEdad(20));
    }

    [Fact]
    public void PruebaEdadMala()
    {
        Validador v = new Validador();
        Assert.False(v.ValidarEdad(15));
    }

    [Fact]
    public void NombrePrueba()
    {
        Validador v = new Validador();
        Assert.True(v.ValidarNombre("Juan"));
    }

    //[Fact]
    //public void NombreMalo()
   // {
       // Validador v = new Validador();
    
      //  Assert.False(v.ValidarNombre("as"));
  //  }
}
