using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyTool
{
    public class CommonFunction
    {
        private readonly static long KB = 1024;
        private readonly static long MB = KB * 1024;
        private readonly static long GB = MB * 1024;
        private readonly static long TB = GB * 1024;
        private readonly static long PB = TB * 1024;

        /// <summary>
        /// 返回用KB、MB、GB、TB表示的大小的字符串，保留两为小数
        /// </summary>
        /// <param name="lSize">字节数</param>
        /// <returns></returns>
        public static String GetSizeString(long lSize)
        {
            if (lSize == 0) return "0KB";
            else if (lSize < KB) return "1KB";

            double dSize = (double)lSize;

            if (lSize < MB) return String.Format("{0:F}KB", dSize / KB);
            else if (lSize < GB) return String.Format("{0:F}MB", dSize / MB);
            else if (lSize < TB) return String.Format("{0:F}GB", dSize / GB);
            else if (lSize < PB) return String.Format("{0:F}TB", dSize / TB);
            else return "N/A";
        }

        public static long GetUnitNum(string unitString)
        {
            switch (unitString)
            {
                case "B":
                    return 1;
                case "KB":
                    return KB;
                case "MB":
                    return MB;
                case "GB":
                    return GB;
                default:
                    return TB;
            }
        }

        /// <summary>
        /// 通配符转正则表达式
        /// </summary>
        /// <param name="pattern">待转换的通配符</param>
        /// <returns></returns>
        public static string WildcardToRegex(string pattern)
        {
            if (pattern == "*.*") return "^.*$";
            return "^" + Regex.Escape(pattern).
                Replace("\\*", ".*").
                Replace("\\?", ".") + "$";
        }
    }
}
