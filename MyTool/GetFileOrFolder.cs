using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MyTool.Setting;

namespace MyTool
{
    public class GetFileOrFolder
    {
        public enum GetFileFromDirectoryType
        {
            TOP_DIRECTORY_ONLY,
            ALL_DIRECTORIES,
        }

        public static readonly char[] limitedChars = "\\/:*?\"<>|".ToCharArray();
        public static readonly char[] replaceChars = "＼／：＊？“＜＞｜".ToCharArray();
        public static readonly char[] invalidChars = Path.GetInvalidFileNameChars();

        public static bool IsInputContainLimitedChar(string input)
        {
            return (input.IndexOfAny(limitedChars) != -1);
        }

        public static string ReplaceLimitedChar(string input)
        {
            string tempString = input;

            for (int i = 0; i < GetFileOrFolder.limitedChars.Length; i++)
                tempString = tempString.Replace(GetFileOrFolder.limitedChars[i],
                    GetFileOrFolder.replaceChars[i]);

            return tempString;
        }

        public static string ReplaceInvalidChar(string input)
        {
            string tempString = input;
            char replaceChar = '_';

            for (int i = 0; i < invalidChars.Length; i++)
            {
                int index = Array.IndexOf<char>(limitedChars, invalidChars[i]);
                if (index != -1)
                {
                    replaceChar = replaceChars[index];
                }
                tempString.Replace(invalidChars[i], replaceChar);
            }

            return tempString;
        }

        public static string GetFileNameWithoutExtension(string fileName)
        {
            int index = fileName.LastIndexOf('.');
            if (index == -1) return fileName;
            else return fileName.Substring(0, index);
        }

        public static string GetFileExtension(string fileName)
        {
            int index = fileName.LastIndexOf('.');
            if (index == -1) return string.Empty;
            else return fileName.Substring(index + 1);
        }

        public static List<string> GetFilesFromPathList(
            string[] pathList, FileMatchRule fileMatchRule,
            GetFileFromDirectoryType getFileFromDirectoryType)
        {
            List<string> fileList = new List<string>();

            foreach (string path in pathList)
            {
                if (Directory.Exists(path))
                    GetFilesFromFolder(path, fileMatchRule,
                        getFileFromDirectoryType, ref fileList);
                else if (File.Exists(path) &&
                    fileMatchRule.IsFileMatch(new FileInfo(path)))
                    fileList.Add(path);
            }

            fileList.Sort();
            return fileList;
        }

        private static void GetFilesFromFolder(
            string folderPath, FileMatchRule fileMatchRule,
            GetFileFromDirectoryType getFileFromDirectoryType,
            ref List<string> fileList)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(folderPath);

            FileInfo[] fileInfos = dirInfo.GetFiles();
            foreach (FileInfo fi in fileInfos)
                if (fileMatchRule.IsFileMatch(fi)) fileList.Add(fi.FullName);

            if (getFileFromDirectoryType == GetFileFromDirectoryType.ALL_DIRECTORIES)
            {
                DirectoryInfo[] directoryInfos = dirInfo.GetDirectories();
                foreach (DirectoryInfo di in directoryInfos)
                    GetFilesFromFolder(di.FullName, fileMatchRule,
                        getFileFromDirectoryType, ref fileList);
            }
        }

        public static int ComparedByFileName(string filePath1, string filePath2)
        {
            return filePath1.Substring(filePath1.LastIndexOf('\\') + 1).CompareTo(
                filePath2.Substring(filePath2.LastIndexOf('\\') + 1));
        }
    }
}
