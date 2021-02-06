using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FileDateModifer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenFileBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, DateTime> FileInfo;
            OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK) FilePath.Text = ofd.FileName;
                FileDateModifer fdm = new FileDateModifer();

                FileInfo = fdm.GetFileInfo(ofd.FileName);

                CreationTime.Value = FileInfo["CreationTime"];
                LastWriteTime.Value = FileInfo["LastWriteTime"];
                LastAccessTime.Value = FileInfo["LastAccessTime"];
                
                //throw new System.NotImplementedException();
        }
        private void ChangeCollectiveBtn_Click(object sender, EventArgs e)
        {
            CreationTime.Value = ChangeCollectiveTime.Value;
            LastWriteTime.Value = ChangeCollectiveTime.Value;
            LastAccessTime.Value = ChangeCollectiveTime.Value;
        }
        private void 도움말ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1) Open File 버튼을 클릭하여 파일을 불러주세요.\n" +
                            "2) 기존 파일에 날짜 정보가 입력됩니다. 해당 날짜를 변경해주세요.\n" +
                            "2-1) 일괄변경 옆 날짜 정보를 이용하여 날짜 정보를 일괄로 변경할 수 있습니다.\n" +
                            "3) Modify Date 버튼을 클릭하여 날짜를 수정합니다.", "사용법");
        }

        private void 정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("해당 프로그램은 파일의 작성 & 수정 & 엑세스 일자를 변경하는 프로그램입니다.\n" +
                            "version1.0", "프로그램 정보");
        }

        private void ModifyDateBtn_Click(object sender, EventArgs e)
        {
            bool setDateOk;
            FileDateModifer fdm = new FileDateModifer();
            Dictionary<string, DateTime> getSetDate = new Dictionary<string, DateTime>();

            getSetDate.Add("CreationTime", CreationTime.Value);
            getSetDate.Add("LastWriteTime", LastWriteTime.Value);
            getSetDate.Add("LastAccessTime", LastAccessTime.Value);
            setDateOk = fdm.SetFileDate(FilePath.Text, getSetDate);

            if (setDateOk) MessageBox.Show("날짜 변경에 성공함", "날짜 변경 성공");
            //throw new System.NotImplementedException();
        }
    }
}