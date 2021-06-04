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
    public class DataObject : DataItem
    {
        /// <summary>
        /// 每一个项是一个 DataValue 或 DataArray 或 DataObject
        /// </summary>
        public Dictionary<DataKey, DataItem> DataItemMap { get; set; }
    }


    /// <summary>
    /// DataObject 扩展
    /// </summary>
    public static class DataObjectExtension
    {
        /// <summary>
        /// 添加一项
        /// </summary>
        public static TDataObject Add<TDataObject>(this TDataObject dataObject, DataKey dataKey, DataItem dataItem)
            where TDataObject : DataObject
        {
            if (dataObject.DataItemMap == null)
            {
                dataObject.DataItemMap = new Dictionary<DataKey, DataItem>();
            }

            dataObject.DataItemMap.Add(dataKey, dataItem);

            return dataObject;
        }

        /// <summary>
        /// 添加一个值对象
        /// </summary>
        public static TDataObject AddDataValue<TDataObject>(this TDataObject dataObject, DataKey dataKey, DataValue dataValue)
            where TDataObject : DataObject
        {
            return Add(dataObject, dataKey, dataValue);
        }

        /// <summary>
        /// 添加一个值对象，并返回该值对象
        /// </summary>
        public static DataValue AddDataValue(this DataObject dataObject, DataKey dataKey)
        {
            if (dataObject.DataItemMap == null)
            {
                dataObject.DataItemMap = new Dictionary<DataKey, DataItem>();
            }

            DataValue dataValue = new DataValue();

            dataObject.DataItemMap.Add(dataKey, dataValue);

            return dataValue;
        }

        /// <summary>
        /// 添加一个数组
        /// </summary>
        public static TDataObject AddDataArray<TDataObject>(this TDataObject dataObject, DataKey dataKey, DataArray dataArray)
            where TDataObject : DataObject
        {
            return Add(dataObject, dataKey, dataArray);
        }

        /// <summary>
        /// 添加一个数组，并返回该数组
        /// </summary>
        public static DataArray AddDataArray(this DataObject dataObject, DataKey dataKey)
        {
            if (dataObject.DataItemMap == null)
            {
                dataObject.DataItemMap = new Dictionary<DataKey, DataItem>();
            }

            DataArray dataArray = new DataArray();

            dataObject.DataItemMap.Add(dataKey, dataArray);

            return dataArray;
        }

        /// <summary>
        /// 添加一个对象
        /// </summary>
        public static TDataObject AddDataObject<TDataObject>(this TDataObject dataObject, DataKey dataKey, DataObject subDataObject)
            where TDataObject : DataObject
        {
            return Add(dataObject, dataKey, subDataObject);
        }

        /// <summary>
        /// 添加一个对象，并返回该对象
        /// </summary>
        public static DataObject AddDataObject(this DataObject dataObject, DataKey dataKey)
        {
            if (dataObject.DataItemMap == null)
            {
                dataObject.DataItemMap = new Dictionary<DataKey, DataItem>();
            }

            DataObject subDataObject = new DataObject();

            dataObject.DataItemMap.Add(dataKey, subDataObject);

            return subDataObject;
        }

        /// <summary>
        /// 添加一个对象
        /// </summary>
        public static TDataObject AddSortedDataObject<TDataObject>(this TDataObject dataObject, DataKey dataKey, SortedDataObject subSortedDataObject)
            where TDataObject : DataObject
        {
            return Add(dataObject, dataKey, subSortedDataObject);
        }

        /// <summary>
        /// 添加一个对象，并返回该对象
        /// </summary>
        public static SortedDataObject AddSortedDataObject(this DataObject dataObject, DataKey dataKey)
        {
            if (dataObject.DataItemMap == null)
            {
                dataObject.DataItemMap = new Dictionary<DataKey, DataItem>();
            }

            SortedDataObject subSortedDataObject = new SortedDataObject();

            dataObject.DataItemMap.Add(dataKey, subSortedDataObject);

            return subSortedDataObject;
        }
    }
}
