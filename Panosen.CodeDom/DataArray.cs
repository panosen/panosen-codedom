using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom
{
    /// <summary>
    /// 数组
    /// </summary>
    public class DataArray : DataItem
    {
        /// <summary>
        /// 数组项
        /// </summary>
        public List<DataItem> Items { get; set; }
    }

    /// <summary>
    /// 扩展方法
    /// </summary>
    public static class DataArrayExtension
    {
        /// <summary>
        /// AddDataValue
        /// </summary>
        public static DataArray AddDataValue(this DataArray dataArray, DataValue dataValue)
        {
            if (dataArray.Items == null)
            {
                dataArray.Items = new List<DataItem>();
            }

            dataArray.Items.Add(dataValue);

            return dataArray;
        }

        /// <summary>
        /// AddDataObject
        /// </summary>
        public static DataArray AddDataObject(this DataArray dataArray, DataObject dataObject)
        {
            if (dataArray.Items == null)
            {
                dataArray.Items = new List<DataItem>();
            }

            dataArray.Items.Add(dataObject);

            return dataArray;
        }

        /// <summary>
        /// AddDataObject
        /// </summary>
        public static DataObject AddDataObject(this DataArray dataArray)
        {
            if (dataArray.Items == null)
            {
                dataArray.Items = new List<DataItem>();
            }

            DataObject dataObject = new DataObject();

            dataArray.Items.Add(dataObject);

            return dataObject;
        }

        /// <summary>
        /// AddSortedDataObject
        /// </summary>
        public static DataArray AddSortedDataObject(this DataArray dataArray, SortedDataObject sortedDataObject)
        {
            if (dataArray.Items == null)
            {
                dataArray.Items = new List<DataItem>();
            }

            dataArray.Items.Add(sortedDataObject);

            return dataArray;
        }

        /// <summary>
        /// AddSortedDataObject
        /// </summary>
        /// <param name="dataArray"></param>
        /// <returns></returns>
        public static SortedDataObject AddSortedDataObject(this DataArray dataArray)
        {
            if (dataArray.Items == null)
            {
                dataArray.Items = new List<DataItem>();
            }

            SortedDataObject sortedDataObject = new SortedDataObject();

            dataArray.Items.Add(sortedDataObject);

            return sortedDataObject;
        }

        /// <summary>
        /// AddRange
        /// </summary>
        public static DataArray AddRange<TDataItem>(this DataArray dataArray, List<TDataItem> items) where TDataItem : DataItem
        {
            if (items == null || items.Count == 0)
            {
                return dataArray;
            }

            if (dataArray.Items == null)
            {
                dataArray.Items = new List<DataItem>();
            }

            dataArray.Items.AddRange(items);

            return dataArray;
        }
    }
}
