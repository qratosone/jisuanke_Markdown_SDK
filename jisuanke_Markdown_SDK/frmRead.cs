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
    public partial class frmRead : Form
    {
        public Info update;
        public frmRead()
        {
            InitializeComponent();
        }
        public void updateTitle()
        {
            update.text += ("# " + txtTitle.Text);
            update.text += Environment.NewLine;
            update.text += ("- " + txtTag.Text);
            update.text += Environment.NewLine;
            txtTitle.Text = "已更新标题";
            txtTag.Text = "已更新tag";
        }
        private void btnTitle_Click(object sender, EventArgs e)
        {
            updateTitle();
        }
        public void updateRead()
        {
            update.text += Environment.NewLine;
            update.text += "---";
            update.text += Environment.NewLine;
            update.text += txtRead.Text;
            update.text += Environment.NewLine;
            txtRead.Text = "已更新阅读课";
        }
        private void btnRead_Click(object sender, EventArgs e)
        {
            updateRead();
        }

        private void txtRead_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                ((TextBox)sender).SelectAll();
            }
        }

        private void frmRead_Load(object sender, EventArgs e)
        {

        }
    }
}
