using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gamma4
{
    public partial class ResultComment : Form
    {
        formMain parent;
        public ResultComment(string com, formMain _parent)
        {
            parent = _parent;
            InitializeComponent();
            comment.Text = com;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            parent._com = comment.Text;
            parent.dRes = DialogResult.OK;
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            parent.dRes = DialogResult.Cancel;
            this.Close();
        }
    }
}
