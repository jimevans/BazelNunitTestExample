using NUnit.Framework;

namespace BazelNunitTestExample.Tests
{
    [TestFixture]
    public class ImplementationClassTests
    {
        [Test]
        public void ConfirmConstructorValue()
        {
            ImplementationClass implementation = new ImplementationClass(15);
            Assert.That(implementation.Value == 15);
        }
    }
}
