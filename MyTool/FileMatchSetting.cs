using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MyTool
{
    [XmlRoot("FileMatchSetting")]
    public class FileMatchSetting
    {
        [XmlRoot("FileNameMatch")]
        public class FileNameMatch
        {
            [XmlAttribute("IsSelected")]
            public bool IsSelected;
            [XmlAttribute("IsWildcard")]
            public bool IsWildcard;
            [XmlAttribute("Rule")]
            public string Rule;
        }

        [XmlRoot("FileSizeMatch")]
        public class FileSizeMatch
        {
            [XmlAttribute("Enabled")]
            public bool Enabled;
            [XmlAttribute("Size")]
            public long Size;
            [XmlAttribute("Unit")]
            public string Unit;
        }

        [XmlRoot("FileMatch")]
        public class FileMatch
        {
            [XmlAttribute("Name")]
            public string Name;

            [XmlAttribute("FileAttrExcludeReadOnly")]
            public bool FileAttrExcludeReadOnly;

            [XmlAttribute("FileAttrExcludeHidden")]
            public bool FileAttrExcludeHidden;

            [XmlAttribute("FileAttrExcludeSystem")]
            public bool FileAttrExcludeSystem;

            [XmlElement("FileSizeMinMatch")]
            public FileSizeMatch FileSizeMinMatch;

            [XmlElement("FileSizeMaxMatch")]
            public FileSizeMatch FileSizeMaxMatch;

            [XmlArray("FileNameIncludeList")]
            public List<FileNameMatch> FileNameIncludeList;

            [XmlArray("FileNameExcludeList")]
            public List<FileNameMatch> FileNameExcludeList;

            public FileMatch() { }
            public FileMatch(FileMatch fileMatch)
            {
                FileNameIncludeList = new List<FileNameMatch>();
                FileNameExcludeList = new List<FileNameMatch>();

                fileMatch.FileNameIncludeList.ForEach(x =>
                {
                    FileNameIncludeList.Add(new FileNameMatch()
                    {
                        IsSelected = x.IsSelected,
                        IsWildcard = x.IsWildcard,
                        Rule = x.Rule
                    });
                });
                fileMatch.FileNameExcludeList.ForEach(x =>
                {
                    FileNameExcludeList.Add(new FileNameMatch()
                    {
                        IsSelected = x.IsSelected,
                        IsWildcard = x.IsWildcard,
                        Rule = x.Rule
                    });
                });

                FileAttrExcludeReadOnly = fileMatch.FileAttrExcludeReadOnly;
                FileAttrExcludeHidden = fileMatch.FileAttrExcludeHidden;
                FileAttrExcludeSystem = fileMatch.FileAttrExcludeSystem;

                FileSizeMinMatch = new FileSizeMatch()
                {
                    Enabled = fileMatch.FileSizeMinMatch.Enabled,
                    Size = fileMatch.FileSizeMinMatch.Size,
                    Unit = fileMatch.FileSizeMinMatch.Unit
                };

                FileSizeMaxMatch = new FileSizeMatch()
                {
                    Enabled = fileMatch.FileSizeMaxMatch.Enabled,
                    Size = fileMatch.FileSizeMaxMatch.Size,
                    Unit = fileMatch.FileSizeMaxMatch.Unit
                };

                Name = fileMatch.Name;
            }
        }

        [XmlAttribute("SelectedName")]
        public string SelectedName;

        [XmlArray("FileMatchList")]
        public List<FileMatch> FileMatchList;

        [XmlIgnore]
        public int FileMatchCount
        {
            get { return FileMatchList.Count; }
        }

        [XmlIgnore]
        public int SelectedIndex
        {
            get { return FileMatchList.FindIndex(x => x.Name == this.SelectedName); }
        }

        [XmlIgnore]
        public FileMatch SelectedFileMatch
        {
            get { return FileMatchList.Find(x => x.Name == this.SelectedName); }
        }

        public FileMatch this[string name]
        {
            get
            {
                return FileMatchList.Find(x => x.Name == name);
            }
        }

        public FileMatch this[int index]
        {
            get
            {
                if (index >= 0 && index < FileMatchList.Count)
                    return FileMatchList[index];
                else return null;
            }
            set
            {
                FileMatchList[index] = value;
            }
        }

        public string[] GetAllFileMatchName()
        {
            return FileMatchList.ConvertAll<string>(x => x.Name).ToArray();
        }

        public static FileMatchSetting GetInitData()
        {
            FileMatchSetting fileMatchSetting = new FileMatchSetting();
            fileMatchSetting.SelectedName = "[默认]";
            fileMatchSetting.FileMatchList = new List<FileMatch>();

            FileMatch fileMatch = new FileMatch();
            fileMatch.Name = fileMatchSetting.SelectedName;

            fileMatch.FileNameIncludeList =
                new FileNameMatch[] {
                    new FileNameMatch() {
                        IsSelected = true,
                        IsWildcard = true,
                        Rule = "*.*" }}.ToList();

            fileMatch.FileNameExcludeList =
                new FileNameMatch[] {
                    new FileNameMatch() {
                        IsSelected = true,
                        IsWildcard = true,
                        Rule = "*.dll" },
                    new FileNameMatch() {
                        IsSelected = true,
                        IsWildcard = true,
                        Rule = "*.sys" },
                    new FileNameMatch() {
                        IsSelected = true,
                        IsWildcard = true,
                        Rule = "*.inf" }}.ToList();

            fileMatch.FileAttrExcludeReadOnly = false;
            fileMatch.FileAttrExcludeHidden = false;
            fileMatch.FileAttrExcludeSystem = true;

            fileMatch.FileSizeMinMatch = new FileSizeMatch()
            {
                Enabled = false,
                Size = 0,
                Unit = "KB"
            };
            fileMatch.FileSizeMaxMatch = new FileSizeMatch()
            {
                Enabled = false,
                Size = 0,
                Unit = "KB"
            };

            fileMatchSetting.FileMatchList.Add(fileMatch);

            return fileMatchSetting;
        }
    }
}
