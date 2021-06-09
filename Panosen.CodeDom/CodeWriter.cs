using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom
{
    /// <summary>
    /// 代码输出流
    /// </summary>
    public class CodeWriter
    {
        private readonly TextWriter textWriter;

        /// <summary>
        /// 代码输出流
        /// </summary>
        /// <param name="textWriter"></param>
        public CodeWriter(TextWriter textWriter)
        {
            this.textWriter = textWriter;
        }

        /// <summary>
        /// 代码输出流
        /// </summary>
        /// <param name="textWriter"></param>
        public static implicit operator CodeWriter(TextWriter textWriter)
        {
            return new CodeWriter(textWriter);
        }

        #region Call TextWriter Members

        /// <summary>
        /// 写入字符串，可以为 null
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public CodeWriter Write(string value)
        {
            textWriter.Write(value);
            return this;
        }

        /// <summary>
        /// 写入字符串，可以为 null
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public CodeWriter WriteLine(string value)
        {
            textWriter.WriteLine(value);
            return this;
        }

        /// <summary>
        /// 写入换行符
        /// </summary>
        /// <returns></returns>
        public CodeWriter WriteLine()
        {
            textWriter.WriteLine();
            return this;
        }

        #endregion

        #region implicit

        /// <summary>
        /// new StringWriter(StringBuilder) as CodeWriter
        /// </summary>
        /// <param name="builder"></param>
        public static implicit operator CodeWriter(StringBuilder builder)
        {
            return new StringWriter(builder);
        }

        #endregion
    }
}
