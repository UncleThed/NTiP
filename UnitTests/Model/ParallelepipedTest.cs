using System;
using NUnit.Framework;
using Model;

namespace UnitTests.Model
{
    [TestFixture]
    internal class ParallelepipedTest
    {
        [Test]
        [TestCase((uint)1, (uint)1, (uint)1, TestName = "Стороны со значениями 1")]
        [TestCase((uint)3, (uint)34, (uint)100, TestName = "Стороны со значениями 3, 34, 100")]
        [TestCase((uint)1, (uint)666, (uint)50000, TestName = "Стороны со значениями 1, 666, 50000")]
        [TestCase(uint.MaxValue, uint.MaxValue, uint.MaxValue, TestName = "Стороны со значениями uint.MaxValue")]
        public void ConstructorPositiveTest(uint sizeA, uint sizeB, uint sizeC)
        {
            var parallelepiped = new Parallelepiped(sizeA, sizeB, sizeC);
        }

        [Test]
        [TestCase(uint.MinValue, (uint)34, uint.MaxValue, TestName = "Сторона A имеет нулевое значение")]
        [TestCase(uint.MaxValue, uint.MinValue, (uint)777, TestName = "Сторона B имеет нулевое значение")]
        [TestCase((uint)999999, (uint)1, uint.MinValue, TestName = "Сторона C имеет нулевое значение")]
        public void ConstructorNegativeTest(uint sizeA, uint sizeB, uint sizeC)
        {
            Assert.Throws<Exception>
            (
                delegate
                {
                    var parallelepiped = new Parallelepiped(sizeA, sizeB, sizeC);
                }
            );
        }

        [Test]
        [TestCase((uint)1, (uint)1, (uint)1, TestName = "Стороны со значениями 1")]
        [TestCase((uint)54, (uint)1, (uint)8, TestName = "Стороны со значениями 54, 1, 8")]
        [TestCase((uint)1290, (uint)1290, (uint)1291, TestName = "Стороны со значениями 1290, 1290, 1291")]
        [TestCase((uint)1, uint.MaxValue, uint.MaxValue, TestName = "Стороны со значениями 1, uint.MaxValue, uint.MaxValue")]
        [TestCase(uint.MaxValue, uint.MaxValue, uint.MaxValue, TestName = "Стороны со значениями uint.MaxValue")]
        public void VolumePositiveTest(uint sizeA, uint sizeB, uint sizeC)
        {
            var expected = (double)sizeA * sizeB * sizeC;
            var parallelepiped = new Parallelepiped(sizeA, sizeB, sizeC);
            var actual = parallelepiped.Volume;
            Assert.AreEqual(expected, actual);
        }
    }
}
