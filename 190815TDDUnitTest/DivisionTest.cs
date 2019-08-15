using System;
using Xunit;
using TDD.Domain;

namespace TDDUnitTest
{
    public class DivisionTest
    {
        [Fact]
        public void GivenTwoEqualNumbers_DivisionShouldReturnOne()
        {
            var division = new Division();
            var resultado = division.Dividir(1, 1);

            Assert.Equal(1, resultado);
        }

        [Fact]
        public void GivenOneAndTwo_DividirShouldReturnCorrectValue() {
            var division = new Division();
            var resultado = division.Dividir(1, 2);

            Assert.Equal(0.5, resultado);
        }
    }
}
