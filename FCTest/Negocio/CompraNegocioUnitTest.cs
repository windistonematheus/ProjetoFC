using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca.Negocio;
using Biblioteca.Classes_Basicas;

namespace FCTest.Negocio
{
    [TestClass]
    public class CompraNegocioUnitTest

    {
        private CompraNegocio compraNegocio = new CompraNegocio();
        [TestMethod]
        public void TestMethod1()
        {
            Compra compra = new Compra();
            compra.Preco = 1;

            Assert.IsTrue(compraNegocio.ValidarPreco(compra));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Compra compra = new Compra();
            compra.Quantidade = 1;

            Assert.IsTrue(compraNegocio.ValidarQuantidade(compra));
        }

    }
}
