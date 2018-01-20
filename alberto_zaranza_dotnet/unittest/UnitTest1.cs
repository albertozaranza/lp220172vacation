using Microsoft.VisualStudio.TestTools.UnitTesting;

using bll;

namespace unittest
{
    [TestClass]
    public class UnitTest1
    {
        private readonly Operacao operacao = new Operacao();

        [TestMethod]
        public void TestMethod1()
        {
            operacao.Somar(a:1, b:2);
            operacao.Subtrair(a:1,b:2);
            operacao.Multiplicar(a:1,b:2);
            operacao.Dividir(a:1,b:2);
        }
    }
}
