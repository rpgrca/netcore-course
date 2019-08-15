using System;
using Xunit;
using TDD.Domain;

namespace TDDUnitTest
{
    public class DivisionTest
    {
        [Fact]
        public void Given1And1_DivisionShouldReturn1()
        {
            var division = new Division();
            var resultado = division.Dividir(1, 1);

            Assert.Equal(1, resultado);
        }
    }
}
