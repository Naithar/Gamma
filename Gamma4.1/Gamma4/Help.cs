using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Gamma4
{
    public partial class formHelp : Form
    {
        public formHelp(string fileName)
        {
            try
            {
                InitializeComponent();
                TextReader stream = new StreamReader("help/" + fileName);
                labelHelp.Text = stream.ReadToEnd();
                stream.Close();
            }
            catch (Exception)
            {
                labelHelp.Text = "Внимание!" +
                    "\nЕсли вы видите это сообщение, значит было повреждено имя целевого файла справки." +
                    "\nПожалуйста, проверьте и исправьте, в случае необходимости, имена файлов. Файлы расположены в директории 'help' в основной директории программы. Расширение файлов '.txt'" +
                    "\nИмена файлов:" +
                    "\nГлавная - 'mainHelp'" +
                    "\nПациенты - 'patientHelp'" +
                    "\nСеансы - 'sessionHelp'" +
                    "\nУровни - 'levelsHelp'" +
                    "\nРезультаты - 'resultHelp'" +
                    "\nПалитра - 'palitreHelp'" +
                    "\nЭкран - 'screenHelp'" +
                    "\nЗавершение сеанса - 'finishHelp'";
            }
        }
    }
}
