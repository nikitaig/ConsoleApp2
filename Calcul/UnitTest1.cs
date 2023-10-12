using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Calcul
{
    public class Calc
    {
        [SetUp]
        public void Setup()
        {
        }S

        [Test]
        public void Sum_10and20_30returned()
        {
            int x = 10;
            int y = 20;
            int expected = 30;

            Calc c = new Calc ();
            int actual = c.Sum(x, y);

            Assert.AreEqual (expected, actual);
        }
    }
}