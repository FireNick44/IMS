using MyApp;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestApp
{
    class TestTextHandler
    {
        [Test]
        public void TestMakeUpperCase()
        {
            //arrange
            TextHandler th = new TextHandler();
            //act
            string result = th.MakeUpperCase("bbzw");
            //assert
            Assert.AreEqual("BBZW", result);
        }
        [Test]
        public void TestMakeLowerCase()
        {
            //arrange
            TextHandler th = new TextHandler();
            //act
            string result = th.MakeLowerCase("BBZW");
            //assert
            Assert.AreEqual("bbzw", result);
        }
    }
}
