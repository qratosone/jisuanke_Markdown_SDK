using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jisuanke_Markdown_SDK
{
    public partial class frmCode : Form
    {
        private int step;
        public Info update;
        public frmCode()
        {
            step = 1;
            InitializeComponent();
        }
        public void updateTitle()
        {
            update.text += ("# " + txtTitle.Text);
            update.text += Environment.NewLine;
            update.text += "---";
            update.text += Environment.NewLine;
            update.text += ("- " + txtTag.Text);
            update.text += Environment.NewLine;
        }
        private void btnTitle_Click(object sender, EventArgs e)
        {
            updateTitle();
        }
        public void updateCode()
        {
            update.text += Environment.NewLine;
            update.text += "---";
            update.text += Environment.NewLine;
            if (lblStatus.Text=="当前状态")
            {
                update.text += "### 初始化代码";
                update.text += Environment.NewLine;
                update.text += "```";
                update.text += Environment.NewLine;
                update.text += txtCode.Text;
                update.text += Environment.NewLine;
                update.text += "```";
                txtGuide.Text = "";
                txtTips.Text = "";
                lblStatus.Text = "已添加初始化代码";
                return;
            }
            if (txtTips.Text != "")
            {
                update.text += "### 第" + step.ToString() + "步";
                update.text += Environment.NewLine;
                update.text += "#### 讲解";
                update.text += Environment.NewLine;
                update.text += txtGuide.Text;
                update.text += Environment.NewLine;
                update.text += "#### 提示";
                update.text += Environment.NewLine;
                update.text += txtTag.Text;
                update.text += Environment.NewLine;
                update.text += "#### 代码";
                update.text += Environment.NewLine;
                update.text += "```";
                update.text += Environment.NewLine;
                update.text += txtCode.Text;
                update.text += Environment.NewLine;
                update.text += "```";
                lblStatus.Text = "已添加第" + step.ToString() + "步";
                step++;
                txtTips.Text = "添加提示";
            }
            else
            {
                update.text += "#### 完成讲解";
                update.text += Environment.NewLine;
                update.text += txtGuide.Text;
                lblStatus.Text = "已添加完成讲解";
            }

        }
        
        private void btnCode_Click(object sender, EventArgs e)
        {
            updateCode();
        }
    }
}
