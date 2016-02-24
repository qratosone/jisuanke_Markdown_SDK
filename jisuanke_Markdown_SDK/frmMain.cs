﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jisuanke_Markdown_SDK
{
    public partial class frmMain : Form
    {
        public Info infoMain;
        public frmMain()
        {

            InitializeComponent();
            infoMain = new Info();
        }
        public String text = "";
        private String _FileName = "";
        public String FileName
        {
            get
            {
                return _FileName;
            }
            set
            {
                _FileName = value;
                //在赋值时同步更新窗体标题
                Text = Path.GetFileName(value) + "-jisuanke Markdown Editor";
            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            Text = "Untitled" + "-jisuanke Markdown Editor";
        }
        private void Open()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog1.FileName;
                try
                {
                    text= File.ReadAllText(FileName);
                    txtEditor.Text = text;
                }
                catch (Exception)
                {
                    MessageBox.Show("无法打开文件");
                }

            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Open();
        }
        private void Save()
        {
            //当内容己更改时，此标记为True，
            bool ShouldSave = false;
            //如果文件名不为空，表明当前是文本框中的内容是来自于文件
            if (FileName != "")
            {
                //如果内容己更改
                if (txtEditor.Text != text
                    && MessageBox.Show("文件己修改，保存吗？",
                    "保存文件",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ShouldSave = true;
                }
            }
            else
            {
                //如果用户输入了内容，并且指定了一个文件名
                if (txtEditor.Text != "" && saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileName = saveFileDialog1.FileName;
                    ShouldSave = true;
                }
            }

            if (ShouldSave)
            {
                try
                {
                    File.WriteAllText(FileName, txtEditor.Text);
                    text= txtEditor.Text;
                    MessageBox.Show("文件已保存");
                }
                catch (Exception)
                {
                    MessageBox.Show("文件保存失败");
                }

            }
        }
        private void btnRead_Click(object sender, EventArgs e)
        {
            frmRead read = new frmRead();
            read.update = infoMain;
            read.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            text += infoMain.text;
            txtEditor.Text = text;
            infoMain.text = "";
        }

        private void btnCode_Click(object sender, EventArgs e)
        {
            frmCode code = new frmCode();
            code.update = infoMain;
            code.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}