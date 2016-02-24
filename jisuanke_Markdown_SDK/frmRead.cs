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
            update.text += "---";
            update.text += Environment.NewLine;
            update.text += ("- " + txtTag.Text);
            update.text += Environment.NewLine;
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
        }
        private void btnRead_Click(object sender, EventArgs e)
        {
            updateRead();
        }
    }
}
