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

            string str = $"La partie est termin�e vous avez {partieBowling.Score} point! F�licitations!";

            //assert
            Assert.AreEqual(result, str);
        }
            }
}




