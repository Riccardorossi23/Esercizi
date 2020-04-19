using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_esercizi
{
    [TestClass]
    public class test
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] v1 = new int[6] { 4, 7, 8, 2, 5, 9 };
            int[] v2 = new int[6] { 2, 4, 5, 7, 8, 9 };
            int[] ordinato = Esercizi.Array.array(v1);
            CollectionAssert.AreEquivalent(v2, ordinato);

        }
        [TestMethod]
        public void TestMethod2()
        {
            int[] v1 = new int[6] { 4, 7, 8, 2, 5, 9 };
            int[] ordinato = Esercizi.Array.array(v1);
            Assert.IsNotNull(ordinato);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int[] v1 = new int[6] { 4, 7, 8, 2, 5, 9 };
            int lenght = 6;
            int[] ordinato = Esercizi.Array.array(v1);
            Assert.IsTrue(ordinato.Length==lenght);
        }
        [TestMethod]
        public void TestMethod4()
        {
            int[] v1 = new int[6] { a, i, t, s, b, t };
            int[] v2 = new int[6] { 2, 4, 5, 7, 8, 9 };
            int[] ordinato = Esercizi.Array.ContainsDoubleChar(v1);
            CollectionAssert.AreEquivalent(v2, ordinato);


        }

    }
}
