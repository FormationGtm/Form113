using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataLayer;
using DataLayer.Models;
namespace Form113TestUnit
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// This test check if the giveMeList Method return a list with the type of command
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            var ListToTest = Commande.giveMeList();
           
            foreach (var item in ListToTest)
            {
                var commandeFirst = new Commande(item);
                break;
            }

            var typeToCheck = ListToTest.GetType();
            Assert.AreEqual(commandeFirst.Nom,"NomTest");
        }
    }
}
