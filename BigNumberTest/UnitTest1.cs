using BigNumber;
using System.Diagnostics;

namespace BigNumberTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PerformanceTest()
        {
            var sw = new Stopwatch();
            sw.Start();
            var a = "1" + new string('0', 100000);
            var b = "1" + new string('0', 100000);
            var expectedSum = "2" + new string('0', 100000);

            //act
            var actualSum = MathUtil.Sum(a, b);

            //assert
            Assert.AreEqual(expectedSum, actualSum);
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }

        [DataRow("0", "0", "0")]
        [DataRow("1234", "5678", "6912")]
        [DataRow("18446744073709551615", "18446744073709551615", "36893488147419103230")]
        [DataRow("10", "1", "11")]
        [DataRow("9", "1", "10")]
        [TestMethod()]
        public void SumTest(string a, string b, string expectedSum)
        {
            //act
            var actualSum = MathUtil.Sum(a, b);

            //assert
            Assert.AreEqual(expectedSum, actualSum);
        }
    }
}