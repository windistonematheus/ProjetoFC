namespace TestProject1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Biblioteca.Classes_Basicas;
    using Biblioteca.DAO;
    using Biblioteca.Negocio;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;
    [TestClass]
    public class MateriaPrimaIntegrationTest
    {
        private MateriaPrimaNegocio materiaPrimaNegocio;
        private Mock<InterfaceMateriaPrima> mockMateriaPrimaRepository;

        public MateriaPrimaIntegrationTest()
        {
            materiaPrimaNegocio = new MateriaPrimaNegocio();
        }

        public TestContext TestContext { get; set; }

        [TestMethod]
        public void PesquisandoPreco()
        {
            List<MateriaPrima> materiasPrimas = new List<MateriaPrima>
                {
                    new MateriaPrima {Id = 1, Validade = DateTime.Now, Descricao = "produto1", Lote = "1", Nome="mat 1", EstoqueAtual=1 },
                    new MateriaPrima {Id = 2, Validade = DateTime.Now, Descricao = "produto2", Lote = "2", Nome="mat 2", EstoqueAtual=2 },
                    new MateriaPrima {Id = 3, Validade = DateTime.Now, Descricao = "produto3", Lote = "3", Nome="mat 3", EstoqueAtual=3 }
                };
            MateriaPrima materiaPrima = new MateriaPrima
            { Id = 4, Validade = DateTime.Now, Descricao = "produto4", Lote = "4", Nome = "mat 4", EstoqueAtual = 4 };

            mockMateriaPrimaRepository = new Mock<InterfaceMateriaPrima>();
            mockMateriaPrimaRepository.Setup(p => p.Select(materiaPrima)).Returns(materiasPrimas);

            materiaPrimaNegocio.Dados = mockMateriaPrimaRepository.Object;
            List<MateriaPrima> resultado = this.materiaPrimaNegocio.Select(materiaPrima);
            Assert.AreEqual(materiasPrimas, resultado);
        }


    }

}