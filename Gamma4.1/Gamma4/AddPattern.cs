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
    public partial class AddPattern : Form
    {
        formMain parent;
        public AddPattern(Pattern pattern, formMain _parent)
        {
            InitializeComponent();
            parent = _parent;
            if (pattern == null)
            {
                AddPattern.ActiveForm.Text = "Введите новые данные";
                comboBox1.SelectedIndex = 0;
                textBox1.Text = "0";
                comboBox2.SelectedIndex = 0;
                comboBox3.SelectedIndex = 0;
            }
            else
            {
                AddPattern.ActiveForm.Text = "Измените данные";
                comboBox1.SelectedIndex = pattern.Type;
                textBox1.Text = pattern.Length.ToString();
                comboBox2.SelectedIndex = pattern.direction;
                comboBox3.SelectedIndex = pattern.color;
            }
        }
        
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
                parent.tPattern = new Pattern(int.Parse(textBox1.Text), comboBox1.SelectedIndex, comboBox2.SelectedIndex, comboBox3.SelectedIndex);
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
    }
}
