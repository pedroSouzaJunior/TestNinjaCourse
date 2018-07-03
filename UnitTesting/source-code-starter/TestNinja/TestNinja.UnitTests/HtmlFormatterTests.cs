using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement()
        {
            var formater = new HtmlFormatter();

            var result = formater.FormatAsBold("conteudo");

            //assertiva especifica
            Assert.That(result, Is.EqualTo("<strong>conteudo</strong>"));

            //assertivas mais genericas 
            Assert.That(result, Does.StartWith("<strong>").IgnoreCase);
            Assert.That(result, Does.EndWith("</strong>").IgnoreCase);
            Assert.That(result, Does.Contain("conteudo").IgnoreCase);
        }
    }
}
