using System;
using System.Collections.Generic;
using Biblioteca.Classes_Basicas;
using Biblioteca.DAO;
using Biblioteca.Negocio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace FCTest.Integracao
{
    [TestClass]
    public class CompraNegocioIntegarationTest
    {
        private CompraNegocio compraNegocio;
        private Mock<InterfaceCompra> mockCompraRepository;

        public CompraNegocioIntegarationTest()
        {
            compraNegocio = new CompraNegocio();
        }

        public TestContext TestContext { get; set; }

        [TestMethod]
        public void TesteCompraDao()
        {
            List<Compra> compras = new List<Compra>
            {
                    new Compra {Preco = 1.0, Quantidade = 1},
                    new Compra {Preco = 2.0, Quantidade = 2},
                    new Compra {Preco = 3.0, Quantidade = 3}
            };


            mockCompraRepository = new Mock<InterfaceCompra>();
            mockCompraRepository.Setup(p => p.Select(null)).Returns(compras);

            compraNegocio.Dados = mockCompraRepository.Object;
            List<Compra> resultado = compraNegocio.Select(null);
            Assert.AreEqual(compras, resultado);
        }

        [TestMethod]
        public void VerificarDuplicidadeFalse()
        {
            Compra compra = new Compra
            {
                Preco = 1.0,
                Quantidade = 1,

            };

            mockCompraRepository = new Mock<InterfaceCompra>();
            mockCompraRepository.Setup(p => p.VerificarDuplicidade(compra)).Returns(false);

            compraNegocio.Dados = mockCompraRepository.Object;
            Boolean resultado = compraNegocio.VerificarDuplicidade(compra);
            Assert.IsFalse(resultado);
        }
        [TestMethod]
        public void VerificarDelete()
        {
            Compra compra = new Compra
            {
                Preco = 1.0,
                Quantidade = 1
            };

            mockCompraRepository = new Mock<InterfaceCompra>();
            mockCompraRepository.Setup(p => p.Delete(compra));
            mockCompraRepository.Setup(p => p.VerificarDuplicidade(compra)).Returns(true);

            compraNegocio.Dados = mockCompraRepository.Object;
            compraNegocio.Delete(compra);
            mockCompraRepository.Verify(a => a.Delete(It.IsAny<Compra>()));
        }

        [TestMethod]
        public void VerificarInsert()
        {
            Compra compra = new Compra
            {
                Preco = 1.0,
                Quantidade = 1

            };

            mockCompraRepository = new Mock<InterfaceCompra>();
            mockCompraRepository.Setup(p => p.Insert(compra));
            mockCompraRepository.Setup(p => p.VerificarDuplicidade(compra)).Returns(false);

            compraNegocio.Dados = mockCompraRepository.Object;
            compraNegocio.Insert(compra);
            mockCompraRepository.Verify(a => a.Insert(It.IsAny<Compra>()));
        }


        [TestMethod]
        public void VerificarUpdate()
        {
            Compra compra = new Compra
            {
                Preco = 4.0,
                Quantidade = 4
            };

            mockCompraRepository = new Mock<InterfaceCompra>();
            mockCompraRepository.Setup(p => p.Update(compra));
            mockCompraRepository.Setup(p => p.VerificarDuplicidade(compra)).Returns(true);

            compraNegocio.Dados = mockCompraRepository.Object;
            compraNegocio.Update(compra);
            mockCompraRepository.Verify(a => a.Update(It.IsAny<Compra>()));
        }
    }
}
