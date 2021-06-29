using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.MSTest
{
    [TestClass]
    public class DataArrayTest
    {
        [TestMethod]
        public void Test()
        {
            {
                var dataArray = new DataArray();
                dataArray.AddDataValue(1);
                Assert.AreEqual(1, dataArray.Items.Count);
            }

            {
                var dataArray = new DataArray();
                dataArray.AddDataObject(new DataObject());
                Assert.AreEqual(1, dataArray.Items.Count);
            }

            {
                var dataArray = new DataArray();
                var dataObject = dataArray.AddDataObject();
                Assert.IsNotNull(dataObject);
            }

            {
                var dataArray = new DataArray();
                dataArray.AddSortedDataObject(new SortedDataObject());
                Assert.AreEqual(1, dataArray.Items.Count);
            }

            {
                var dataArray = new DataArray();
                var dataObject = dataArray.AddSortedDataObject();
                Assert.IsNotNull(dataObject);
            }

            {
                var dataArray = new DataArray();

                List<DataValue> items = new List<DataValue>();
                dataArray.AddRange(items);

                items.Add(1);
                dataArray.AddRange(items);

                Assert.AreEqual(1, dataArray.Items.Count);
            }
        }
    }
}
