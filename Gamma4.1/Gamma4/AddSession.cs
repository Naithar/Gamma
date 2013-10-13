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
    public partial class AddSession : Form
    {
        formMain parent;
        public AddSession(string title, formMain _parent)
        {
            InitializeComponent();
            parent = _parent;
            textBox1.Text = title;
            if (title == "")
                this.Text = "Введите название нового сеанса";
            else
                this.Text = "Измените название текущего сеанса";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parent._com = textBox1.Text;
            parent.dRes = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            parent.dRes = DialogResult.Cancel;
            this.Close();
        }
    }
}
