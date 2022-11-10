using MyApp;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestApp
{
    public class TestMathHandler
    {
        [Test]
        public void TestAddition()
        {
            //arrange
            MathsHandler mh = new MathsHandler();
            //act
            int result = mh.Addition(50, -30);
            //assert
            Assert.That(result, Is.EqualTo(20));
        }
        [Test]
        public void TestSubraktion()
        {
            //arrange
            MathsHandler mh = new MathsHandler();
            //act
            int result = mh.Subtraktion(-20, 45);
            //assert
            Assert.That(result, Is.EqualTo(20));
        }

    }
}
