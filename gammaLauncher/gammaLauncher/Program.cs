using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;

namespace gammaLauncher
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                string fileName = string.Empty;
                for (int i = 0; i < args.Length; i++)
                {
                    if (args[i] == "-load")
                    {
                        //get filename
                        fileName = args[i + 1];//.Replace("^", " ");
                        StartGamma(fileName);
                        return;
                    }
                }

                OpenFileDialog oFDialog = new OpenFileDialog();
                oFDialog.Title = "Выберите файл упражнений";
                oFDialog.Filter = "Файлы упражнений (*.gsf) | *.gsf";
                if (oFDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = oFDialog.FileName;
                    StartGamma(fileName);
                }
            }
            catch
            { }
        }

        static void StartGamma(string fileName)
        {
            Process newApplication = new Process();
            newApplication.StartInfo.FileName = "gamma.exe";
            Rectangle screen = Screen.PrimaryScreen.Bounds;
            //fileName = fileName.Replace(" ", "^");
            newApplication.StartInfo.Arguments = string.Format("-screen-width {0} -screen-height {1} -file \"{2}\"", screen.Width, screen.Height, fileName);

            newApplication.Start();
            newApplication.WaitForExit();
        }
    }
}
