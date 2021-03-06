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
            {
                DataKey one = 1;
                Assert.AreEqual("1".GetHashCode(), one.GetHashCode());
            }

            {
                DataKey one = new DataKey();
                Assert.AreEqual(0, one.GetHashCode());
            }
        }


        [TestMethod]
        public void CompareToTest()
        {
            {
                var expected = 1.CompareTo(2);

                DataKey one = 1;
                DataKey two = 2;
                var actual = one.CompareTo(two);

                Assert.AreEqual(expected, actual);
            }

            {
                DataKey one = 1;
                DataKey two = null;
                var actual = one.CompareTo(two);

                Assert.AreEqual(1, actual);
            }

            {
                DataKey one = new DataKey();
                DataKey two = new DataKey();
                var actual = one.CompareTo(two);

                Assert.AreEqual(0, actual);
            }
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
            {
                DataKey left = null;
                DataKey right = "1";
                Assert.IsFalse(left > right);
            }
            {
                DataKey left = new DataKey();
                DataKey right = "1";
                Assert.IsFalse(left > right);
            }

            {
                DataKey left = 2;
                DataKey right = null;
                Assert.IsTrue(left > right);
            }
            {
                DataKey left = 2;
                DataKey right = new DataKey();
                Assert.IsTrue(left > right);
            }

            {
                DataKey left = 2;
                DataKey right = "1";
                Assert.IsTrue(left > right);
            }

            {
                DataKey left = DataKey.DoubleQuotationString("a_b");
                DataKey right = DataKey.DoubleQuotationString("a");
                Assert.IsTrue(left > right);
            }
        }

        [TestMethod]
        public void TestOperatorLessThan()
        {
            {
                DataKey left = null;
                DataKey right = "1";
                Assert.IsTrue(left < right);
            }
            {
                DataKey left = new DataKey();
                DataKey right = "1";
                Assert.IsTrue(left < right);
            }

            {
                DataKey left = 2;
                DataKey right = null;
                Assert.IsFalse(left < right);
            }
            {
                DataKey left = 2;
                DataKey right = new DataKey();
                Assert.IsFalse(left < right);
            }

            {
                DataKey left = 2;
                DataKey right = "1";
                Assert.IsFalse(left < right);
            }

            {
                DataKey left = DataKey.DoubleQuotationString("a");
                DataKey right = DataKey.DoubleQuotationString("a_b");
                Assert.IsTrue(left < right);
            }
        }

        [TestMethod]
        public void TestOperatorNotEqualsTo()
        {
            DataKey left = 2;
            DataKey right = "1";

            Assert.IsTrue(left != right);
        }

        [TestMethod]
        public void TestOperatorGreaterEqualsThan()
        {
            {
                DataKey left = 2;
                DataKey right = "1";
                Assert.IsTrue(left >= right);
            }
            {
                DataKey left = 1;
                DataKey right = "1";
                Assert.IsTrue(left >= right);
            }
        }

        [TestMethod]
        public void TestOperatorLessEqualsThan()
        {
            {
                DataKey left = "1";
                DataKey right = 2;
                Assert.IsTrue(left <= right);
            }
            {
                DataKey left = 1;
                DataKey right = "1";
                Assert.IsTrue(left <= right);
            }
        }
    }
}
