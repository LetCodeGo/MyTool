using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTool
{
    public class Helper
    {
        /// <summary>
        /// 用记事本打开内容
        /// </summary>
        /// <param name="strContext"></param>
        public static void OpenEdit(String strContext)
        {
            #region 启动 notepad++

            System.Diagnostics.Process ProcNotePad = null;

            List<String> programFolderList = new List<String>();
            //programFolderList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles));
            //if (Environment.Is64BitOperatingSystem)
            //    programFolderList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86));
            programFolderList.Add("C:\\Program Files");
            programFolderList.Add("C:\\Program Files (x86)");

            foreach (String programFolder in programFolderList)
            {
                if (String.IsNullOrWhiteSpace(programFolder)) continue;

                String notePadPath = Path.Combine(programFolder, "Notepad++", "notepad++.exe");

                if (File.Exists(notePadPath))
                {
                    try
                    {
                        DateTime dateTime = DateTime.Now;
                        string fileFolder = Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData,
                            Environment.SpecialFolderOption.Create),
                            Path.GetFileNameWithoutExtension(System.Windows.Forms.Application.ExecutablePath),
                            dateTime.ToString("yyyy-MM-dd"));
                        if (!Directory.Exists(fileFolder)) Directory.CreateDirectory(fileFolder);
                        string filePath = Path.Combine(fileFolder, string.Format("log_{0}.log", dateTime.ToString("yyyyMMddHHHmmss")));

                        File.WriteAllText(filePath, strContext, Encoding.UTF8);

                        ProcNotePad = new System.Diagnostics.Process();
                        ProcNotePad.StartInfo.FileName = notePadPath;
                        ProcNotePad.StartInfo.Arguments = filePath;
                        ProcNotePad.StartInfo.UseShellExecute = true;
                        ProcNotePad.StartInfo.RedirectStandardInput = false;
                        ProcNotePad.StartInfo.RedirectStandardOutput = false;

                        ProcNotePad.Start();
                        return;
                    }
                    catch
                    {
                        ProcNotePad = null;
                    }
                }
            }
            #endregion

            if (ProcNotePad == null)
            {
                #region [ 启动记事本 ] 

                System.Diagnostics.Process Proc;

                try
                {
                    // 启动记事本 
                    Proc = new System.Diagnostics.Process();
                    Proc.StartInfo.FileName = "notepad.exe";
                    Proc.StartInfo.UseShellExecute = false;
                    Proc.StartInfo.RedirectStandardInput = true;
                    Proc.StartInfo.RedirectStandardOutput = true;

                    Proc.Start();
                }
                catch
                {
                    Proc = null;
                }

                #endregion

                #region [ 传递数据给记事本 ] 

                if (Proc != null)
                {
                    // 调用 API, 传递数据 
                    while (Proc.MainWindowHandle == IntPtr.Zero)
                    {
                        Proc.Refresh();
                    }

                    IntPtr vHandle = Win32API.FindWindowEx(Proc.MainWindowHandle, IntPtr.Zero, "Edit", null);

                    // 传递数据给记事本 
                    Win32API.SendMessage(vHandle, Win32API.WM_SETTEXT, 0, strContext);
                }
                else
                {
                    LogForm form = new LogForm(strContext);
                    form.ShowDialog();
                }

                #endregion
            }
        }
    }
}
