using Atividade_PO1;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSomaNumero()
        {
            int num1 = 10;
            int num2 = 20;
            SomaDoisNumeros soma = new SomaDoisNumeros();

            int resultado = (int)soma.Calcular(num1,num2);

            Assert.AreEqual(30, resultado);
        }
    }
}