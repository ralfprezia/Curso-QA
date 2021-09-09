using NUnit.Framework;

namespace Calculadora.Tests
{
    public class CalculadoraTests
    {
       [TestFixture]
       public class CalculadoraSimplesTests
        {
            [Test]
            public void DevoAdicionarDoisNumeros()
            {
                //SUT
                var sut = new CalculadoraSimples();

                var resultado = sut.Adicionar(5, 5);

                Assert.That(resultado, Is.EqualTo(10));
            } 

            [Test]
            public void DevoMultiplicarDoisNumeros()
            {
                var sut = new CalculadoraSimples();

                var resultado = sut.Multiplicar(2, 4);

                Assert.That(resultado, Is.EqualTo(8));
            }
        }
    }
}
