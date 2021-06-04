using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom
{
    /// <summary>
    /// 值
    /// </summary>
    public class DataValue : DataItem
    {
        /// <summary>
        /// 值
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// bool
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DataValue(bool value)
        {
            var dataValue = new DataValue();
            dataValue.Value = value ? "true" : "false";
            return dataValue;
        }

        /// <summary>
        /// int
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DataValue(int value)
        {
            var dataValue = new DataValue();
            dataValue.Value = value.ToString();
            return dataValue;
        }

        /// <summary>
        /// uint
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DataValue(uint value)
        {
            var dataValue = new DataValue();
            dataValue.Value = value.ToString();
            return dataValue;
        }

        /// <summary>
        /// long
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DataValue(long value)
        {
            var dataValue = new DataValue();
            dataValue.Value = value.ToString();
            return dataValue;
        }

        /// <summary>
        /// ulong
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DataValue(ulong value)
        {
            var dataValue = new DataValue();
            dataValue.Value = value.ToString();
            return dataValue;
        }

        /// <summary>
        /// string值
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DataValue(string value)
        {
            var stringValue = new DataValue();
            stringValue.Value = value;
            return stringValue;
        }

        /// <summary>
        /// 带单引号的string值
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static DataValue SingleQuotationString(string value)
        {
            var stringValue = new DataValue();
            stringValue.Value = $"{Marks.SINGLE_QUOTATION}{value}{Marks.SINGLE_QUOTATION}";
            return stringValue;
        }

        /// <summary>
        /// 带双引号的string值
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static DataValue DoubleQuotationString(string value)
        {
            var stringValue = new DataValue();
            stringValue.Value = $"{Marks.DOUBLE_QUOTATION}{value}{Marks.DOUBLE_QUOTATION}";
            return stringValue;
        }
    }

    /// <summary>
    /// DataValue扩展
    /// </summary>
    public static class DataValueExtension
    {
        /// <summary>
        /// 设置值为bool
        /// </summary>
        /// <param name="dataValue"></param>
        /// <param name="value"></param>
        public static void SetValue(this DataValue dataValue, bool value)
        {
            dataValue.Value = value ? "true" : "false";
        }

        /// <summary>
        /// 设置值为int
        /// </summary>
        /// <param name="dataValue"></param>
        /// <param name="value"></param>
        public static void SetValue(this DataValue dataValue, int value)
        {
            dataValue.Value = value.ToString();
        }

        /// <summary>
        /// 设置值为long
        /// </summary>
        /// <param name="dataValue"></param>
        /// <param name="value"></param>
        public static void SetValue(this DataValue dataValue, long value)
        {
            dataValue.Value = value.ToString();
        }

        /// <summary>
        /// 设置值为string；根据参数自动带双引号或单引号
        /// </summary>
        /// <param name="dataValue"></param>
        /// <param name="value"></param>
        /// <param name="singleQuotation"></param>
        /// <param name="doubleQuotation"></param>
        public static void SetValue(this DataValue dataValue, string value, bool singleQuotation = false, bool doubleQuotation = false)
        {
            if (singleQuotation)
            {
                dataValue.Value = $"{Marks.SINGLE_QUOTATION}{value}{Marks.SINGLE_QUOTATION}";
            }
            else if (doubleQuotation)
            {
                dataValue.Value = $"{Marks.DOUBLE_QUOTATION}{value}{Marks.DOUBLE_QUOTATION}";
            }
            else
            {
                dataValue.Value = value;
            }
        }
    }
}
