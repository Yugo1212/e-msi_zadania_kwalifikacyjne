using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskForInterview.Tests
{
    public class CalculateYTest
    {
        [Fact]
        public void CheckCalculateY_IfXIsLessThanMinusOneAndHalf_ShouldReturnZero()
        {
            var x = -2;
            var exercise1 = new Exercise1();

            var result = exercise1.CalculateY(x);

            Assert.Equal(0, result);
        }

        [Fact]
        public void CheckCalculateY_IfXIsMoreThanMinusOneAndHalf_ShouldReturnPowerOfX()
        {
            var x = 0;
            var exercise1 = new Exercise1();

            var result = exercise1.CalculateY(x);

            Assert.Equal(x * x, result);
        }
    }
}
