using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeiroProjeto;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjeto.Tests
{
    [TestClass()]
    public class ContasTests
    {
        [TestMethod()]
        public void SomaTest() {
            var a = 5;
            var b = 5;
            var esperado = 10;
            var conta = new Contas();

            var result = conta.Soma(a, b);

            Assert.AreEqual(esperado, result);
        }
        [TestMethod()]
        public void SubtracaoTest() {
            var a = 5;
            var b = 5;
            var esperado = 0;
            var conta = new Contas();

            var result = conta.Subtracao(a, b);

            Assert.AreEqual(esperado, result);
        }
        [TestMethod()]
        public void MultiplicacaoTest() {
            var a = 5;
            var b = 5;
            var esperado = 25;
            var conta = new Contas();

            var result = conta.Multiplicacao(a, b);

            Assert.AreEqual(esperado, result);
        }
        [TestMethod()]
        public void DivisaoTest() {
            var a = 5;
            var b = 5;
            var esperado = 1;
            var conta = new Contas();

            var result = conta.Divisao(a, b);

            Assert.AreEqual(esperado, result);
        }
    }
}