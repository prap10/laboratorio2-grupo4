using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejemplo.Model;
using System.Collections.Generic;
using System.Linq;

namespace Ejemplo.Tests
{
    [TestClass]
    public class Products
    {
        [TestMethod]
        public void ConsultarProductosNegros()
        {
            // definir el escenario de la prueba
            string miColor = "Black";
            int valorEsperado = 93;
            // repositorio
            var repositorio = new Ejemplo.BL.Repositorios.ProductRepository ();

            // invocar al método correspondiente
            var listado = repositorio.GetAllByColor(miColor).ToList();
            var cantidad = listado.Count();

            // compare
            Assert.AreEqual(valorEsperado, cantidad);
        }
    }
}
