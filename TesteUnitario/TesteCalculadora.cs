using Microsoft.VisualStudio.TestTools.UnitTesting;
using AtividadeTDD;

namespace TesteUnitario
{
    [TestClass]
    public class TesteCalculadora
    {
        Calculadora calculadora = new Calculadora();

        [TestMethod]
        public void TesteDiferenca()
        {
            int diferenca = calculadora.Diferenca(10,2);
            Assert.AreEqual(diferenca, 8);
        }

        [TestMethod]
        public void TesteDivisao()
        {
            int divisao = calculadora.Divisao(10, 2);
            Assert.AreEqual(divisao, 5);
        }

        [TestMethod]
        public void TesteProduto()
        {
            int produto = calculadora.Produto(10, 2);
            Assert.AreEqual(produto, 20);
        }

        [TestMethod]
        public void TesteSoma()
        {
            int soma = calculadora.Soma(10, 2);
            Assert.AreEqual(soma, 12);
        }
    }
}