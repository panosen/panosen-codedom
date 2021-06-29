using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.MSTest
{
    [TestClass]
    public class DataValueTest
    {
        [TestMethod]
        public void Test()
        {
            {
                DataValue dataValue = true;
                Assert.AreEqual("true", dataValue.Value);
            }

            {
                DataValue dataValue = 1;
                Assert.AreEqual("1", dataValue.Value);
            }

            {
                DataValue dataValue = (uint)1;
                Assert.AreEqual("1", dataValue.Value);
            }

            {
                DataValue dataValue = 1L;
                Assert.AreEqual("1", dataValue.Value);
            }

            {
                DataValue dataValue = "1";
                Assert.AreEqual("1", dataValue.Value);
            }

            {
                DataValue dataValue = DataValue.SingleQuotationString("1");
                Assert.AreEqual("'1'", dataValue.Value);
            }

            {
                DataValue dataValue = DataValue.DoubleQuotationString("1");
                Assert.AreEqual("\"1\"", dataValue.Value);
            }

            {
                DataValue dataValue = new DataValue();
                dataValue.SetValue(true);
                Assert.AreEqual("true", dataValue.Value);
            }

            {
                DataValue dataValue = new DataValue();
                dataValue.SetValue(1);
                Assert.AreEqual("1", dataValue.Value);
            }

            {
                DataValue dataValue = new DataValue();
                dataValue.SetValue(1L);
                Assert.AreEqual("1", dataValue.Value);
            }

            {
                DataValue dataValue = new DataValue();
                dataValue.SetValue("1", singleQuotation: true);
                Assert.AreEqual("'1'", dataValue.Value);
            }

            {
                DataValue dataValue = new DataValue();
                dataValue.SetValue("1", doubleQuotation: true);
                Assert.AreEqual("\"1\"", dataValue.Value);
            }

            {
                DataValue dataValue = new DataValue();
                dataValue.SetValue("1");
                Assert.AreEqual("1", dataValue.Value);
            }
        }
    }
}
