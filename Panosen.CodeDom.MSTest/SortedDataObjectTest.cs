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
        }
    }
}
