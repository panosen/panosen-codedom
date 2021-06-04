using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom
{
    /// <summary>
    /// key 或 "key"
    /// </summary>
    public class DataKey : IComparable
    {
        /// <summary>
        /// Key
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// int值
        /// </summary>
        public static implicit operator DataKey(int value)
        {
            var stringValue = new DataKey();
            stringValue.Value = value.ToString();
            return stringValue;
        }

        /// <summary>
        /// int值
        /// </summary>
        public static implicit operator DataKey(long value)
        {
            var stringValue = new DataKey();
            stringValue.Value = value.ToString();
            return stringValue;
        }

        /// <summary>
        /// string值
        /// </summary>
        public static implicit operator DataKey(string value)
        {
            var stringValue = new DataKey();
            stringValue.Value = value;
            return stringValue;
        }

        /// <summary>
        /// 带单引号的string值
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static DataKey SingleQuotationString(string value)
        {
            var stringValue = new DataKey();
            stringValue.Value = $"{Marks.SINGLE_QUOTATION}{value}{Marks.SINGLE_QUOTATION}";
            return stringValue;
        }

        /// <summary>
        /// 带双引号的string值
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static DataKey DoubleQuotationString(string value)
        {
            var stringValue = new DataKey();
            stringValue.Value = $"{Marks.DOUBLE_QUOTATION}{value}{Marks.DOUBLE_QUOTATION}";
            return stringValue;
        }

        #region IComparable Members

        /// <summary>
        /// IComparable.CompareTo
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            var that = obj as DataKey;

            return this.Value.CompareTo(that.Value);
        }

        #endregion
    }
}
