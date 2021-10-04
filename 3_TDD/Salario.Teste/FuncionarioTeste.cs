using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Salario.Teste
{
    [TestClass]
    public class FuncionarioTeste
    {
        [TestMethod]
        public void Quando_Dev_Bruto_3000_Liquido_2700()
        {
            //Arrange
            var func = new Funcionario();

            //Act
            var liquido = func.CalculaSalario("DEV", 3000);

            //Assert
            Assert.AreEqual(2700, liquido);
        }

        [TestMethod]
        public void Quando_Dev_Bruto_10000_Liquido_8000()
        {
            //Arrange
            var func = new Funcionario();

            //Act
            var liquido = func.CalculaSalario("DEV", 10000);

            //Assert
            Assert.AreEqual(8000, liquido);
        }
    }
}
