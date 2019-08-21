using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MyTool
{
    [XmlRoot("ComparedRenameSetting")]
    public class ComparedRenameSetting
    {
        public enum ComparedRenameType
        {
            LOCAL_RENAME,
            COPY_RENAME,
        }

        [XmlAttribute("RenameType")]
        public ComparedRenameType renameType;
        [XmlAttribute("GetFileFromDirectoryType")]
        public GetFileOrFolder.GetFileFromDirectoryType getFileFromDirectoryType;
        [XmlElement("AddedSuffix")]
        public Setting.ComboBoxSet addedSuffix;

        public static ComparedRenameSetting GetInitData()
        {
            ComparedRenameSetting comparedRenameSetting =
                new ComparedRenameSetting();

            comparedRenameSetting.renameType = ComparedRenameType.LOCAL_RENAME;
            comparedRenameSetting.getFileFromDirectoryType =
                GetFileOrFolder.GetFileFromDirectoryType.ALL_DIRECTORIES;

            comparedRenameSetting.addedSuffix = new Setting.ComboBoxSet();
            comparedRenameSetting.addedSuffix.ItemList =
                new List<Setting.ItemAndCount>();
            comparedRenameSetting.addedSuffix.ItemList.AddRange(
                new Setting.ItemAndCount[]
                {
                    new Setting.ItemAndCount() {Item = "chs", Count = 0 },
                    new Setting.ItemAndCount() {Item = "cht", Count = 0 },
                    new Setting.ItemAndCount() {Item = "eng", Count = 0 }
                });
            comparedRenameSetting.addedSuffix.SelectedIndex = 0;

            return comparedRenameSetting;
        }
    }
}
