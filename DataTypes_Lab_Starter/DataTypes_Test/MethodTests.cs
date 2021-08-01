using NUnit.Framework;
using DataTypes_Lib;

namespace DataTypes_Test
{
    public class MethodTests
    {   
            // DONE

        [TestCase(1, 1)]
        //[TestCase(1, 3_628_800)]
        public void Factorial_Returns_CorrectInteger(int n, long expResult)
        {
            var result = Methods.Factorial(n);
            Assert.That(result, Is.EqualTo(expResult));
        }

            // DONE

        [Test]
        public void Mult_ReturnsCorrectProductOfFloats()
        {
            var result = Methods.Mult(2.1f, 3.0f);
            Assert.That(result, Is.EqualTo(6.30000f));           
        }
    }
}