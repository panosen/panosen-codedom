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

        #region IComparable Members

        /// <summary>
        /// IComparable.CompareTo
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            var that = obj as DataKey;

            if (that == null)
            {
                return 1;
            }

            if (this.Value == null && that.Value == null)
            {
                return 0;
            }

            return this.Value.CompareTo(that.Value);
        }

        /// <summary>
        /// ==
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator ==(DataKey left, DataKey right)
        {
            if (ReferenceEquals(left, null))
            {
                return ReferenceEquals(right, null);
            }

            return left.Equals(right);
        }

        /// <summary>
        /// &gt;
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator >(DataKey left, DataKey right)
        {
            if (ReferenceEquals(left, null) || string.IsNullOrEmpty(left.Value))
            {
                return false;
            }

            if (ReferenceEquals(right, null) || string.IsNullOrEmpty(right.Value))
            {
                return true;
            }

            return left.Value.CompareTo(right.Value) > 0;
        }

        /// <summary>
        /// &lt;
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator <(DataKey left, DataKey right)
        {
            if (ReferenceEquals(right, null) || string.IsNullOrEmpty(right.Value))
            {
                return false;
            }

            if (ReferenceEquals(left, null) || string.IsNullOrEmpty(left.Value))
            {
                return true;
            }

            return right.Value.CompareTo(left.Value) > 0;
        }

        /// <summary>
        /// !=
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator !=(DataKey left, DataKey right)
        {
            return !(left == right);
        }

        /// <summary>
        /// &gt;=
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator >=(DataKey left, DataKey right)
        {
            return left == right || left > right;
        }

        /// <summary>
        /// &lt;=
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator <=(DataKey left, DataKey right)
        {
            return left == right || left < right;
        }

        #endregion
    }
}
