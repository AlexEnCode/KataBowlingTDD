using KataBowlingTDD;
namespace TestKataBowling
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FinDeLaPartieAuTour10()
        {
            //arrange
            var partieBowling = new Bowling();
            //act
            var result = partieBowling.Jouer();
            //assert
            Assert.IsTrue(result);

        }
        [TestMethod]
        public void DeuxLancerParRound()
        {
            //arrange
            var partieBowling = new Bowling();
            //act
            partieBowling.Round();
            var Lancer = partieBowling.Round;
            //assert
            Assert.AreEqual(Lancer, 2);
        }
    }
}




