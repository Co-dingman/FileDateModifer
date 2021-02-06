using System.ComponentModel;

namespace FileDateModifer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FilePath = new System.Windows.Forms.Label();
            this.OpenFileBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CreationTime = new System.Windows.Forms.DateTimePicker();
            this.LastWriteTime = new System.Windows.Forms.DateTimePicker();
            this.LastAccessTime = new System.Windows.Forms.DateTimePicker();
            this.ChangeCollectiveTime = new System.Windows.Forms.DateTimePicker();
            this.ModifyDateBtn = new System.Windows.Forms.Button();
            this.ChangeCollectiveBtn = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Help.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Title.Location = new System.Drawing.Point(178, 42);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(267, 37);
            this.Title.TabIndex = 0;
            this.Title.Text = "File Date Modifer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(199, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "File information";
            // 
            // FilePath
            // 
            this.FilePath.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilePath.Font = new System.Drawing.Font("맑은 고딕", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (129)));
            this.FilePath.Location = new System.Drawing.Point(17, 114);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(461, 49);
            this.FilePath.TabIndex = 2;
            // 
            // OpenFileBtn
            // 
            this.OpenFileBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OpenFileBtn.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.OpenFileBtn.Location = new System.Drawing.Point(558, 114);
            this.OpenFileBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OpenFileBtn.Name = "OpenFileBtn";
            this.OpenFileBtn.Size = new System.Drawing.Size(137, 49);
            this.OpenFileBtn.TabIndex = 3;
            this.OpenFileBtn.Text = "Open File";
            this.OpenFileBtn.UseVisualStyleBackColor = false;
            this.OpenFileBtn.Click += new System.EventHandler(this.OpenFileBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(33, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "파일 생성일자";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(33, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "파일 수정일자";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.Location = new System.Drawing.Point(33, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "파일 접근일자";
            // 
            // CreationTime
            // 
            this.CreationTime.CustomFormat = "yyyy-MM-dd HH:mm";
            this.CreationTime.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.CreationTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CreationTime.Location = new System.Drawing.Point(202, 294);
            this.CreationTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CreationTime.Name = "CreationTime";
            this.CreationTime.Size = new System.Drawing.Size(224, 25);
            this.CreationTime.TabIndex = 7;
            // 
            // LastWriteTime
            // 
            this.LastWriteTime.CustomFormat = "yyyy-MM-dd HH:mm";
            this.LastWriteTime.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.LastWriteTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.LastWriteTime.Location = new System.Drawing.Point(202, 355);
            this.LastWriteTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LastWriteTime.Name = "LastWriteTime";
            this.LastWriteTime.Size = new System.Drawing.Size(224, 25);
            this.LastWriteTime.TabIndex = 8;
            // 
            // LastAccessTime
            // 
            this.LastAccessTime.CustomFormat = "yyyy-MM-dd HH:mm";
            this.LastAccessTime.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.LastAccessTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.LastAccessTime.Location = new System.Drawing.Point(202, 418);
            this.LastAccessTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LastAccessTime.Name = "LastAccessTime";
            this.LastAccessTime.Size = new System.Drawing.Size(224, 25);
            this.LastAccessTime.TabIndex = 9;
            // 
            // ChangeCollectiveTime
            // 
            this.ChangeCollectiveTime.CustomFormat = "yyyy-MM-dd HH:mm";
            this.ChangeCollectiveTime.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ChangeCollectiveTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ChangeCollectiveTime.Location = new System.Drawing.Point(123, 237);
            this.ChangeCollectiveTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChangeCollectiveTime.Name = "ChangeCollectiveTime";
            this.ChangeCollectiveTime.Size = new System.Drawing.Size(224, 25);
            this.ChangeCollectiveTime.TabIndex = 11;
            // 
            // ModifyDateBtn
            // 
            this.ModifyDateBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ModifyDateBtn.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ModifyDateBtn.Location = new System.Drawing.Point(559, 189);
            this.ModifyDateBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ModifyDateBtn.Name = "ModifyDateBtn";
            this.ModifyDateBtn.Size = new System.Drawing.Size(137, 49);
            this.ModifyDateBtn.TabIndex = 12;
            this.ModifyDateBtn.Text = "Modify Date";
            this.ModifyDateBtn.UseVisualStyleBackColor = false;
            this.ModifyDateBtn.Click += new System.EventHandler(this.ModifyDateBtn_Click);
            // 
            // ChangeCollectiveBtn
            // 
            this.ChangeCollectiveBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ChangeCollectiveBtn.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ChangeCollectiveBtn.Location = new System.Drawing.Point(387, 237);
            this.ChangeCollectiveBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChangeCollectiveBtn.Name = "ChangeCollectiveBtn";
            this.ChangeCollectiveBtn.Size = new System.Drawing.Size(104, 32);
            this.ChangeCollectiveBtn.TabIndex = 13;
            this.ChangeCollectiveBtn.Text = "일괄변경";
            this.ChangeCollectiveBtn.UseVisualStyleBackColor = false;
            this.ChangeCollectiveBtn.Click += new System.EventHandler(this.ChangeCollectiveBtn_Click);
            // 
            // Help
            // 
            this.Help.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Help.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.helpToolStripMenuItem});
            this.Help.Location = new System.Drawing.Point(0, 0);
            this.Help.Name = "Help";
            this.Help.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.Help.Size = new System.Drawing.Size(710, 30);
            this.Help.TabIndex = 14;
            this.Help.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.도움말ToolStripMenuItem, this.정보ToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.Image = ((System.Drawing.Image) (resources.GetObject("도움말ToolStripMenuItem.Image")));
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.도움말ToolStripMenuItem.Text = "도움말";
            this.도움말ToolStripMenuItem.Click += new System.EventHandler(this.도움말ToolStripMenuItem_Click);
            // 
            // 정보ToolStripMenuItem
            // 
            this.정보ToolStripMenuItem.Image = ((System.Drawing.Image) (resources.GetObject("정보ToolStripMenuItem.Image")));
            this.정보ToolStripMenuItem.Name = "정보ToolStripMenuItem";
            this.정보ToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.정보ToolStripMenuItem.Text = "정보";
            this.정보ToolStripMenuItem.Click += new System.EventHandler(this.정보ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(710, 485);
            this.Controls.Add(this.ChangeCollectiveBtn);
            this.Controls.Add(this.ModifyDateBtn);
            this.Controls.Add(this.ChangeCollectiveTime);
            this.Controls.Add(this.LastAccessTime);
            this.Controls.Add(this.LastWriteTime);
            this.Controls.Add(this.CreationTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OpenFileBtn);
            this.Controls.Add(this.FilePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Help);
            this.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.MainMenuStrip = this.Help;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "File Date Modifer";
            this.Help.ResumeLayout(false);
            this.Help.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 정보ToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;

        private System.Windows.Forms.MenuStrip Help;

        private System.Windows.Forms.Button ChangeCollectiveBtn;

        private System.Windows.Forms.Button ModifyDateBtn;

        private System.Windows.Forms.DateTimePicker ChangeCollectiveTime;

        private System.Windows.Forms.DateTimePicker LastWriteTime;
        private System.Windows.Forms.DateTimePicker LastAccessTime;

        private System.Windows.Forms.DateTimePicker CreationTime;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button OpenFileBtn;
        private System.Windows.Forms.Label FilePath;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label Title;

        #endregion
    }
}