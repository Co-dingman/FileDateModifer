using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace FileDateModifer
{
    public class FileDateModifer
    {
        public Dictionary<string, DateTime> GetFileInfo(string filePath)
        {
            Dictionary<string, DateTime> GetFileInfo = new Dictionary<string, DateTime>();
            Form1 form1 = new Form1();

            var info = new FileInfo(filePath);

            GetFileInfo.Add("CreationTime", info.CreationTime);
            GetFileInfo.Add("LastAccessTime", info.LastAccessTime);
            GetFileInfo.Add("LastWriteTime", info.LastWriteTime);

            return GetFileInfo;
        }
        public bool SetFileDate(string filePath, Dictionary<string,DateTime> getSetDate)
        {
            bool setDateOk;
            try
            {
                File.SetCreationTime(filePath, getSetDate["CreationTime"]);
                File.SetLastWriteTime(filePath, getSetDate["LastWriteTime"]);
                File.SetLastAccessTime(filePath, getSetDate["LastAccessTime"]);
                setDateOk = true;
            }
            catch(IOException e)
            {
                MessageBox.Show("날짜 변경에 실패함. \n에러코드: " + e, "날짜 변경 실패");
                setDateOk = false;
            }

            return setDateOk;


        }
        
    }
}