using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTool
{
    public class GetEncoding
    {
        // 辅助函数，判断字节中的值
        private static bool CheckBytes(byte[] bytes, int count, params int[] values)
        {
            for (int i = 0; i < count; i++)
                if (bytes[i] != values[i]) return false;

            return true;
        }

        /// <summary>  
        /// 根据文件尝试返回字符编码  
        /// </summary>  
        /// <param name="filePath">文件路径</param> 
        /// <returns>如果文件无法读取，返回null。否则，返回编码</returns>
        public static Encoding GetFileEncodingByBomBytes(byte[] bomBytes)
        {
            int bomLength = bomBytes.Length;

            if (bomLength >= 2)
            {
                if (bomLength >= 4)
                {
                    // UTF32，Big-Endian
                    if (CheckBytes(bomBytes, 4, 0x00, 0x00, 0xFE, 0xFF))
                        return new UTF32Encoding(true, true);

                    // UTF32，Little-Endian
                    if (CheckBytes(bomBytes, 4, 0xFF, 0xFE, 0x00, 0x00))
                        return new UTF32Encoding(false, true);
                }

                // UTF8
                if (bomLength >= 3 && CheckBytes(bomBytes, 3, 0xEF, 0xBB, 0xBF))
                    return new UTF8Encoding(true);

                // UTF16，Big-Endian
                if (CheckBytes(bomBytes, 2, 0xFE, 0xFF))
                    return new UnicodeEncoding(true, true);

                // UTF16，Little-Endian
                if (CheckBytes(bomBytes, 2, 0xFF, 0xFE))
                    return new UnicodeEncoding(false, true);
            }

            return null;
        }

        private static bool IsBig5Bytes(ref byte[] bytes)
        {
            // Big5码是一套双字节字符集，使用了双八码存储方法，以两个字节来安放一个字。
            // 第一个字节称为“高位字节”，第二个字节称为“低位字节”。
            // “高位字节”使用了0x81 - 0xFE，“低位字节”使用了0x40 - 0x7E，及0xA1 - 0xFE
            if (bytes.Length % 2 != 0) return false;

            for (int i = 0; i < bytes.Length; i += 2)
            {
                bool flag = (bytes[i] >= 0x81 && bytes[i] <= 0xFE) &&
                    ((bytes[i + 1] >= 0x40 && bytes[i + 1] <= 0x7E) ||
                    (bytes[i + 1] >= 0xA1 && bytes[i + 1] <= 0xFE));
                if (!flag) return false;
            }

            return true;
        }

        private static bool IsGB18030Bytes(ref byte[] bytes)
        {
            // 单字节，其值从0x00到0x7F。
            // 双字节，第一个字节的值从0x81到0xFE，第二个字节的值从0x40到0xFE（不包括0x7F）。
            // 四字节，第一个字节的值从0x81到0xFE，第二个字节的值从0x30到0x39，
            // 第三个字节从0x81到0xFE，第四个字节从0x30到0x39。

            byte byte1 = 0x00, byte2 = 0x00, byte3 = 0x00, byte4 = 0x00;

            for (int i = 0; i < bytes.Length;)
            {
                byte1 = bytes[i];
                // 单字节，其值从0x00到0x7F。
                if (byte1 >= 0x00 && byte1 <= 0x7F)
                {
                    i++;
                    continue;
                }
                // 双字节，第一个字节的值从0x81到0xFE。
                else if (byte1 >= 0x81 && byte1 <= 0xFE && bytes.Length > (i + 1))
                {
                    byte2 = bytes[i + 1];
                    // 第二个字节的值从0x40到0xFE（不包括0x7F）。
                    if (byte2 >= 0x40 && byte2 <= 0xFE && byte2 != 0x7F)
                    {
                        i += 2;
                        continue;
                    }
                    // 四字节，第一个字节的值从0x81到0xFE，第二个字节的值从0x30到0x39。
                    else if (byte2 >= 0x30 && byte2 <= 0x39 && bytes.Length > (i + 3))
                    {
                        byte3 = bytes[i + 2];
                        byte4 = bytes[i + 3];
                        // 第三个字节从0x81到0xFE，第四个字节从0x30到0x39。
                        if (byte3 >= 0x81 && byte3 <= 0xFE && byte4 >= 0x30 && byte4 <= 0x39)
                        {
                            i += 4;
                            continue;
                        }
                        else return false;
                    }
                    else return false;
                }
                else return false;
            }

            return true;
        }

        private static bool IsUTF8Bytes(ref byte[] bytes)
        {
            // 对于UTF-8编码中的任意字节B，如果B的第一位为0，则B独立的表示一个字符(ASCII码)；
            // 如果B的第一位为1，第二位为0，则B为一个多字节字符中的一个字节(非ASCII字符)；
            // 如果B的前两位为1，第三位为0，则B为两个字节表示的字符中的第一个字节；
            // 如果B的前三位为1，第四位为0，则B为三个字节表示的字符中的第一个字节；
            // 如果B的前四位为1，第五位为0，则B为四个字节表示的字符中的第一个字节；

            // Byte 1      Byte 2      Byte 3      Byte 4      Byte 5      Byte 6
            // 0xxxxxxx
            // 110xxxxx    10xxxxxx
            // 1110xxxx    10xxxxxx    10xxxxxx
            // 11110xxx    10xxxxxx    10xxxxxx    10xxxxxx
            // 111110xx    10xxxxxx    10xxxxxx    10xxxxxx    10xxxxxx
            // 1111110x    10xxxxxx    10xxxxxx    10xxxxxx    10xxxxxx    10xxxxxx

            // 1-6
            int nCharTakeBytes = 1;
            // 当前字节
            byte curByte = 0x00;

            for (int i = 0; i < bytes.Length;)
            {
                nCharTakeBytes = 0;
                curByte = bytes[i];

                // 判断字符占字节数
                while ((curByte & 0x80) == 0x80)
                {
                    nCharTakeBytes++;
                    curByte = (byte)(curByte << 1);
                }
                if (nCharTakeBytes == 0) nCharTakeBytes = 1;

                if (nCharTakeBytes > 6) return false;
                if (i + nCharTakeBytes > bytes.Length) return false;
                for (int j = 1; j < nCharTakeBytes; j++) if ((bytes[i + j] & 0x80) == 0x00) return false;

                i += nCharTakeBytes;
            }

            return true;
        }
    }
}
