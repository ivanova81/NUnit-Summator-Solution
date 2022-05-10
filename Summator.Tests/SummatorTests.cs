using NUnit.Framework;

namespace Summator.Tests
{
    public class Tests
    {
        [Test]
        public void Test_Sum_TwoPositiveNumbers()
        {
            int actual = Summator.Sum(new int[] {5, 7});

            Assert.That(actual == 12);
        }

        [Test]
        public void Test_Sum_TwoNegativeNumbers()
        {
            int actual = Summator.Sum(new int[] { -8, -3 });

            Assert.That(actual == -11);
        }

        [Test]
        public void Test_Sum_PositiveAndNegativeNumber()
        {
            int actual = Summator.Sum(new int[] { -68, 8 });

            Assert.AreEqual(actual, -60);
        }

        [Test]
        public void Test_Sum_EmpryArray()
        {
            int actual = Summator.Sum(new int[] { });

            Assert.AreEqual(actual, 0);
        }

        [Test]
        public void Test_Average_TwoPositiveNumbers()
        {
            double actual = Summator.Average(new int[] { 5, 8 });

            double expected = 6;
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void Test_Average_ThreeNegativeNumbers()
        {
            double actual = Summator.Average(new int[] { -123, -16, -2 });

            double expected = -47;
            Assert.AreEqual(actual, expected);
        }
    }
}