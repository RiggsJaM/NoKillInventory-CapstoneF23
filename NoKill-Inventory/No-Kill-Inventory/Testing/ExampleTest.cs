using No_Kill_Inventory.Components.Account.Pages;
using No_Kill_Inventory.Components.Pages;
using Bunit;

namespace Testing;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bunit;

[TestClass]
public class ExampleTest : BunitTestContext
{
    [TestMethod]
    public void TestLoginFieldsDisplay()
    {
        var cut = RenderComponent<Login>();
        
        Assert.IsTrue(cut.Markup.Contains("Username"));
        Assert.IsTrue(cut.Markup.Contains("Password"));
    }
}