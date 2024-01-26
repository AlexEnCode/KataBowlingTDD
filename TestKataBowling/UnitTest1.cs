using KataBowlingTDD;
using static System.Formats.Asn1.AsnWriter;
namespace TestKataBowling
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FinDeLaPartie()
        {
            //arrange
            var partieBowling = new Bowling();
            //act
            string result = partieBowling.Party();

            string str = $"La partie est terminée vous avez {partieBowling.Score} point! Félicitations!";

            //assert
            Assert.AreEqual(result, str);
        }
            }
}




