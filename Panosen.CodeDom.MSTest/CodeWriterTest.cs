using Microsoft.VisualStudio.TestTools.UnitTesting;
using Panosen.CodeDom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.MSTest
{
    [TestClass()]
    public class CodeWriterTest
    {
        [TestMethod()]
        public void Test()
        {
            var builder = new StringBuilder();

            CodeWriter codeWriter = builder;

            codeWriter.Write("1");
            codeWriter.WriteLine("2");
            codeWriter.WriteLine();

            codeWriter.WriteLine("3");

            var expected = @"12

3
";
            var actual = builder.ToString();

            Assert.AreEqual(expected, actual);
        }
    }
}