using System.Collections.Generic;
using System.Diagnostics;
using NUnit.Framework;

namespace Training1
{
    [TestFixture]
    public class TrainingClass
    {
        [Test]
        public void Of_1_EmptyList()
        {
            var expted = new List<int>();
            var actual = Primefactor.Of(1);

            Assert.AreEqual(expted, actual);
        }

        [Test]
        public void Of_2_ListWithPrimefactors()
        {
            var expted = new[] { 2};
            var actual = Primefactor.Of(2);

            Assert.AreEqual(expted, actual);
        }

        [Test]
        public void Of_3_ListWithPrimefactors()
        {
            var expted = new[] { 3 };
            var actual = Primefactor.Of(3);

            Assert.AreEqual(expted, actual);
        }

        [Test, Ignore("")]
        public void AkseptanseTest()
        {
            var expected = new List<int> { 2, 3, 5, 7, 11, 79, 83 };
            var actual = Primefactor.Of(2*3*5*7*11*79*83);
            
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10), Ignore("")]
        public void YtelseTest(int performanceIndikator)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            Primefactor.Of(int.MaxValue);
            stopwatch.Stop();

            Assert.IsTrue(stopwatch.Elapsed.Seconds < performanceIndikator);
        }
    }
}
