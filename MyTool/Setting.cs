using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MyTool
{
    public class Setting
    {
        [XmlRoot("ItemAndCount")]
        public class ItemAndCount
        {
            [XmlAttribute("Item")]
            public string Item;
            [XmlAttribute("Count")]
            public int Count;
        }

        [XmlRoot("ComboBoxSet")]
        public class ComboBoxSet
        {
            [XmlAttribute("SelectedIndex")]
            public int SelectedIndex;
            [XmlArray("ItemList")]
            public List<ItemAndCount> ItemList;
        }

        [XmlRoot("Setting")]
        public class SettingData
        {
            [XmlElement("IsDragWithAppend")]
            public bool isDragWithAppend;

            [XmlElement("FileMatchSetting")]
            public FileMatchSetting fileMatchSetting;

            [XmlElement("ComparedRenameSetting")]
            public ComparedRenameSetting comparedRenameSetting;

            [XmlElement("FileOrFolderRenameSetting")]
            public FileOrFolderRenameSetting fileOrFolderRenameSetting;
        }

        public SettingData settingData = null;

        private static readonly object lockObject = new object();
        private static Setting instance = null;
        private static readonly string SettingFilePath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Setting.xml");

        private Setting() { }

        public static Setting GetInstance()
        {
            bool loadWasFailed = false;
            if (instance == null)
            {
                bool lockWasTaken = false;
                try
                {
                    System.Threading.Monitor.Enter(lockObject, ref lockWasTaken);
                    instance = new Setting();
                    instance.Load();
                }
                catch (Exception ex)
                {
                    loadWasFailed = true;
                    MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK);
                }
                finally
                {
                    if (lockWasTaken) System.Threading.Monitor.Exit(lockObject);
                }
            }

            if (loadWasFailed) Application.Exit();
            return instance;
        }

        public FileMatchRule GetCurrentMatchRule()
        {
            FileMatchSetting.FileMatch selectedFileMatch =
                settingData.fileMatchSetting.FileMatchList.Find(
                    x => x.Name == settingData.fileMatchSetting.SelectedName);

            if (selectedFileMatch == null) return null;
            else return (FileMatchRule)selectedFileMatch;
        }

        private void Load()
        {
            if (File.Exists(SettingFilePath))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(SettingData));
                using (FileStream fileStream = File.OpenRead(SettingFilePath))
                {
                    settingData =
                          xmlSerializer.Deserialize(fileStream) as SettingData;
                }
            }

            if (settingData == null) settingData = new SettingData();
            if (settingData.fileMatchSetting == null)
                settingData.fileMatchSetting =
                    FileMatchSetting.GetInitData();
            if (settingData.comparedRenameSetting == null)
                settingData.comparedRenameSetting =
                    ComparedRenameSetting.GetInitData();
            if (settingData.fileOrFolderRenameSetting == null)
                settingData.fileOrFolderRenameSetting =
                    FileOrFolderRenameSetting.GetInitData();
        }

        public void Save()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(SettingData));
            using (FileStream fileStream = File.Create(SettingFilePath))
            {
                xmlSerializer.Serialize(fileStream, settingData);
            }
        }
    }
}
