using KataBowlingTDD;
namespace TestKataBowling
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NombreDeTourEstDe10()
        {
            //arrange
            var partieBowling = new Bowling();
            var a = 10;
            //act
            var nombreTour = partieBowling.Tour;
            //assert
            Assert.IsTrue(nombreTour == a);
        }
    }
}