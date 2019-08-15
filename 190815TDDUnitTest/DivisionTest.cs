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

        [Fact]
        public void GivenANumberAndZero_DividirShouldThrowException() {
            var division = new Division();

            // Forma antigua
            #if false
            try {
                var resultado = division.Dividir(1, 0);
                Assert.True(false, "Se esperaba una excepcion");
            }
            catch (NoDivisionByZeroException ex) {
                Assert.Equal("NO", ex.Message);
            }
            catch (Exception) {
                Assert.True(false, "Se obtuvo una excepcion incorrecta");
            }
            #else
            // Forma nueva
            Assert.Throws<NoDivisionByZeroException>(() => { division.Dividir(1, 0); });
            #endif
        }
    }
}
