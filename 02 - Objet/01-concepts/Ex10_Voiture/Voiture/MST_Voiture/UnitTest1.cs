using CL_Voiture;

namespace MST_Voiture
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Avancer_Eteint()
        {
            Voiture titine = new Voiture();
            Assert.IsFalse(titine.Avancer());
        }

        [TestMethod]
        public void Test_Avancer_Allume()
        {
            Voiture titine = new Voiture();
            titine.Demarrer();
            Assert.IsTrue(titine.Avancer());
        }
    }
}