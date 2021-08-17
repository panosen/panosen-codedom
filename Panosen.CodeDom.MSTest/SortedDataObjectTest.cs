using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.MSTest
{
    [TestClass]
    public class SortedDataObjectTest
    {
        [TestMethod]
        public void Test()
        {
            {
                SortedDataObject sortedDataObject = new SortedDataObject();
                sortedDataObject.Add(1, (DataValue)1);
                Assert.AreEqual(1, sortedDataObject.DataItemMap.Count);
            }

            {
                SortedDataObject sortedDataObject = new SortedDataObject();
                sortedDataObject.AddDataValue(1, (DataValue)1);
                Assert.AreEqual(1, sortedDataObject.DataItemMap.Count);
            }

            {
                SortedDataObject sortedDataObject = new SortedDataObject();
                sortedDataObject.AddDataValue(1);
                Assert.AreEqual(1, sortedDataObject.DataItemMap.Count);
            }

            {
                SortedDataObject sortedDataObject = new SortedDataObject();
                sortedDataObject.AddDataArray(1, new DataArray());
                Assert.AreEqual(1, sortedDataObject.DataItemMap.Count);
            }

            {
                SortedDataObject sortedDataObject = new SortedDataObject();
                sortedDataObject.AddDataArray(1);
                Assert.AreEqual(1, sortedDataObject.DataItemMap.Count);
            }

            {
                SortedDataObject sortedDataObject = new SortedDataObject();
                sortedDataObject.AddDataObject(1, new DataObject());
                Assert.AreEqual(1, sortedDataObject.DataItemMap.Count);
            }

            {
                SortedDataObject sortedDataObject = new SortedDataObject();
                sortedDataObject.AddDataObject(1);
                Assert.AreEqual(1, sortedDataObject.DataItemMap.Count);
            }

            {
                SortedDataObject sortedDataObject = new SortedDataObject();
                sortedDataObject.AddSortedDataObject(1, new SortedDataObject());
                Assert.AreEqual(1, sortedDataObject.DataItemMap.Count);
            }

            {
                SortedDataObject sortedDataObject = new SortedDataObject();
                sortedDataObject.AddSortedDataObject(1);
                Assert.AreEqual(1, sortedDataObject.DataItemMap.Count);
            }

            {
                SortedDataObject sortedDataObject = new SortedDataObject();
                sortedDataObject.AddDataValue("\"abc\"", "abc");
                sortedDataObject.AddDataValue("\"abc_def\"", "abc_def");
                Assert.AreEqual(2, sortedDataObject.DataItemMap.Count);

                var enumerator = sortedDataObject.DataItemMap.GetEnumerator();

                enumerator.MoveNext();
                Assert.AreEqual("\"abc\"", enumerator.Current.Key.Value);
                Assert.AreEqual("abc", ((DataValue)enumerator.Current.Value).Value);

                enumerator.MoveNext();
                Assert.AreEqual("\"abc_def\"", enumerator.Current.Key.Value);
                Assert.AreEqual("abc_def", ((DataValue)enumerator.Current.Value).Value);
            }
        }
    }
}
