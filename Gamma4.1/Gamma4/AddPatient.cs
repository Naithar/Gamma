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
    public partial class AddPatient : Form
    {
        formMain parent;
        List<string> names;
        string cName;
        public AddPatient(List<string> patientsName, string title, formMain _parent)
        {
            InitializeComponent();
            if (title == "")
                this.Text = "Введите ФИО нового пациента";
            else
                this.Text = "Введите новое ФИО пациента";
            parent = _parent;
            names = new List<string>(patientsName);
            cName = title;
            textBox1.Text = title;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckDoubles(textBox1.Text, ((this.Text == "Введите новое ФИО пациента") ? cName : "")))
            {
                parent._com = textBox1.Text;
                parent.dRes = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Введенное имя присутствует в базе или неверно", "Внимание");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            parent.dRes = DialogResult.Cancel;
            this.Close();
        }

        private bool CheckDoubles(string name, string curName="")
        {
            for (int i = 0; i < names.Count; i++)
                if (names[i] == name || name == curName)
                    return false;
            return true;
        }
    }
}
