using System;
using NUnit.Framework;
using Model;

namespace UnitTests.Model
{
    [TestFixture]
    internal class PyramidTest
    {
        [Test]
        [TestCase((uint)1, (uint)1, TestName = "Поля со значениями 1")]
        [TestCase((uint)50, (uint)666, TestName = "Поля со значениями 50, 666")]
        [TestCase(uint.MaxValue, uint.MaxValue, TestName = "Поля со значениями uint.MaxValue")]
        public void ConstructorPositiveTest(uint baseArea, uint height)
        {
            var pyramid = new Pyramid(baseArea, height);
        }
        
        [Test]
        [TestCase(uint.MinValue, (uint)34, TestName = "Площадь основания имеет нулевое значение")]
        [TestCase(uint.MaxValue, uint.MinValue, TestName = "Высота имеет нулевое значение")]
        public void ConstructorNegativeTest(uint baseArea, uint height)
        {
            Assert.Throws<Exception>
            (
                delegate
                {
                    var pyramid = new Pyramid(baseArea, height);
                }
            );
        }

        [Test]        
        [TestCase((uint)1, (uint)1, TestName = "Поля со значениями 1")]
        [TestCase((uint)54, (uint)1, TestName = "Поля со значениями 54, 1")]
        [TestCase((uint)46340, (uint)46341, TestName = "Поля со значениями 46340, 46341")]
        [TestCase(3000000000, 3000000000, TestName = "Поля со значениями 3000000000")]
        [TestCase((uint)1, uint.MaxValue, TestName = "Поля со значениями 1, uint.MaxValue")]
        [TestCase(uint.MaxValue, uint.MaxValue, TestName = "Поля со значениями uint.MaxValue")]
        public void VolumePositiveTest(uint baseArea, uint height)
        {
            var expected = baseArea / 3.0 * height;
            var pyramid = new Pyramid(baseArea, height);
            var actual = pyramid.Volume;
            Assert.AreEqual(expected, actual);
        }
    }
}
