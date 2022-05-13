using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using ExemploService.Extensions;

namespace ExemploServiceTest.EntityModel
{
    [TestClass]
    public class ValorExtensionTests
    {
        [TestMethod]
        public void FormatToDescription()
        {
            ExemploService.EntityModel.ValorType valor = 
                new ExemploService.EntityModel.ValorType(25052);
            Assert.AreEqual("250,52", valor.ToDescription());
        }

        [TestMethod]
        public void FormatToDecimal()
        {
            ExemploService.EntityModel.ValorType valor =
                new ExemploService.EntityModel.ValorType(25052);
            Assert.AreEqual(250.52M, valor.ToDecimal()) ;
        }

        [TestMethod("Teste decimal sem valor")]
        public void FormatToDecimalNullTest()
        {
            ExemploService.EntityModel.ValorType valor =
                new ExemploService.EntityModel.ValorType();
            Assert.AreEqual(0M, valor.ToDecimal());
        }

        [TestMethod("Teste Description sem valor")]
        public void FormatToDescriptionNullTest()
        {
            ExemploService.EntityModel.ValorType valor =
                new ExemploService.EntityModel.ValorType();
            Assert.AreEqual("0", valor.ToDescription());
        }
    }
}
