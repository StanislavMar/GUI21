using Microsoft.VisualStudio.TestTools.UnitTesting;
using GUI21;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI21.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void LongStrTest1()
        {
            var str = "yy gg";
            var pr = Logic.LongStr(str);
            Assert.AreEqual("yy=2\ngg=2\n", pr);
        }
        [TestMethod()]
        public void LongStrTest2()
        {
            var str = "yhhy g11g";
            var pr = Logic.LongStr(str);
            Assert.AreEqual("hh=2\n11=2\n", pr);
        }
        [TestMethod()]
        public void LongStrTest3()
        {
            var str = "yyhh ggg";
            var pr = Logic.LongStr(str);
            Assert.AreEqual("yy=2\nhh=2\nggg=3\n", pr);
        }
        [TestMethod()]
        public void LongStrTest4()
        {
            var str = "";
            var pr = Logic.LongStr(str);
            Assert.AreEqual("Соседних одинаковых букв не найдено", pr);
        }
    }
}