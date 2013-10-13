using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClassesLib;

namespace Gamma4
{
    public partial class AddTask : Form
    {
        formMain parent;
        public AddTask(Task task, formMain _parent)
        {
            InitializeComponent();
            parent = _parent;
            if (task == null)
            {
                AddTask.ActiveForm.Text = "Введите новые данные";
                comboBox1.SelectedIndex = 0;
                textBox1.Text = "0";
                radioButton1.Checked = true;
                checkBox1.Checked = false;
                textBox2.Text = "0";
                checkBox2.Checked = false;
                checkBox2.Enabled = false;
            }
            else
            {
                AddTask.ActiveForm.Text = "Измените данные";
                comboBox1.SelectedIndex = task.Type;
                textBox1.Text = task.Length.ToString();
                checkBox2.Checked = task.hitObject;
                switch (task.BlinkType)
                {
                    case 0:
                        radioButton1.Checked = true;
                        break;
                    case 1:
                        radioButton2.Checked = true;
                        break;
                    case 2:
                        radioButton3.Checked = true;
                        break;
                    default:
                        radioButton1.Checked = true;
                        break;
                }
                textBox2.Text = task.BlinkPeriod.ToString();
                checkBox1.Checked = task.Rotation;
            }
        }
        //контроль цифр
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
                if ((e.KeyChar != (char)Keys.Back))
                    if (e.KeyChar == '.' || e.KeyChar == ',')
                        e.KeyChar = System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator[0];
                    else
                        e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                int bt = (radioButton1.Checked) ? 0 : ((radioButton2.Checked) ? 1 : 2);
                parent.tTask = new Task(comboBox1.SelectedIndex, int.Parse(textBox1.Text), checkBox2.Checked, checkBox1.Checked, bt, int.Parse(textBox2.Text));
                parent.dRes = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Выберите тип", "Внимание");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            parent.dRes = DialogResult.Cancel;
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 1:
                    checkBox2.Checked = false;
                    checkBox2.Enabled = true;
                    break;
                default:
                    checkBox2.Checked = false;
                    checkBox2.Enabled = false;
                    break;
            }
        }
    }
}
