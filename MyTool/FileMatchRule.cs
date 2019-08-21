using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyTool
{
    public class FileMatchRule
    {
        private string fileNameIncludeRegexString;
        private Regex fileNameIncludeRegex;
        private string fileNameExcludeRegexString;
        private Regex fileNameExcludeRegex;
        private bool fileAttrExcludeReadOnly;
        private bool fileAttrExcludeHidden;
        private bool fileAttrExcludeSystem;
        private long fileSizeMin;
        private long fileSizeMax;

        public static explicit operator FileMatchRule(
            FileMatchSetting.FileMatch fileMatch)
        {
            if (fileMatch == null) return null;

            FileMatchRule fileMatchRule = new FileMatchRule();

            fileMatchRule.fileNameIncludeRegexString = string.Empty;
            if (fileMatch.FileNameIncludeList != null)
            {
                fileMatch.FileNameIncludeList.ForEach(x =>
                {
                    if (x.IsSelected)
                    {
                        fileMatchRule.fileNameIncludeRegexString += (
                            string.Format("({0})",
                            x.IsWildcard ?
                            CommonFunction.WildcardToRegex(x.Rule) :
                            x.Rule) + "|");
                    }
                });
                if (fileMatchRule.fileNameIncludeRegexString != string.Empty)
                    fileMatchRule.fileNameIncludeRegexString =
                        fileMatchRule.fileNameIncludeRegexString.Substring(
                        0, fileMatchRule.fileNameIncludeRegexString.Length - 1);
            }
            if (fileMatchRule.fileNameIncludeRegexString != string.Empty)
                fileMatchRule.fileNameIncludeRegex = new Regex(
                    fileMatchRule.fileNameIncludeRegexString, RegexOptions.IgnoreCase);
            else fileMatchRule.fileNameIncludeRegex = null;

            fileMatchRule.fileNameExcludeRegexString = string.Empty;
            if (fileMatch.FileNameExcludeList != null)
            {
                fileMatch.FileNameExcludeList.ForEach(x =>
                {
                    if (x.IsSelected)
                    {
                        fileMatchRule.fileNameExcludeRegexString += (
                            string.Format("({0})",
                            x.IsWildcard ?
                            CommonFunction.WildcardToRegex(x.Rule) :
                            x.Rule) + "|");
                    }
                });
                if (fileMatchRule.fileNameExcludeRegexString != string.Empty)
                    fileMatchRule.fileNameExcludeRegexString =
                        fileMatchRule.fileNameExcludeRegexString.Substring(
                        0, fileMatchRule.fileNameExcludeRegexString.Length - 1);
            }
            if (fileMatchRule.fileNameExcludeRegexString != string.Empty)
                fileMatchRule.fileNameExcludeRegex = new Regex(
                    fileMatchRule.fileNameExcludeRegexString, RegexOptions.IgnoreCase);
            else fileMatchRule.fileNameExcludeRegex = null;

            fileMatchRule.fileAttrExcludeReadOnly =
                fileMatch.FileAttrExcludeReadOnly;
            fileMatchRule.fileAttrExcludeHidden =
                fileMatch.FileAttrExcludeHidden;
            fileMatchRule.fileAttrExcludeSystem =
                fileMatch.FileAttrExcludeSystem;

            fileMatchRule.fileSizeMin = 0;
            if (fileMatch.FileSizeMinMatch.Enabled &&
                fileMatch.FileSizeMinMatch.Size > 0)
            {
                fileMatchRule.fileSizeMin =
                    fileMatch.FileSizeMinMatch.Size * CommonFunction.GetUnitNum(
                    fileMatch.FileSizeMinMatch.Unit);
            }

            fileMatchRule.fileSizeMax = long.MaxValue;
            if (fileMatch.FileSizeMaxMatch.Enabled &&
                fileMatch.FileSizeMaxMatch.Size > 0)
            {
                fileMatchRule.fileSizeMax =
                    fileMatch.FileSizeMaxMatch.Size * CommonFunction.GetUnitNum(
                    fileMatch.FileSizeMaxMatch.Unit);
            }

            return fileMatchRule;
        }

        public bool IsFileMatch(FileInfo fileInfo)
        {
            if (fileInfo.Length >= fileSizeMin && fileInfo.Length <= fileSizeMax)
            {
                if ((fileAttrExcludeReadOnly && (
                    (fileInfo.Attributes & FileAttributes.ReadOnly) ==
                    FileAttributes.ReadOnly)) ||
                    (fileAttrExcludeHidden && (
                    (fileInfo.Attributes & FileAttributes.Hidden) ==
                    FileAttributes.Hidden)) ||
                    (fileAttrExcludeSystem && (
                    (fileInfo.Attributes & FileAttributes.System) ==
                    FileAttributes.System)))
                {
                    return false;
                }
                else
                {
                    if (fileNameIncludeRegex == null ||
                        fileNameIncludeRegex.IsMatch(fileInfo.Name))
                    {
                        bool isExcludeMatch = (fileNameExcludeRegex != null) &&
                            fileNameExcludeRegex.IsMatch(fileInfo.Name);
                        return !isExcludeMatch;
                    }
                }
            }
            return false;
        }

        public bool IsFolderNameMatch(string folderName)
        {
            if (fileNameIncludeRegex == null || fileNameIncludeRegex.IsMatch(folderName))
            {
                bool isExcludeMatch = (fileNameExcludeRegex != null) &&
                    fileNameExcludeRegex.IsMatch(folderName);
                return !isExcludeMatch;
            }
            else return false;
        }
    }
}
