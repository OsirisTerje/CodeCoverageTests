using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Math = Prod_1.Math;

namespace Test_1
{
    public class TestMath
    {
        [Test]
        public void ThatMathAdd()
        {
            var sut = new Math();
            var res = sut.Add(4, 5);
            Assert.That(res,Is.EqualTo(9),"Aha!");
        }
    }
}
