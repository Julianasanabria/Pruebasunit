using Xunit;
using Bunit;
using MiAppBlazor.Components.Pages;

namespace PruebasBlazor;

public class UnitTest1 : TestContext
{
    [Fact]
    public void TestHome()
    {
        var component = RenderComponent<Home>();
        component.Find("h1").MarkupMatches("<h1>Hello, world!</h1>");
    }
}