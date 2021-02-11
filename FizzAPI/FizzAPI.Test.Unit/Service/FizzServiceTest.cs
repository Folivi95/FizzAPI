using FizzAPI.Service.Implementation;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace FizzAPI.Test.Unit.Service
{
    public class FizzServiceTest
    {
        [Test]
        public void IsMultipleOfThree()
        {
            var fizzService = new FizzService();
            bool result = fizzService.MultipleOfThree(9);

            Assert.True(result, "9 is a multiple of 3");
        }

        [Test]
        public void IsMultipleOfFive()
        {
            var fizzService = new FizzService();
            bool result = fizzService.MultipleOfFive(25);

            Assert.True(result, "25 is a multiple of 5");
        }

        [Test]
        public void IsMultipleOfThreeAndFive()
        {
            var fizzService = new FizzService();
            bool result = fizzService.MulitpleOfThreeAndFive(45);

            Assert.True(result, "45 is a multiple of 3 and 5");
        }

        [Test]
        public void IsNotMultipleOfThreeAndFive()
        {
            var fizzService = new FizzService();
            bool result = fizzService.MulitpleOfThreeAndFive(9);

            Assert.False(result, "9 is not a multiple of 3 and 5");
        }
    }
}
