using System;
using NUnit.Framework;
using Model;

namespace UnitTests.Model
{
    internal class SphereTest
    {
        [Test]
        [TestCase((uint)1, TestName = "Радиус со значениями 1")]
        [TestCase((uint)666, TestName = "Радиус со значениями 666")]
        [TestCase(2500000000, TestName = "Радиус со значением 2500000000")]
        [TestCase(uint.MaxValue, TestName = "Радиус со значениями uint.MaxValue")]
        public void ConstructorPositiveTest(uint radius)
        {
            var sphere = new Sphere(radius);
        }

        [Test]
        [TestCase(uint.MinValue, TestName = "Радиус имеет нулевое значение")]
        public void ConstructorNegativeTest(uint radius)
        {
            Assert.Throws<Exception>
            (
                delegate
                {
                    var sphere = new Sphere(radius);
                }
            );
        }

        [Test]
        [TestCase((uint)1, TestName = "Радиус со значением 1")]
        [TestCase((uint)54, TestName = "Радиус со значением 54")]
        [TestCase((uint)46341, TestName = "Радиус со значением 46341")]
        [TestCase(4000000000, TestName = "Радиус со значением 4000000000")]
        [TestCase(uint.MaxValue, TestName = "Радиус со значением uint.MaxValue")]
        public void VolumePositiveTest(uint radius)
        {
            var expected = 4.0 / 3 * Math.PI * radius * radius * radius;
            var sphere = new Sphere(radius);
            var actual = sphere.Volume;
            Assert.AreEqual(expected, actual);
        }
    }
}
