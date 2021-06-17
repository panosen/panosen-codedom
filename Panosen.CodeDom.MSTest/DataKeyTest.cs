using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Panosen.CodeDom.MSTest
{
    [TestClass]
    public class DataKeyTest
    {
        [TestMethod]
        public void FromInt()
        {
            DataKey dataKey = 1;

            Assert.AreEqual("1", dataKey.Value);
        }

        [TestMethod]
        public void FromLong()
        {
            DataKey dataKey = 1L;

            Assert.AreEqual("1", dataKey.Value);
        }

        [TestMethod]
        public void FromString()
        {
            DataKey dataKey = "1";

            Assert.AreEqual("1", dataKey.Value);
        }


        [TestMethod]
        public void SingleQuotationString()
        {
            DataKey dataKey = DataKey.SingleQuotationString("1");

            Assert.AreEqual("'1'", dataKey.Value);
        }


        [TestMethod]
        public void DoubleQuotationString()
        {
            DataKey dataKey = DataKey.DoubleQuotationString("1");

            Assert.AreEqual("\"1\"", dataKey.Value);
        }

        [TestMethod]
        public void EqualsTest()
        {
            DataKey one = "1";
            DataKey other = 1;

            Assert.AreEqual(one, other);
        }

        [TestMethod]
        public void GetHashCodeTest()
        {
            DataKey one = 1;
            Assert.AreEqual("1".GetHashCode(), one.GetHashCode());
        }
    }
}
