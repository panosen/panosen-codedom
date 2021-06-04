using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom
{
    /// <summary>
    /// 对象
    /// </summary>
    public class SortedDataObject : DataItem
    {
        /// <summary>
        /// 每一个项是一个 DataValue 或 DataArray 或 DataObject
        /// </summary>
        public SortedDictionary<DataKey, DataItem> DataItemMap { get; set; }
    }

    /// <summary>
    /// DataObject 扩展
    /// </summary>
    public static class SortedDataObjectExtension
    {
        /// <summary>
        /// 添加一项
        /// </summary>
        public static TSortedDataObject Add<TSortedDataObject>(this TSortedDataObject dataObject, DataKey dataKey, DataItem dataItem)
            where TSortedDataObject : SortedDataObject
        {
            if (dataObject.DataItemMap == null)
            {
                dataObject.DataItemMap = new SortedDictionary<DataKey, DataItem>();
            }

            dataObject.DataItemMap.Add(dataKey, dataItem);

            return dataObject;
        }

        /// <summary>
        /// 添加一个值对象
        /// </summary>
        public static TSortedDataObject AddDataValue<TSortedDataObject>(this TSortedDataObject sortedDataObject, DataKey dataKey, DataValue dataValue)
            where TSortedDataObject : SortedDataObject
        {
            return Add(sortedDataObject, dataKey, dataValue);
        }

        /// <summary>
        /// 添加一个值对象，并返回该值对象
        /// </summary>
        public static DataValue AddDataValue(this SortedDataObject dataObject, DataKey dataKey)
        {
            if (dataObject.DataItemMap == null)
            {
                dataObject.DataItemMap = new SortedDictionary<DataKey, DataItem>();
            }

            DataValue dataValue = new DataValue();

            dataObject.DataItemMap.Add(dataKey, dataValue);

            return dataValue;
        }

        /// <summary>
        /// 添加一个数组
        /// </summary>
        public static TSortedDataObject AddDataArray<TSortedDataObject>(this TSortedDataObject sortedDataObject, DataKey dataKey, DataArray dataArray)
            where TSortedDataObject : SortedDataObject
        {
            return Add(sortedDataObject, dataKey, dataArray);
        }

        /// <summary>
        /// 添加一个数组，并返回该数组
        /// </summary>
        public static DataArray AddDataArray(this SortedDataObject dataObject, DataKey dataKey)
        {
            if (dataObject.DataItemMap == null)
            {
                dataObject.DataItemMap = new SortedDictionary<DataKey, DataItem>();
            }

            DataArray dataArray = new DataArray();

            dataObject.DataItemMap.Add(dataKey, dataArray);

            return dataArray;
        }

        /// <summary>
        /// 添加一个对象
        /// </summary>
        public static TSortedDataObject AddDataObject<TSortedDataObject>(this TSortedDataObject sortedDataObject, DataKey dataKey, DataObject subDataObject)
            where TSortedDataObject : SortedDataObject
        {
            return Add(sortedDataObject, dataKey, subDataObject);
        }

        /// <summary>
        /// 添加一个对象，并返回该对象
        /// </summary>
        public static DataObject AddDataObject(this SortedDataObject dataObject, DataKey dataKey)
        {
            if (dataObject.DataItemMap == null)
            {
                dataObject.DataItemMap = new SortedDictionary<DataKey, DataItem>();
            }

            DataObject subDataObject = new DataObject();

            dataObject.DataItemMap.Add(dataKey, subDataObject);

            return subDataObject;
        }

        /// <summary>
        /// 添加一个对象
        /// </summary>
        public static TSortedDataObject AddSortedDataObject<TSortedDataObject>(this TSortedDataObject sortedDataObject, DataKey dataKey, SortedDataObject subSortedDataObject)
            where TSortedDataObject : SortedDataObject
        {
            return Add(sortedDataObject, dataKey, subSortedDataObject);
        }

        /// <summary>
        /// 添加一个对象，并返回该对象
        /// </summary>
        public static SortedDataObject AddSortedDataObject(this SortedDataObject dataObject, DataKey dataKey)
        {
            if (dataObject.DataItemMap == null)
            {
                dataObject.DataItemMap = new SortedDictionary<DataKey, DataItem>();
            }

            SortedDataObject subSortedDataObject = new SortedDataObject();

            dataObject.DataItemMap.Add(dataKey, subSortedDataObject);

            return subSortedDataObject;
        }
    }
}
