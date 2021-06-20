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


        [TestMethod]
        public void CompareToTest()
        {
            var expected = 1.CompareTo(2);

            DataKey one = 1;
            DataKey two = 2;
            var actual = one.CompareTo(two);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestOperatorEqualsTo()
        {
            DataKey left = 1;

            DataKey right = "1";

            var actual = left == right;

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void TestOperatorGreaterThan()
        {
            DataKey left = 2;

            DataKey right = "1";

            var actual = left > right;

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void TestOperatorLessThan()
        {
            DataKey left = 1;

            DataKey right = "2";

            var actual = left < right;

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void TestOperatorNotEqualsTo()
        {
            DataKey left = 2;

            DataKey right = "1";

            var actual = left != right;

            Assert.IsTrue(actual);
        }
    }
}
