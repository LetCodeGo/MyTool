using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MyTool
{
    [XmlRoot("FileOrFolderRenameSetting")]
    public class FileOrFolderRenameSetting
    {
        [XmlIgnore]
        public static readonly string[] DragFileShowTexts =
            new string[] { "仅当前目录", "包含子目录" };

        [XmlIgnore]
        public static readonly string[] ManagerShowTexts =
            new string[] { "正则表达式原始", "正则表达式目标",
                "查找并替换原始", "查找并替换目标" };

        public enum DragType
        {
            FILE,
            FOLDER,
        }

        public enum FileOrFolderRenameType
        {
            REGEX,
            REPLACE,
            PASTE,
        }

        [XmlAttribute("DragType")]
        public DragType dragType;
        [XmlAttribute("RenameType")]
        public FileOrFolderRenameType renameType;
        [XmlElement("RegexOriginal")]
        public Setting.ComboBoxSet regexOriginal;
        [XmlElement("RegexTarget")]
        public Setting.ComboBoxSet regexTarget;
        [XmlElement("ReplaceOriginal")]
        public Setting.ComboBoxSet replaceOriginal;
        [XmlElement("ReplaceTarget")]
        public Setting.ComboBoxSet replaceTarget;
        [XmlAttribute("ReplaceNotIgnoreCase")]
        public bool replaceNotIgnoreCase;
        [XmlAttribute("ReplaceOnce")]
        public bool replaceOnce;
        [XmlAttribute("GetFileFromDirectoryType")]
        public GetFileOrFolder.GetFileFromDirectoryType getFileFromDirectoryType;
        [XmlAttribute("ManagerSelectedIndex")]
        public int managerSelectedIndex;

        public static FileOrFolderRenameSetting GetInitData()
        {
            FileOrFolderRenameSetting fileOrFolderRenameSetting =
                new FileOrFolderRenameSetting();
            fileOrFolderRenameSetting.dragType = DragType.FILE;
            fileOrFolderRenameSetting.renameType = FileOrFolderRenameType.REGEX;
            fileOrFolderRenameSetting.replaceNotIgnoreCase = false;
            fileOrFolderRenameSetting.replaceOnce = false;
            fileOrFolderRenameSetting.getFileFromDirectoryType = 
                GetFileOrFolder.GetFileFromDirectoryType.ALL_DIRECTORIES;
            fileOrFolderRenameSetting.managerSelectedIndex = 0;

            fileOrFolderRenameSetting.regexOriginal = new Setting.ComboBoxSet();
            fileOrFolderRenameSetting.regexOriginal.ItemList =
                new List<Setting.ItemAndCount>();
            fileOrFolderRenameSetting.regexOriginal.ItemList.AddRange(
                new Setting.ItemAndCount[]
                {
                    new Setting.ItemAndCount() {Item = "^(.*)\\.(.*)$", Count = 0 }
                });

            fileOrFolderRenameSetting.regexTarget = new Setting.ComboBoxSet();
            fileOrFolderRenameSetting.regexTarget.ItemList =
                new List<Setting.ItemAndCount>();
            fileOrFolderRenameSetting.regexTarget.ItemList.AddRange(
                new Setting.ItemAndCount[]
                {
                    new Setting.ItemAndCount() {Item = "?index?2?1?_{0}.{1}", Count = 0 }
                });

            fileOrFolderRenameSetting.replaceOriginal = new Setting.ComboBoxSet();
            fileOrFolderRenameSetting.replaceOriginal.ItemList =
                new List<Setting.ItemAndCount>();
            fileOrFolderRenameSetting.replaceOriginal.ItemList.AddRange(
                new Setting.ItemAndCount[]
                {
                    new Setting.ItemAndCount() {Item = "chs", Count = 0 }
                });

            fileOrFolderRenameSetting.replaceTarget = new Setting.ComboBoxSet();
            fileOrFolderRenameSetting.replaceTarget.ItemList =
                new List<Setting.ItemAndCount>();
            fileOrFolderRenameSetting.replaceTarget.ItemList.AddRange(
                new Setting.ItemAndCount[]
                {
                    new Setting.ItemAndCount() {Item = "eng", Count = 0 }
                });

            return fileOrFolderRenameSetting;
        }
    }
}
