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
    public class DataKey
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

        /// <summary>
        /// override Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            var other = obj as DataKey;
            if (other == null)
            {
                return false;
            }

            return Equals(this.Value, other.Value);
        }

        /// <summary>
        /// override GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            if (this.Value == null)
            {
                return 0;
            }

            return this.Value.GetHashCode();
        }
    }
}
