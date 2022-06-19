using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Pruebas
{
    [TestClass]
    public class ManejadorDeDatosTest
    {
        [TestMethod]
        public  void PasarStringNumeros_CuandoElStringEsEntero_DeberiaRetornarTrue()
        {

            string texto = "123";
            bool resultadoEsperado = true;
            bool resultado = ManejadorDeDatos.PasarStringNumeros(texto, out int numero);

            Assert.IsTrue(resultado == resultadoEsperado);


        }

        [TestMethod]
        public  void PasarStringNumeros_CuandoElStringEsUnTexto_DeberiaRetornarFalse()
        {

            string texto = "asdasd";
            bool resultadoEsperado = false;
            bool resultado = ManejadorDeDatos.PasarStringNumeros(texto, out int numero);
            Assert.AreEqual(resultadoEsperado, resultado);

        }

    }
}
