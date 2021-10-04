using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calc.Lib;

namespace Calculadora
{
    [TestClass]
    public class Calculos_Teste
    {
        [TestMethod]
        public void Quando_Somar_PrimeiroValor_10_SegundoValor_2_ResultadoEsperado_12()
        {
            //Preparar
            Calculos obj = new Calculos();

            //Executar (exercitar)
            decimal resultado = obj.EfetuarCalculo(10, 2, '+');

            //Verificar
            Assert.AreEqual(12, resultado);
        }

        [TestMethod]
        public void Quando_Somar_PrimeiroValor_NEG3_SegundoValor_NEG5_ResultadoEsperado_NEG8()
        {
            //Preparar
            Calculos obj = new Calculos();

            //Executar (exercitar)
            decimal resultado = obj.EfetuarCalculo(-3, -5, '+');

            //Verificar
            Assert.AreEqual(-8, resultado);
        }

        [TestMethod]
        public void Quando_Somar_PrimeiroValor_10_SegundoValor_NEG3_ResultadoEsperado_7()
        {
            //Preparar
            Calculos obj = new Calculos();

            //Executar (exercitar)
            decimal resultado = obj.EfetuarCalculo(10, -3, '+');

            //Verificar
            Assert.AreEqual(7, resultado);
        }

        [TestMethod]
        public void Quando_Somar_PrimeiroValor_NEG5_SegundoValor_18_ResultadoEsperado_13()
        {
            //Preparar
            Calculos obj = new Calculos();

            //Executar (exercitar)
            decimal resultado = obj.EfetuarCalculo(-5, 18, '+');

            //Verificar
            Assert.AreEqual(13, resultado);
        }

        [TestMethod]
        public void Quando_Somar_PrimeiroValor_0_SegundoValor_9_ResultadoEsperado_9()
        {
            //Preparar
            Calculos obj = new Calculos();

            //Executar (exercitar)
            decimal resultado = obj.EfetuarCalculo(0, 9, '+');

            //Verificar
            Assert.AreEqual(9, resultado);
        }

        [TestMethod]
        public void Quando_Somar_PrimeiroValor_9_SegundoValor_0_ResultadoEsperado_9()
        {
            //Preparar
            Calculos obj = new Calculos();

            //Executar (exercitar)
            decimal resultado = obj.EfetuarCalculo(9, 0, '+');

            //Verificar
            Assert.AreEqual(9, resultado);
        }

        [TestMethod]
        public void Quando_Subtrair_PrimeiroValor_10_SegundoValor_2_ResultadoEsperado_8()
        {
            //Preparar
            Calculos obj = new Calculos();

            //Executar (exercitar)
            decimal resultado = obj.EfetuarCalculo(10, 2, '-');

            //Verificar
            Assert.AreEqual(8, resultado);
        }

        [TestMethod]
        public void Quando_Subtrair_PrimeiroValor_NEG3_SegundoValor_NEG5_ResultadoEsperado_2()
        {
            //Preparar
            Calculos obj = new Calculos();

            //Executar (exercitar)
            decimal resultado = obj.EfetuarCalculo(-3, -5, '-');

            //Verificar
            Assert.AreEqual(2, resultado);
        }

        [TestMethod]
        public void Quando_Subtrair_PrimeiroValor_10_SegundoValor_NEG3_ResultadoEsperado_13()
        {
            //Preparar
            Calculos obj = new Calculos();

            //Executar (exercitar)
            decimal resultado = obj.EfetuarCalculo(10, -3, '-');

            //Verificar
            Assert.AreEqual(13, resultado);
        }

        [TestMethod]
        public void Quando_Subtrair_PrimeiroValor_NEG5_SegundoValor_18_ResultadoEsperado_23()
        {
            //Preparar
            Calculos obj = new Calculos();

            //Executar (exercitar)
            decimal resultado = obj.EfetuarCalculo(-5, 18, '-');

            //Verificar
            Assert.AreEqual(-23, resultado);
        }

        [TestMethod]
        public void Quando_Subtrair_PrimeiroValor_0_SegundoValor_9_ResultadoEsperado_NEG9()
        {
            //Preparar
            Calculos obj = new Calculos();

            //Executar (exercitar)
            decimal resultado = obj.EfetuarCalculo(0, 9, '-');

            //Verificar
            Assert.AreEqual(-9, resultado);
        }

        [TestMethod]
        public void Quando_Subtrair_PrimeiroValor_9_SegundoValor_0_ResultadoEsperado_9()
        {
            //Preparar
            Calculos obj = new Calculos();

            //Executar (exercitar)
            decimal resultado = obj.EfetuarCalculo(9, 0, '-');

            //Verificar
            Assert.AreEqual(9, resultado);
        }

        [TestMethod]
        public void Quando_Multiplicar_PrimeiroValor_10_SegundoValor_2_ResultadoEsperado_20()
        {
            //Preparar
            Calculos obj = new Calculos();

            //Executar (exercitar)
            decimal resultado = obj.EfetuarCalculo(10, 2, '*');

            //Verificar
            Assert.AreEqual(20, resultado);
        }

        [TestMethod]
        public void Quando_Multiplicar_PrimeiroValor_NEG3_SegundoValor_NEG5_ResultadoEsperado_NEG15()
        {
            //Preparar
            Calculos obj = new Calculos();

            //Executar (exercitar)
            decimal resultado = obj.EfetuarCalculo(-3, -5, '*');

            //Verificar
            Assert.AreEqual(15, resultado);
        }

        [TestMethod]
        public void Quando_Multiplicar_PrimeiroValor_10_SegundoValor_NEG3_ResultadoEsperado_NEG30()
        {
            //Preparar
            Calculos obj = new Calculos();

            //Executar (exercitar)
            decimal resultado = obj.EfetuarCalculo(10, -3, '*');

            //Verificar
            Assert.AreEqual(-30, resultado);
        }

        [TestMethod]
        public void Quando_Multiplicar_PrimeiroValor_NEG5_SegundoValor_18_ResultadoEsperado_NEG90()
        {
            //Preparar
            Calculos obj = new Calculos();

            //Executar (exercitar)
            decimal resultado = obj.EfetuarCalculo(-5, 18, '*');

            //Verificar
            Assert.AreEqual(-90, resultado);
        }

        [TestMethod]
        public void Quando_Multiplicar_PrimeiroValor_0_SegundoValor_9_ResultadoEsperado_NEG9()
        {
            //Preparar
            Calculos obj = new Calculos();

            //Executar (exercitar)
            decimal resultado = obj.EfetuarCalculo(0, 9, '*');

            //Verificar
            Assert.AreEqual(0, resultado);
        }

        [TestMethod]
        public void Quando_Multiplicar_PrimeiroValor_9_SegundoValor_0_ResultadoEsperado_9()
        {
            //Preparar
            Calculos obj = new Calculos();

            //Executar (exercitar)
            decimal resultado = obj.EfetuarCalculo(9, 0, '*');

            //Verificar
            Assert.AreEqual(0, resultado);
        }

        [TestMethod]
        public void Quando_Dividir_PrimeiroValor_10_SegundoValor_2_ResultadoEsperado_5()
        {
            //Preparar
            Calculos obj = new Calculos();

            //Executar (exercitar)
            decimal resultado = obj.EfetuarCalculo(10, 2, '/');

            //Verificar
            Assert.AreEqual(5, resultado);
        }

        [TestMethod]
        public void Quando_Dividir_PrimeiroValor_NEG3_SegundoValor_NEG5_ResultadoEsperado_0PONTO6()
        {
            //Preparar
            Calculos obj = new Calculos();

            //Executar (exercitar)
            decimal resultado = obj.EfetuarCalculo(-3, -5, '/');

            //Verificar
            Assert.AreEqual(0.6m, resultado);
        }

        [TestMethod]
        public void Quando_Dividir_PrimeiroValor_10_SegundoValor_NEG5_ResultadoEsperado_NEG2()
        {
            //Preparar
            Calculos obj = new Calculos();

            //Executar (exercitar)
            decimal resultado = obj.EfetuarCalculo(10, -5, '/');

            //Verificar
            Assert.AreEqual(-2, resultado);
        }

        [TestMethod]
        public void Quando_Dividir_PrimeiroValor_NEG5_SegundoValor_20_ResultadoEsperado_NEG0PONTO25()
        {
            //Preparar
            Calculos obj = new Calculos();

            //Executar (exercitar)
            decimal resultado = obj.EfetuarCalculo(-5, 20, '/');

            //Verificar
            Assert.AreEqual(-0.25m, resultado);
        }

        [TestMethod]
        public void Quando_Dividir_PrimeiroValor_0_SegundoValor_9_ResultadoEsperado_NEG9()
        {
            //Preparar
            Calculos obj = new Calculos();

            //Executar (exercitar)
            decimal resultado = obj.EfetuarCalculo(0, 9, '/');

            //Verificar
            Assert.AreEqual(0, resultado);
        }

        [TestMethod]
        public void Quando_Dividir_PrimeiroValor_9_SegundoValor_0_ResultadoEsperado_0()
        {
            //Preparar
            Calculos obj = new Calculos();

            //Executar (exercitar)
            decimal resultado = obj.EfetuarCalculo(9, 0, '/');

            //Verificar
            Assert.AreEqual(0, resultado);
        }
    }
}
