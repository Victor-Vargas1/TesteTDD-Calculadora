using System;
using Xunit;
using New_talents;

namespace Test_New_Talents
{
    public class UnitTest1
    {

        public Calculadora  construirClasse()
        {
            string data = "18/11/2024";
            Calculadora calc = new Calculadora("18/11/2024");

            return calc;
        }

        [Theory]
        [InlineData(1, 2, 3)] // Passa os tres valores 1 = val1, 2 = val2 e 3 = resultado. 
        [InlineData(4, 5, 9)]
        public void TesteSomar( int val1, int val2, int resultado)
        {
            Calculadora calculator = construirClasse();

            int resultadoCalculadora = calculator.somar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)] // Passa os tres valores 1 = val1, 2 = val2 e 3 = resultado. 
        [InlineData(4, 5, 20)]
        public void TesteMultiplicar(int val1, int val2, int resultado)
        {
            Calculadora calculator = construirClasse();

            int resultadoCalculadora = calculator.multiplicar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(4, 2, 2)] // Passa os tres valores 1 = val1, 2 = val2 e 3 = resultado. 
        [InlineData(6, 5, 1)]
        public void TesteSubtrair(int val1, int val2, int resultado)
        {
            Calculadora calculator = construirClasse();

            int resultadoCalculadora = calculator.subtrair(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(8, 2, 4)] // Passa os tres valores 1 = val1, 2 = val2 e 3 = resultado. 
        [InlineData(10,5 , 2)]
        public void TestDividir(int val1, int val2, int resultado)
        {
            Calculadora calculator = construirClasse();

            int resultadoCalculadora = calculator.dividir(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = construirClasse();

            Assert.Throws<DivideByZeroException>(
                () => calc.dividir(3, 0)
            );
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = construirClasse();

            calc.somar(1, 9);
            calc.somar(5, 2);
            calc.somar(6, 3);
            calc.somar(7, 4);

            var lista = calc.historico();

            Assert.NotEmpty(calc.historico());
            Assert.Equal(3, lista.Count);
            
        }


    }
}