using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.MSTest
{
    [TestClass]
    public class DataObjectTest
    {
        [TestMethod]
        public void Test()
        {
            {
                DataObject dataObject = new DataObject();
                dataObject.Add(1, DataValue.DoubleQuotationString("1"));
                Assert.AreEqual(1, dataObject.DataItemMap.Count);
            }

            {
                DataObject dataObject = new DataObject();
                dataObject.AddDataValue(1, DataValue.DoubleQuotationString("1"));
                Assert.AreEqual(1, dataObject.DataItemMap.Count);
            }

            {
                DataObject dataObject = new DataObject();
                dataObject.AddDataValue(1);
                Assert.AreEqual(1, dataObject.DataItemMap.Count);
            }

            {
                DataObject dataObject = new DataObject();
                dataObject.AddDataArray(1, new DataArray());
                Assert.AreEqual(1, dataObject.DataItemMap.Count);
            }

            {
                DataObject dataObject = new DataObject();
                dataObject.AddDataArray(1);
                Assert.AreEqual(1, dataObject.DataItemMap.Count);
            }

            {
                DataObject dataObject = new DataObject();
                dataObject.AddDataObject(1, new DataObject());
                Assert.AreEqual(1, dataObject.DataItemMap.Count);
            }

            {
                DataObject dataObject = new DataObject();
                dataObject.AddDataObject(1);
                Assert.AreEqual(1, dataObject.DataItemMap.Count);
            }

            {
                DataObject dataObject = new DataObject();
                dataObject.AddSortedDataObject(1, new SortedDataObject());
                Assert.AreEqual(1, dataObject.DataItemMap.Count);
            }

            {
                DataObject dataObject = new DataObject();
                dataObject.AddSortedDataObject(1);
                Assert.AreEqual(1, dataObject.DataItemMap.Count);
            }
        }
    }
}
