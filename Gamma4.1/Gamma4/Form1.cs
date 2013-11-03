using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;
using ClassesLib;

namespace Gamma4
{
    public partial class formMain : Form
    {
        //переменные модели данных
        ClassesLib.Screen screenData = new ClassesLib.Screen();                 //экран
        Patients patientsList;                                                  //список всех пациентов
        //глобальные переменные
        public bool saved = true;                                               //сохранено ли текущее значение на панели
        private const string file = "settings/patients.xml";                    //путь к файлу с пациентами
        private const string screenFile = "settings/screen.xml";                //путь к файлу с настройками экрана
        private const string resultsFile = "settings/SessionResults.xml";       //путь к файлу с результатами сеансов
        //переменные для обмена данными между формами
        public string _com = string.Empty;                                      //комментарий, 
        public DialogResult dRes = new DialogResult();                          //результат диалога
        public Task tTask;                                                      //созданное задание
        public Pattern tPattern;                                                //созданный паттерн
        //инициализация формы
        public formMain()
        {
            InitializeComponent();
            HidePanels();
            patientsList = new Patients();
            patientsList.currentPatient = -1;
            patientsList.patients = new List<Patient>();
            //загрузка из файлов
            if (File.Exists(screenFile))
                screenData = ClassesLib.Screen.Read(screenFile);
            if (File.Exists(file))
            {
                patientsList = Patients.Read(file);
                if (File.Exists(resultsFile))
                    ResultsToPatients();
            }
            //обновление модели данных
            if (patientsList.patients.Count != 0)
            {
                if (patientsList.currentPatient == -1 && patientsList.currentPatient > patientsList.patients.Count)
                    patientsList.currentPatient = 0;
                panelMain.Visible = true;
                MainPanelShowInfo(patientsList.patients[patientsList.currentPatient]);
            }
            else
            {
                panelPacients.Visible = true;
                PatientShowInfo(patientsList); 
                ShowButtons();
                buttonPacients.Visible = false;
                buttonStart.Visible = false;
                buttonSessions.Visible = false;
                buttonLevels.Visible = false;
                buttonResults.Visible = false;
                buttonPalitre.Visible = false;
                buttonMain.Visible = false;
                MessageBox.Show("Выберите пациента или создайте нового", "Внимание");
            }
        }

        #region Навигация
        //функция убирания всех панелей
        private void HidePanels()
        {
            panelMain.Visible = false;
            panelPacients.Visible = false;
            panelSessions.Visible = false;
            panelLevels.Visible = false;
            panelResults.Visible = false;
            panelPalitre.Visible = false;
            panelScreen.Visible = false;
            panelFinish.Visible = false;
        }
        //функция отображения всех кнопок
        private void ShowButtons()
        {
            buttonStart.Visible = true;
            buttonPacients.Visible = true;
            buttonSessions.Visible = true;
            buttonLevels.Visible = true;
            buttonResults.Visible = true;
            buttonMain.Visible = true;
            buttonPalitre.Visible = true;
            buttonScreen.Visible = true;
            buttonExit.Visible = true;
        }
        //кнопка перехода на главную страницу
        private void buttonMain_Click(object sender, EventArgs e)
        {
            if (saved == false)
            {
                MessageBox.Show("Сначала сохраните изменения", "Внимание");
                return;
            }
            HidePanels();
            panelMain.Visible = true;
            ShowButtons();
            buttonMain.Visible = false;
            MainPanelShowInfo(patientsList.patients[patientsList.currentPatient]);
        }
        //кнопка перехода на страницу пациентов
        private void buttonPacients_Click(object sender, EventArgs e)
        {
            if (saved == false)
            {
                MessageBox.Show("Сначала сохраните изменения", "Внимание");
                return;
            }
            HidePanels();
            panelPacients.Visible = true;
            ShowButtons();
            buttonPacients.Visible = false;
            buttonScreen.Visible = false;
            PatientShowInfo(patientsList);
        }
        //кнопка перехода на страницу сеансов
        private void buttonSessions_Click(object sender, EventArgs e)
        {
            if (saved == false)
            {
                MessageBox.Show("Сначала сохраните изменения", "Внимание");
                return;
            }
            HidePanels();
            panelSessions.Visible = true;
            ShowButtons();
            buttonSessions.Visible = false;
            buttonResults.Visible = false;
            buttonPalitre.Visible = false;
            buttonScreen.Visible = false;
            SessionShowInfo(patientsList.patients[patientsList.currentPatient]);
        }
        //кнопка перехода на страницу уровней
        private void buttonLevels_Click(object sender, EventArgs e)
        {
            if (saved == false)
            {
                MessageBox.Show("Сначала сохраните изменения", "Внимание");
                return;
            }
            HidePanels();
            panelLevels.Visible = true;
            ShowButtons();
            buttonLevels.Visible = false;
            buttonResults.Visible = false;
            buttonPalitre.Visible = false;
            buttonScreen.Visible = false;
            LevelShowInfo(patientsList.patients[patientsList.currentPatient]);
        }
        //кнопка перехода на страницу результатов
        private void buttonResults_Click(object sender, EventArgs e)
        {
            if (saved == false)
            {
                MessageBox.Show("Сначала сохраните изменения", "Внимание");
                return;
            }
            HidePanels();
            panelResults.Visible = true;
            ShowButtons();
            buttonSessions.Visible = false;
            buttonLevels.Visible = false;
            buttonResults.Visible = false;
            buttonPalitre.Visible = false;
            buttonScreen.Visible = false;
            ResultsShowInfo(patientsList.patients[patientsList.currentPatient]);
        }
        //кнопка перехода на страницу палитры
        private void buttonPalitre_Click(object sender, EventArgs e)
        {
            if (saved == false)
            {
                MessageBox.Show("Сначала сохраните изменения", "Внимание");
                return;
            }
            HidePanels();
            panelPalitre.Visible = true;
            ShowButtons();
            buttonSessions.Visible = false;
            buttonLevels.Visible = false;
            buttonResults.Visible = false;
            buttonPalitre.Visible = false;
            buttonScreen.Visible = false;
            //вызов функций
            PalitreShowInfo(patientsList.patients[patientsList.currentPatient].Palitre);
            saved = true;
            PalitreDrawEilerCircls();
        }
        //кнопка перехода на страницу экрана
        private void buttonScreen_Click(object sender, EventArgs e)
        {
            if (saved == false)
            {
                MessageBox.Show("Сначала сохраните изменения", "Внимание");
                return;
            }
            HidePanels();
            panelScreen.Visible = true;
            ShowButtons();
            buttonSessions.Visible = false;
            buttonLevels.Visible = false;
            buttonResults.Visible = false;
            buttonPalitre.Visible = false;
            buttonScreen.Visible = false;
            //вызов функций
            ScreenShowInfo(screenData);
        }
        //кнопка запуска текущего сеанса
        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (saved == false)
            {
                MessageBox.Show("Сначала сохраните изменения", "Внимание");
                return;
            }
            HidePanels();
            panelFinish.Visible = true;
            ShowButtons();
            buttonStart.Visible = false;
            buttonSessions.Visible = false;
            buttonLevels.Visible = false;
            buttonPalitre.Visible = false;
            buttonScreen.Visible = false;
            //формируется файл сеанса
            //запускаем визуализацию
            //ждем окончания работы программы
            if (File.Exists(resultsFile))
                ResultsToPatients();
            FinishShowInfo(patientsList.patients[patientsList.currentPatient]);
        }
        //кнопка выхода
        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (saved == false)
            {
                MessageBox.Show("Сначала сохраните изменения", "Внимание");
                return;
            }
            this.Dispose();
        }
        #endregion

        #region Главная панель
        //вызов справки
        private void buttonMainInfo_Click(object sender, EventArgs e)
        {

        }
        //вызов окна помощи
        private void buttonMainHelp_Click(object sender, EventArgs e)
        {
            ShowHelp("mainHelp.txt");
        }
        //вызов информации о программе
        private void buttonMainAbout_Click(object sender, EventArgs e)
        {

        }
        //вывод информации на панель
        public void MainPanelShowInfo(Patient patient)
        {
            textBoxMainPacient.Text = patient.Name;
            textBoxMainPacientComment.Text = patient.Comment;
            if (patient.sessions.Count > 0 && patient.CurrentSession < patient.sessions.Count)
            {
                textBoxMainSession.Text = patient.sessions[patient.CurrentSession].Name;
                textBoxMainSessionComment.Text = patient.sessions[patient.CurrentSession].Comment;
            }
            if (patient.levels.Count > 0 && patient.CurrentLevel < patient.levels.Count)
            {
                textBoxMainLevel.Text = patient.levels[patient.CurrentLevel].Name;
                textBoxMainLevelComment.Text = patient.levels[patient.CurrentLevel].Comment;
            }
            textBoxMainFromMonitor.Text = patient.FromMonitor.ToString();
            if (patient.results.Count > 0)
            {
                textBoxMainLatestResult.Text = patient.results[patient.results.Count - 1].Balls.ToString();
                textBoxMainSessionDuration.Text = patient.results[patient.results.Count - 1].Length.ToString();
            }
            textBoxMainRedFilter.Text = (patient.RedOnRight == true) ? "правый" : "левый";
        }
        #endregion

        #region Пациенты
        int currentPatient = new int();                                     //текущий пациент
        List<Patient> bufferPatients = new List<Patient>();                 //пациенты
        //вызов окна помощи
        private void buttonPacientsHelp_Click(object sender, EventArgs e)
        {
            ShowHelp("patientHelp.txt");
        }
        //загрузка информации о пациенте
        private void PatientShowInfo(Patients patients)
        {
            bufferPatients = new List<Patient>(patients.patients);
            currentPatient = patients.currentPatient;
            UpdateComboBoxList();
            FillPatient();
            saved = true;
            buttonPacientsSave.Enabled = false;
            buttonPacientsCancel.Enabled = false;
        }
        //обновление списка пациентов в комбобоксе
        private void UpdateComboBoxList()
        {
            comboBoxPacients.Items.Clear();
            for (int i = 0; i < bufferPatients.Count; i++)
                comboBoxPacients.Items.Add(bufferPatients[i].Name);
        }
        //заполнение полей
        private void FillPatient()
        {
            if (currentPatient >= 0 && currentPatient < bufferPatients.Count)
            {
                comboBoxPacients.SelectedIndex = currentPatient;
                textBoxPacientComment.Text = bufferPatients[currentPatient].Comment;
                if (bufferPatients[currentPatient].RedOnRight)
                    radioButtonPacientsFilterRight.Checked = true;
                else
                    radioButtonPacientsFilterLeft.Checked = true;
                textBoxPacientsFromMonitor.Text = bufferPatients[currentPatient].FromMonitor.ToString();
            }
            else
            {
                comboBoxPacients.Items.Clear();
                comboBoxPacients.SelectedIndex = -1;
                textBoxPacientComment.Text = "";
                textBoxPacientsFromMonitor.Text = "";
                radioButtonPacientsFilterRight.Checked = false;
                radioButtonPacientsFilterLeft.Checked = false;
                saved = true;
                buttonPacientsSave.Enabled = false;
                buttonPacientsCancel.Enabled = false;
            }
            if (comboBoxPacients.Items.Count != 0)
            {
                buttonPacientsArch.Enabled = true;
                buttonPacientsDel.Enabled = true;
            }
            else
            {
                buttonPacientsArch.Enabled = false;
                buttonPacientsDel.Enabled = false;
            }
        }
        //отмечен красный на правом
        private void radioButtonPacientsFilterRight_CheckedChanged(object sender, EventArgs e)
        {
            if (currentPatient >= 0 && currentPatient < bufferPatients.Count)
            {
                //if (radioButtonPacientsFilterRight.Checked)
                //{
                //    radioButtonPacientsFilterRight.Checked = true;
                //    radioButtonPacientsFilterLeft.Checked = false;
                //}
                //else
                //{
                //    radioButtonPacientsFilterRight.Checked = false;
                //    radioButtonPacientsFilterLeft.Checked = true;
                //}
                bufferPatients[currentPatient].RedOnRight = radioButtonPacientsFilterRight.Checked;
                saved = false;
                buttonPacientsSave.Enabled = true;
                buttonPacientsCancel.Enabled = true;
            }
        }
        //отмечен красный на левом 
        private void radioButtonPacientsFilterLeft_CheckedChanged(object sender, EventArgs e)
        {
            if (currentPatient >= 0 && currentPatient < bufferPatients.Count)
            {
                //if (radioButtonPacientsFilterLeft.Checked)
                //{
                //    radioButtonPacientsFilterRight.Checked = false;
                //    radioButtonPacientsFilterLeft.Checked = true;
                //}
                //else
                //{
                //    radioButtonPacientsFilterRight.Checked = true;
                //    radioButtonPacientsFilterLeft.Checked = false;
                //}
                saved = false;
                buttonPacientsSave.Enabled = true;
                buttonPacientsCancel.Enabled = true;
            }
        }
        //выбран другой пациент
        private void comboBoxPacients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (saved)
            {
                saved = false;
                buttonPacientsSave.Enabled = true;
                buttonPacientsCancel.Enabled = true;
                currentPatient = comboBoxPacients.SelectedIndex;
                FillPatient();
            }
            else
                MessageBox.Show("Сначала сохраните внесенные изменения", "Внимание");
        }
        //изменен текст коментария
        private void textBoxPacientComment_TextChanged(object sender, EventArgs e)
        {
            if (currentPatient >= 0 && currentPatient < bufferPatients.Count)
            {
                bufferPatients[currentPatient].Comment = textBoxPacientComment.Text;
                Int32 a;
                bufferPatients[currentPatient].FromMonitor = (int.TryParse(textBoxPacientsFromMonitor.Text, out a)) ? (int.Parse(textBoxPacientsFromMonitor.Text)) : 65;
                saved = false;
                buttonPacientsSave.Enabled = true;
                buttonPacientsCancel.Enabled = true;
            }
        }
        //создание пациента
        private void buttonPacientsCreate_Click(object sender, EventArgs e)
        {
            List<string> names = new List<string>();
            for (int i = 0; i < patientsList.patients.Count; i++)
                names.Add(patientsList.patients[patientsList.currentPatient].Name);
            AddPatient form = new AddPatient(names, "", this);
            form.ShowDialog(this);
            if (dRes == DialogResult.OK)
            {
                if (comboBoxPacients.Items.Count == 0)
                {
                    ShowButtons();
                    buttonPacients.Visible = false;
                    buttonScreen.Visible = false;
                }
                bufferPatients.Add(new Patient(_com, ""));
                currentPatient = bufferPatients.Count - 1;
                //добавление базовых сеансов
                bufferPatients[currentPatient].sessions.Add(new Session("Демонстрационный", "Сеанс демонстрирует основные упражнения и паттерны", 110));
                bufferPatients[currentPatient].CurrentSession = 0;
                bufferPatients[currentPatient].sessions[0].tasks.Add(new Task(1, 30));
                bufferPatients[currentPatient].sessions[0].tasks.Add(new Task(2, 30));
                bufferPatients[currentPatient].sessions[0].tasks.Add(new Task(3, 30));
                bufferPatients[currentPatient].sessions[0].patterns.Add(new Pattern(10, 1));
                bufferPatients[currentPatient].sessions[0].patterns.Add(new Pattern(10, 2));
                bufferPatients[currentPatient].sessions.Add(new Session("Базовый", "Базовый сеанс", 320));
                bufferPatients[currentPatient].sessions[1].tasks.Add(new Task(1, 30));
                bufferPatients[currentPatient].sessions[1].tasks.Add(new Task(1, 30, true));
                bufferPatients[currentPatient].sessions[1].tasks.Add(new Task(1, 30, false, false, 1, 500));
                bufferPatients[currentPatient].sessions[1].tasks.Add(new Task(1, 30, false, false, 2, 500));
                bufferPatients[currentPatient].sessions[1].tasks.Add(new Task(2, 30, true));
                bufferPatients[currentPatient].sessions[1].tasks.Add(new Task(2, 30, false, false, 1, 500));
                bufferPatients[currentPatient].sessions[1].tasks.Add(new Task(3, 30, false, true, 1, 500));
                bufferPatients[currentPatient].sessions[1].tasks.Add(new Task(3, 30, false, false, 2, 500));
                bufferPatients[currentPatient].sessions[1].patterns.Add(new Pattern(10, 1));
                bufferPatients[currentPatient].sessions[1].patterns.Add(new Pattern(10, 2));
                bufferPatients[currentPatient].sessions[1].patterns.Add(new Pattern(10, 1));
                bufferPatients[currentPatient].sessions[1].patterns.Add(new Pattern(10, 2));
                bufferPatients[currentPatient].sessions[1].patterns.Add(new Pattern(10, 1));
                bufferPatients[currentPatient].sessions[1].patterns.Add(new Pattern(10, 2));
                bufferPatients[currentPatient].sessions[1].patterns.Add(new Pattern(20, 0));
                //добавление базовых уровней
                bufferPatients[currentPatient].levels.Add(new Level("Простой", "Самый простой уровень сложности", 1, 50, 50, 200, 10, 0, 0, 0));
                bufferPatients[currentPatient].levels.Add(new Level("Средний", "Средний уровень сложности", 1, 25, 25, 100, 10, 50, 50, 50));
                bufferPatients[currentPatient].levels.Add(new Level("Сложный", "Сложный уровень", 1, 5, 5, 50, 10, 100, 100, 100));
                bufferPatients[currentPatient].CurrentLevel = 1;
                //добавление палитры
                bufferPatients[currentPatient].Palitre = new Palitre();
                bufferPatients[currentPatient].palitre.iRed = -10092288;
                bufferPatients[currentPatient].palitre.iBlue = -16754588;
                bufferPatients[currentPatient].palitre.iBG = -10395295;
                //обновление списка
                UpdateComboBoxList();
                FillPatient();
                saved = false;
                buttonPacientsSave.Enabled = true;
                buttonPacientsCancel.Enabled = true;
            }

        }
        //изменение имени пациента
        private void buttonPacientsChangeName_Click(object sender, EventArgs e)
        {
            if (comboBoxPacients.Items.Count == 0)
                return;
            List<string> names = new List<string>();
            for (int i = 0; i < patientsList.patients.Count; i++)
                names.Add(patientsList.patients[patientsList.currentPatient].Name);
            AddPatient form = new AddPatient(names, bufferPatients[currentPatient].Name, this);
            form.ShowDialog();
            if (dRes == DialogResult.OK)
            {
                bufferPatients[currentPatient].Name = _com;
                UpdateComboBoxList();
                FillPatient();
                saved = false;
                buttonPacientsSave.Enabled = true;
                buttonPacientsCancel.Enabled = true;
            }
        }
        //сохранение пациента
        private void buttonPacientsSave_Click(object sender, EventArgs e)
        {
            patientsList.patients =  bufferPatients;
            patientsList.currentPatient = currentPatient;
            Patients.Write(file, patientsList);
            saved = true;
            buttonPacientsSave.Enabled = false;
            buttonPacientsCancel.Enabled = false;
        }
        //отмена изменений пациента
        private void buttonPacientsCancel_Click(object sender, EventArgs e)
        {
            saved = true;
            buttonPacientsSave.Enabled = false;
            buttonPacientsCancel.Enabled = false;
            patientsList = Patients.Read(file);
            PatientShowInfo(patientsList);
        }
        //удаление пациента
        private void buttonPacientsDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите безвозвратно удалить пациента?", "Внимание!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                bufferPatients.RemoveAt(currentPatient);
                currentPatient = 0;
                patientsList.patients = bufferPatients;
                patientsList.currentPatient = currentPatient;
                Patients.Write(file, patientsList);
                UpdateComboBoxList();
                FillPatient();
                saved = true;
                buttonPacientsSave.Enabled = false;
                buttonPacientsCancel.Enabled = false;
                //после удаления последнего пациента
                if (comboBoxPacients.Items.Count == 0)
                {
                    comboBoxPacients.Text = "";
                    buttonPacients.Visible = false;
                    buttonStart.Visible = false;
                    buttonSessions.Visible = false;
                    buttonLevels.Visible = false;
                    buttonResults.Visible = false;
                    buttonPalitre.Visible = false;
                    buttonMain.Visible = false;
                    MessageBox.Show("Выберите пациента или создайте нового", "Внимание");
                }
            }
        }
        //пациент в архив
        private void buttonPacientsArch_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите отправить все данные пациента в архив?", "Внимание!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                bufferPatients[currentPatient].Write("archive/" + bufferPatients[currentPatient].Name + "_" + DateTime.Now.ToShortDateString()+".xml", bufferPatients[currentPatient]);
                bufferPatients.RemoveAt(currentPatient);
                currentPatient = 0;
                patientsList.patients = bufferPatients;
                patientsList.currentPatient = currentPatient;
                Patients.Write(file, patientsList);
                UpdateComboBoxList();
                FillPatient();
                saved = true;
                buttonPacientsSave.Enabled = false;
                buttonPacientsCancel.Enabled = false;
            }
        }
        #endregion

        #region Сеансы
        List<Session> bufferSessions;
        int currentSession,
            currentTask = -1,
            currentPattern = -1;
        //вызов окна помощи
        private void buttonSessionsHelp_Click(object sender, EventArgs e)
        {
            ShowHelp("sessionHelp.txt");
        }
        //загрузка информации в окно
        private void SessionShowInfo(Patient patient)
        {
            bufferSessions = patient.sessions;
            currentSession = patient.CurrentSession;
            UpdateSessionComboBoxList();
            comboBoxSession.SelectedIndex = currentSession;
            FillSession();
            saved = true;
            buttonSessionsSave.Enabled = false;
            buttonSessionsCancel.Enabled = false;
        }
        //обновление списка сеансов в комбобоксе
        private void UpdateSessionComboBoxList()
        {
            comboBoxSession.Items.Clear();
            for (int i = 0; i < bufferSessions.Count; i++)
                comboBoxSession.Items.Add(bufferSessions[i].Name);
        }
        //обновление полей
        private void FillSession()
        {
            textBoxSessionComment.Text = bufferSessions[currentSession].Comment;
            checkBoxSessionsPaternsAuto.Checked = !bufferSessions[currentSession].AutoPatterns;
            UpdateTaskListView();
            UpdatePatternListView();
            textBoxSessionDuration.Text = SessionLength().ToString();
            if (currentSession <= 1)
            {
                textBoxSessionComment.Enabled = false;
                checkBoxSessionsPaternsAuto.Enabled = false;
                listViewSessionsTasks.Enabled = false;
                listViewSessionsPaterns.Enabled = false;
                buttonSessionsForm.Enabled = false;
                buttonSessionsPaternsForm.Enabled = false;
                buttonSessionsDel.Enabled = false;
            }
            else
            {
                textBoxSessionComment.Enabled = true;
                checkBoxSessionsPaternsAuto.Enabled = true;
                listViewSessionsTasks.Enabled = true;
                //listViewSessionsPaterns.Enabled = true;
                buttonSessionsForm.Enabled = true;
                buttonSessionsPaternsForm.Enabled = true;
                buttonSessionsDel.Enabled = true;
            }
        }
        //обновление списка упраженений
        private void UpdateTaskListView()
        {
            ListViewItem bufLVI;
            listViewSessionsTasks.Items.Clear();
            for (int i = 0; i < bufferSessions[currentSession].tasks.Count; i++)
            {
                bufLVI = new ListViewItem(new string[] { (i + 1).ToString(), Session.TaskName(bufferSessions[currentSession].tasks[i].Type), bufferSessions[currentSession].tasks[i].Length.ToString() });
                listViewSessionsTasks.Items.Add(bufLVI);
            }
        }
        //обновление списка паттернов
        private void UpdatePatternListView()
        {
            ListViewItem bufLVI;
            listViewSessionsPaterns.Items.Clear();
            for (int i = 0; i < bufferSessions[currentSession].patterns.Count; i++)
            {
                Session s = new Session();
                bufLVI = new ListViewItem(new string[] { (i + 1).ToString(), Session.PatternName(bufferSessions[currentSession].patterns[i].Type), bufferSessions[currentSession].patterns[i].Length.ToString() });
                listViewSessionsPaterns.Items.Add(bufLVI);
            }
        }
        //возвращает длительность текущего сеанса
        private int SessionLength()
        {
            int l = 0;
            for (int i = 0; i < bufferSessions[currentSession].tasks.Count; i++)
                l += bufferSessions[currentSession].tasks[i].Length;
            for (int i = 0; i < bufferSessions[currentSession].patterns.Count; i++)
                l += bufferSessions[currentSession].patterns[i].Length;
            return l;
        }
        //изменен выбор сеанса
        private void comboBoxSession_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentSession = comboBoxSession.SelectedIndex;
            FillSession();
            saved = false;
            buttonSessionsSave.Enabled = true;
            buttonSessionsCancel.Enabled = true;
        }
        //автоввод паттернов
        private void checkBoxSessionsPaternsAuto_CheckedChanged(object sender, EventArgs e)
        {
                if (checkBoxSessionsPaternsAuto.Checked)
                    listViewSessionsPaterns.Enabled = true;
                else
                    listViewSessionsPaterns.Enabled = false;
                saved = false;
                buttonSessionsSave.Enabled = true;
                buttonSessionsCancel.Enabled = true;
        }
        //удаление сеанса
        private void buttonSessionsDel_Click(object sender, EventArgs e)
        {
            if (currentSession > 1)
            {
                if (MessageBox.Show("Вы действительно хотите удалить текущий сеанс?", "Внимание", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    bufferSessions.RemoveAt(currentSession);
                    UpdateSessionComboBoxList();
                    currentSession = 0;
                    comboBoxSession.SelectedIndex = currentSession;
                    FillSession();
                    saved = false;
                    buttonSessionsSave.Enabled = true;
                    buttonSessionsCancel.Enabled = true;
                }
            }
            else
                MessageBox.Show("Невозможно удалить выбранный сеанс", "Внимание");
        }
        //добавление сеанса
        private void buttonSessionsCreate_Click(object sender, EventArgs e)
        {
            AddSession form = new AddSession("", this);
            form.ShowDialog(this);
            if (dRes == DialogResult.OK)
            {
                saved = false;
                buttonSessionsCancel.Enabled = true;
                buttonSessionsCancel.Enabled = true;
                bufferSessions.Add(new Session(_com, "", 0));
                UpdateSessionComboBoxList();
                currentSession = bufferSessions.Count - 1;
                comboBoxSession.SelectedIndex = currentSession;
                FillSession();
            }
        }
        //изменение названия сеанса
        private void button3_Click(object sender, EventArgs e)
        {
            if (currentSession > 1)
            {
                AddSession form = new AddSession(bufferSessions[currentSession].Name, this);
                form.ShowDialog(this);
                if (dRes == DialogResult.OK)
                {
                    saved = false;
                    buttonSessionsSave.Enabled = true;
                    buttonSessionsCancel.Enabled = true;
                    bufferSessions[currentSession].Name = _com;
                    UpdateSessionComboBoxList();
                    FillSession();
                }
            }
        }
        //сохранение сеансов
        private void buttonSessionsSave_Click(object sender, EventArgs e)
        {
            saved = true;
            buttonSessionsSave.Enabled = false;
            buttonSessionsCancel.Enabled = false;
            patientsList.patients[patientsList.currentPatient].sessions = bufferSessions;
            patientsList.patients[patientsList.currentPatient].currentSession = currentSession;
            Patients.Write(file, patientsList);
        }
        //отмена сеансов
        private void buttonSessionsCancel_Click(object sender, EventArgs e)
        {
            saved = true;
            buttonSessionsSave.Enabled = false;
            buttonSessionsCancel.Enabled = false;
            patientsList = Patients.Read(file);
            SessionShowInfo(patientsList.patients[patientsList.currentPatient]);
        }
        //выделение строки заданий
        private void listViewSessionsTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSessionsTasks.SelectedIndices.Count != 0)
            {
                currentTask = listViewSessionsTasks.SelectedIndices[0];
                if (currentTask != -1)
                {
                    toolStripMenuItemUp.Enabled = true;
                    toolStripMenuItemDown.Enabled = true;
                    toolStripMenuItemDel.Enabled = true;
                    toolStripMenuChanged.Enabled = true;
                }
                return;
            }
            toolStripMenuItemUp.Enabled = false;
            toolStripMenuItemDown.Enabled = false;
            toolStripMenuItemDel.Enabled = false;
            toolStripMenuChanged.Enabled = false;
        }
        //выделение строки паттернов
        private void listViewSessionsPaterns_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSessionsPaterns.SelectedIndices.Count != 0)
            {
                currentPattern = listViewSessionsPaterns.SelectedIndices[0];
                if (currentPattern != -1)
                {
                    toolStripMenuItem1.Enabled = true;
                    toolStripMenuItem2.Enabled = true;
                    toolStripMenuItem3.Enabled = true;
                    toolStripMenuItem4.Enabled = true;
                    toolStripMenuItem5.Enabled = true;
                }
                return;
            }
            toolStripMenuItem1.Enabled = false;
            toolStripMenuItem2.Enabled = false;
            toolStripMenuItem3.Enabled = true;
            toolStripMenuItem4.Enabled = false;
            toolStripMenuItem5.Enabled = false;
        }
        //добавление задания
        private void buttonSessionsForm_Click(object sender, EventArgs e)
        {
            AddTask form = new AddTask(null, this);
            form.ShowDialog(this);
            if (dRes == DialogResult.OK)
            {
                saved = false;
                buttonSessionsCancel.Enabled = true;
                buttonSessionsCancel.Enabled = true;
                bufferSessions[currentSession].tasks.Add(tTask);
                UpdateTaskListView();
                if (!checkBoxSessionsPaternsAuto.Checked)
                {
                    if (bufferSessions[currentSession].tasks.Count > 1 &&
                        bufferSessions[currentSession].patterns.Count < bufferSessions[currentSession].tasks.Count - 1)
                    {
                        bufferSessions[currentSession].patterns.Add(new Pattern(10, 0));
                        UpdatePatternListView();
                    }
                }
                textBoxSessionDuration.Text = SessionLength().ToString();
            }
        }
        //изменение задания
        private void toolStripMenuChanged_Click(object sender, EventArgs e)
        {
            if (listViewSessionsTasks.SelectedIndices.Count != 0)
            {
                AddTask form = new AddTask(bufferSessions[currentSession].tasks[currentTask], this);
                form.ShowDialog(this);
                if (dRes == DialogResult.OK)
                {
                    bufferSessions[currentSession].tasks[currentTask] = tTask;
                    saved = false;
                    buttonSessionsCancel.Enabled = true;
                    buttonSessionsCancel.Enabled = true;
                    UpdateTaskListView();
                    textBoxSessionDuration.Text = SessionLength().ToString();
                }
            }
        }
        //удаление задания
        private void toolStripMenuItemDel_Click(object sender, EventArgs e)
        {
            bufferSessions[currentSession].tasks.RemoveAt(currentTask);
            UpdateTaskListView(); 
            if (!checkBoxSessionsPaternsAuto.Checked)
            {
                if (bufferSessions[currentSession].tasks.Count == bufferSessions[currentSession].patterns.Count)
                    bufferSessions[currentSession].patterns.RemoveAt(bufferSessions[currentSession].patterns.Count - 1);
            }
            textBoxSessionDuration.Text = SessionLength().ToString();
        }
        //задание выше
        private void toolStripMenuItemUp_Click(object sender, EventArgs e)
        {
            if (currentTask > 0 && currentTask < bufferSessions[currentSession].tasks.Count)
            {
                Task buf = bufferSessions[currentSession].tasks[currentTask];
                bufferSessions[currentSession].tasks[currentTask] = bufferSessions[currentSession].tasks[currentTask - 1];
                bufferSessions[currentSession].tasks[currentTask - 1] = buf;
                UpdateTaskListView();
                textBoxSessionDuration.Text = SessionLength().ToString();
            }
        }
        //задание ниже
        private void toolStripMenuItemDown_Click(object sender, EventArgs e)
        {
            if (currentTask >= 0 && (currentTask + 1) < bufferSessions[currentSession].tasks.Count)
            {
                Task buf = bufferSessions[currentSession].tasks[currentTask];
                bufferSessions[currentSession].tasks[currentTask] = bufferSessions[currentSession].tasks[currentTask + 1];
                bufferSessions[currentSession].tasks[currentTask + 1] = buf;
                UpdateTaskListView();
                textBoxSessionDuration.Text = SessionLength().ToString();
            }
        }
        //добавление паттерна
        private void buttonSessionsPaternsForm_Click(object sender, EventArgs e)
        {
            if (checkBoxSessionsPaternsAuto.Checked)
            {
                AddPattern form = new AddPattern(null, this);
                form.ShowDialog(this);
                if (dRes == DialogResult.OK)
                {
                    saved = false;
                    buttonSessionsCancel.Enabled = true;
                    buttonSessionsCancel.Enabled = true;
                    bufferSessions[currentSession].patterns.Add(tPattern);
                    UpdatePatternListView();
                    textBoxSessionDuration.Text = SessionLength().ToString();
                }
            }
        }
        //изменение паттерна
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (checkBoxSessionsPaternsAuto.Checked)
            {
                AddPattern form = new AddPattern(bufferSessions[currentSession].patterns[currentPattern], this);
                form.ShowDialog(this);
                if (dRes == DialogResult.OK)
                {
                    bufferSessions[currentSession].patterns[currentPattern] = tPattern;
                    saved = false;
                    buttonSessionsCancel.Enabled = true;
                    buttonSessionsCancel.Enabled = true;
                    UpdatePatternListView();
                    textBoxSessionDuration.Text = SessionLength().ToString();
                }
            }
        }
        //удаление паттерна
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (checkBoxSessionsPaternsAuto.Checked)
            {
                bufferSessions[currentSession].patterns.RemoveAt(currentPattern);
                UpdatePatternListView();
                textBoxSessionDuration.Text = SessionLength().ToString();
            }
        }
        //паттерн выше
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (checkBoxSessionsPaternsAuto.Checked)
            {
                if (currentPattern > 0 && currentPattern < bufferSessions[currentSession].patterns.Count)
                {
                    Pattern buf = bufferSessions[currentSession].patterns[currentPattern];
                    bufferSessions[currentSession].patterns[currentPattern] = bufferSessions[currentSession].patterns[currentPattern - 1];
                    bufferSessions[currentSession].patterns[currentPattern - 1] = buf;
                    UpdatePatternListView();
                    textBoxSessionDuration.Text = SessionLength().ToString();
                }
            }
        }
        //паттерн ниже
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (checkBoxSessionsPaternsAuto.Checked)
            {
                if (currentPattern >= 0 && (currentPattern + 1) < bufferSessions[currentSession].patterns.Count)
                {
                    Pattern buf = bufferSessions[currentSession].patterns[currentPattern];
                    bufferSessions[currentSession].patterns[currentPattern] = bufferSessions[currentSession].patterns[currentPattern + 1];
                    bufferSessions[currentSession].patterns[currentPattern + 1] = buf;
                    UpdatePatternListView();
                    textBoxSessionDuration.Text = SessionLength().ToString();
                }
            }
        }
        //создание файла сеанса
        private void button1_Click(object sender, EventArgs e)
        {
            if (saved)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Gamma session files (*.gsf)|*.gsf";
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    InnerData.Write(sfd.FileName, new InnerData(patientsList.patients[patientsList.currentPatient]));
            }
            else
                MessageBox.Show("Сначала сохраните изменения", "Внимание");
        }
        #endregion

        #region Уровни
        List<Level> bufferLevels;
        int currentLevel;
        //вызов окна справки
        private void buttonLevelsHelp_Click(object sender, EventArgs e)
        {
            ShowHelp("levelsHelp.txt");
        }
        //загрузка информации в окно
        private void LevelShowInfo(Patient patient)
        {
            textBoxLevelsPacient.Text = patient.Name;
            bufferLevels = patient.levels; 
            currentLevel = patient.CurrentLevel;
            UpdateLevelComboBoxList();
            comboBoxLevels.SelectedIndex = currentLevel;
            LevelFillBoxes();
            saved = true;
            buttonLevelsSave.Enabled = false;
            buttonLevelsCancel.Enabled = false;
        }
        //обновление списка уровней в комбобоксе
        private void UpdateLevelComboBoxList()
        {
            comboBoxLevels.Items.Clear();
            for (int i = 0; i < bufferLevels.Count; i++)
                comboBoxLevels.Items.Add(bufferLevels[i].Name);
        }
        //реакция на изменение в полях
        private void textBoxLevels_TextChanged(object sender, EventArgs e)
        {
            saved = false;
            buttonLevelsSave.Enabled = true;
            buttonLevelsCancel.Enabled = true;
        }
        //заполнение полей
        private void LevelFillBoxes()
        {
            textBoxLevelsComment.Text = bufferLevels[currentLevel].Comment;
            textBoxLevelsToleranceHorizontal.Text = bufferLevels[currentLevel].HorizontalDeviation.ToString();
            textBoxLevelsToleranceVertical.Text = bufferLevels[currentLevel].VerticalDeviation.ToString();
            textBoxLevelsObjectCatch.Text = bufferLevels[currentLevel].showTimes.ToString();
            textBoxLevelsObjectSmallerK.Text = bufferLevels[currentLevel].ObjectK.ToString();
            textBoxLevelsBallsCatch.Text = bufferLevels[currentLevel].HitBalls.ToString();
            textBoxLevelsBonusAccur.Text = bufferLevels[currentLevel].BonusAccuracy.ToString();
            textBoxLevelsBonusDinamic.Text = bufferLevels[currentLevel].BonusDinamic.ToString();
            textBoxLevelsBonusSmall.Text = bufferLevels[currentLevel].BonusSize.ToString();
            if (currentLevel < 3)
            {
                textBoxLevelsComment.Enabled = false;
                textBoxLevelsToleranceHorizontal.Enabled = false;
                textBoxLevelsToleranceVertical.Enabled = false;
                textBoxLevelsObjectSmallerK.Enabled = false;
                textBoxLevelsObjectCatch.Enabled = false;
                //textBoxLevelsObjectMiss.Enabled = false;
                textBoxLevelsBallsCatch.Enabled = false;
                textBoxLevelsBonusAccur.Enabled = false;
                textBoxLevelsBonusDinamic.Enabled = false;
                textBoxLevelsBonusSmall.Enabled = false;
                buttonLevelsDelete.Enabled = false;
            }
            else
            {
                textBoxLevelsComment.Enabled = true;
                textBoxLevelsToleranceHorizontal.Enabled = true;
                textBoxLevelsToleranceVertical.Enabled = true;
                textBoxLevelsObjectSmallerK.Enabled = true;
                textBoxLevelsObjectCatch.Enabled = true;
                //textBoxLevelsObjectMiss.Enabled = true;
                textBoxLevelsBallsCatch.Enabled = true;
                textBoxLevelsBonusAccur.Enabled = true;
                textBoxLevelsBonusDinamic.Enabled = true;
                textBoxLevelsBonusSmall.Enabled = true;
                buttonLevelsDelete.Enabled = true;
            }
        }
        //изменение выбранного уровня
        private void comboBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            saved = false;
            buttonLevelsSave.Enabled = true;
            buttonLevelsCancel.Enabled = true;
            currentLevel = comboBoxLevels.SelectedIndex;
            LevelFillBoxes();
        }
        //сохранение
        private void buttonLevelsSave_Click(object sender, EventArgs e)
        {
            Int32 a;
            bufferLevels[currentLevel].Comment = textBoxLevelsComment.Text;
            bufferLevels[currentLevel].HorizontalDeviation = (int.TryParse(textBoxLevelsToleranceHorizontal.Text, out a)) ? int.Parse(textBoxLevelsToleranceHorizontal.Text) : 0;
            bufferLevels[currentLevel].VerticalDeviation = (int.TryParse(textBoxLevelsToleranceVertical.Text, out a)) ? int.Parse(textBoxLevelsToleranceVertical.Text) : 0;
            bufferLevels[currentLevel].showTimes = (int.TryParse(textBoxLevelsObjectCatch.Text, out a)) ? (int.Parse(textBoxLevelsObjectCatch.Text) < 1 ? 1 : int.Parse(textBoxLevelsObjectCatch.Text)) : 1;
            bufferLevels[currentLevel].ObjectK = (int.TryParse(textBoxLevelsObjectSmallerK.Text, out a)) ? int.Parse(textBoxLevelsObjectSmallerK.Text) : 0;
            bufferLevels[currentLevel].HitBalls = (int.TryParse(textBoxLevelsBallsCatch.Text, out a)) ? int.Parse(textBoxLevelsBallsCatch.Text) : 0;
            bufferLevels[currentLevel].BonusAccuracy = (int.TryParse(textBoxLevelsBonusAccur.Text, out a)) ? int.Parse(textBoxLevelsBonusAccur.Text) : 0;
            bufferLevels[currentLevel].BonusDinamic = (int.TryParse(textBoxLevelsBonusDinamic.Text, out a)) ? int.Parse(textBoxLevelsBonusDinamic.Text) : 0;
            bufferLevels[currentLevel].BonusSize = (int.TryParse(textBoxLevelsBonusSmall.Text, out a)) ? int.Parse(textBoxLevelsBonusSmall.Text) : 0;
            saved = true;
            buttonLevelsSave.Enabled = false;
            buttonLevelsCancel.Enabled = false;
            patientsList.patients[patientsList.currentPatient].levels = bufferLevels;
            patientsList.patients[patientsList.currentPatient].CurrentLevel = currentLevel;
            Patients.Write(file, patientsList);
        }
        //отмена
        private void buttonLevelsCancel_Click(object sender, EventArgs e)
        {
            patientsList = Patients.Read(file);
            LevelShowInfo(patientsList.patients[patientsList.currentPatient]);
            saved = true;
            buttonLevelsSave.Enabled = false;
            buttonLevelsCancel.Enabled = false;
        }
        //добавление уровня
        private void buttonLavelsUseForThisPacient_Click(object sender, EventArgs e)
        {
            AddLevel form = new AddLevel("", this);
            form.ShowDialog(this);
            if (dRes == DialogResult.OK)
            {
                saved = false;
                buttonLevelsCancel.Enabled = true;
                buttonLevelsSave.Enabled = true;
                bufferLevels.Add(new Level(_com));
                currentLevel = bufferLevels.Count - 1;
                UpdateLevelComboBoxList();
                comboBoxLevels.SelectedIndex = currentLevel;
                LevelFillBoxes();
            }
        }
        //изменение названия уровня
        private void button2_Click(object sender, EventArgs e)
        {
            if (currentLevel > 2)
            {
                AddLevel form = new AddLevel(bufferLevels[currentLevel].Name, this);
                form.ShowDialog(this);
                if (dRes == DialogResult.OK)
                {
                    saved = false;
                    buttonLevelsCancel.Enabled = true;
                    buttonLevelsSave.Enabled = true;
                    bufferLevels[currentLevel].Name = _com;
                    UpdateLevelComboBoxList();
                    comboBoxLevels.SelectedIndex = currentLevel;
                }
            }
            else
                MessageBox.Show("Невозможно изменить название стандартного уровня");
        }
        //удаление уровня
        private void buttonLevelsDelete_Click(object sender, EventArgs e)
        {
            if (currentLevel > 2)
            {
                if (MessageBox.Show("Вы действительно хотите удалить текущий уровень?", "Внимание", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    bufferLevels.RemoveAt(currentLevel);
                    saved = false;
                    buttonLevelsCancel.Enabled = true;
                    buttonLevelsSave.Enabled = true;
                    currentLevel = 1;
                    UpdateLevelComboBoxList();
                    comboBoxLevels.SelectedIndex = currentLevel;
                    LevelFillBoxes();
                }
            }
        }
        #endregion

        #region Палитра
        //вызов окна помощи
        private void buttonPalitreHelp_Click(object sender, EventArgs e)
        {
            ShowHelp("palitreHelp.txt");
        }
        //выбор красного цвета
        private void radioButtonPalitreColorsRed_CheckedChanged(object sender, EventArgs e)
        {
            trackBarPalitreR.Enabled = true;
            trackBarPalitreG.Enabled = true;
            trackBarPalitreB.Enabled = true;
            pictureBoxPalitres.Image = Gamma4.Properties.Resources.palitreRed;
            if (radioButtonPalitreColorsRed.Checked == true)
            {
                textBoxPalitreColorsRedR.Enabled = true;
                textBoxPalitreColorsRedG.Enabled = true;
                textBoxPalitreColorsRedB.Enabled = true;
                trackBarPalitreR.Value = int.Parse(textBoxPalitreColorsRedR.Text);
                trackBarPalitreG.Value = int.Parse(textBoxPalitreColorsRedG.Text);
                trackBarPalitreB.Value = int.Parse(textBoxPalitreColorsRedB.Text);        
            }
            else
            {
                textBoxPalitreColorsRedR.Enabled = false;
                textBoxPalitreColorsRedG.Enabled = false;
                textBoxPalitreColorsRedB.Enabled = false;
            }
        }
        //выбор синего цвета
        private void radioButtonPalitreColorsBlue_CheckedChanged(object sender, EventArgs e)
        {
            trackBarPalitreR.Enabled = true;
            trackBarPalitreG.Enabled = true;
            trackBarPalitreB.Enabled = true;
            pictureBoxPalitres.Image = Gamma4.Properties.Resources.palitreBlue;
            if (radioButtonPalitreColorsBlue.Checked == true)
            {
                textBoxPalitreColorsBlueR.Enabled = true;
                textBoxPalitreColorsBlueG.Enabled = true;
                textBoxPalitreColorsBlueB.Enabled = true;
                trackBarPalitreR.Value = int.Parse(textBoxPalitreColorsBlueR.Text);
                trackBarPalitreG.Value = int.Parse(textBoxPalitreColorsBlueG.Text);
                trackBarPalitreB.Value = int.Parse(textBoxPalitreColorsBlueB.Text);
            }
            else
            {
                textBoxPalitreColorsBlueR.Enabled = false;
                textBoxPalitreColorsBlueG.Enabled = false;
                textBoxPalitreColorsBlueB.Enabled = false;
            }
        }
        //выбор фона
        private void radioButtonPalitreColorsBackground_CheckedChanged(object sender, EventArgs e)
        {
            trackBarPalitreR.Enabled = true;
            trackBarPalitreG.Enabled = true;
            trackBarPalitreB.Enabled = true;
            pictureBoxPalitres.Image = Gamma4.Properties.Resources.palitreGrey;
            if (radioButtonPalitreColorsBackground.Checked == true)
            {
                textBoxPalitreColorsBGR.Enabled = true;
                textBoxPalitreColorsBGG.Enabled = true;
                textBoxPalitreColorsBGB.Enabled = true;
                trackBarPalitreR.Value = int.Parse(textBoxPalitreColorsBGR.Text);
                trackBarPalitreG.Value = int.Parse(textBoxPalitreColorsBGG.Text);
                trackBarPalitreB.Value = int.Parse(textBoxPalitreColorsBGB.Text);
            }
            else
            {
                textBoxPalitreColorsBGR.Enabled = false;
                textBoxPalitreColorsBGG.Enabled = false;
                textBoxPalitreColorsBGB.Enabled = false;
            }
        }
        //изменение ползунка красного
        private void trackBarPalitreR_Scroll(object sender, EventArgs e)
        {
            if (radioButtonPalitreColorsRed.Checked == true)
            {
                textBoxPalitreColorsRedR.Text = trackBarPalitreR.Value.ToString();
            }
            else if (radioButtonPalitreColorsBlue.Checked == true)
            {
                textBoxPalitreColorsBlueR.Text = trackBarPalitreR.Value.ToString();
            }
            else if (radioButtonPalitreColorsBackground.Checked == true)
            {
                textBoxPalitreColorsBGR.Text = trackBarPalitreR.Value.ToString();
            } 
            saved = false;
            PalitreDrawEilerCircls();
        }
        //изменение ползунка зеленого
        private void trackBarPalitreG_Scroll(object sender, EventArgs e)
        {
            if (radioButtonPalitreColorsRed.Checked == true)
            {
                textBoxPalitreColorsRedG.Text = trackBarPalitreG.Value.ToString();
            }
            else if (radioButtonPalitreColorsBlue.Checked == true)
            {
                textBoxPalitreColorsBlueG.Text = trackBarPalitreG.Value.ToString();
            }
            else if (radioButtonPalitreColorsBackground.Checked == true)
            {
                textBoxPalitreColorsBGG.Text = trackBarPalitreG.Value.ToString();
            }
            saved = false;
            PalitreDrawEilerCircls();
        }
        //изменение ползунка синего
        private void trackBarPalitreB_Scroll(object sender, EventArgs e)
        {
            if (radioButtonPalitreColorsRed.Checked == true)
            {
                textBoxPalitreColorsRedB.Text = trackBarPalitreB.Value.ToString();
            }
            else if (radioButtonPalitreColorsBlue.Checked == true)
            {
                textBoxPalitreColorsBlueB.Text = trackBarPalitreB.Value.ToString();
            }
            else if (radioButtonPalitreColorsBackground.Checked == true)
            {
                textBoxPalitreColorsBGB.Text = trackBarPalitreB.Value.ToString();
            }
            saved = false;
            PalitreDrawEilerCircls();
        }
        //изменение текста цветов
        private void textBoxPalitreColors_TextChanged(object sender, EventArgs e)
        {
            if (radioButtonPalitreColorsRed.Checked == true)
            {
                trackBarPalitreR.Value = int.Parse(textBoxPalitreColorsRedR.Text);
                trackBarPalitreG.Value = int.Parse(textBoxPalitreColorsRedG.Text);
                trackBarPalitreB.Value = int.Parse(textBoxPalitreColorsRedB.Text);                
            }
            else if (radioButtonPalitreColorsBlue.Checked == true)
            {
                trackBarPalitreR.Value = int.Parse(textBoxPalitreColorsBlueR.Text);
                trackBarPalitreG.Value = int.Parse(textBoxPalitreColorsBlueG.Text);
                trackBarPalitreB.Value = int.Parse(textBoxPalitreColorsBlueB.Text);                
            }
            else if (radioButtonPalitreColorsBackground.Checked == true)
            {
                trackBarPalitreR.Value = int.Parse(textBoxPalitreColorsBGR.Text);
                trackBarPalitreG.Value = int.Parse(textBoxPalitreColorsBGG.Text);
                trackBarPalitreB.Value = int.Parse(textBoxPalitreColorsBGB.Text);                
            }
            saved = false;
        }
        //выбор цвета на палитре
        private void pictureBoxPalitres_MouseClick(object sender, MouseEventArgs e)
        {
            if (pictureBoxPalitres.Image != null && (e.X >= 0 && e.Y >= 0)
                && (radioButtonPalitreColorsRed.Checked == true || radioButtonPalitreColorsBlue.Checked == true || radioButtonPalitreColorsBackground.Checked == true))
            {
                pictureBoxPalitres.Refresh();
                Color currentColor = new Color();
                currentColor = (pictureBoxPalitres.Image as Bitmap).GetPixel(e.X, e.Y);
                trackBarPalitreR.Value = currentColor.R;
                trackBarPalitreG.Value = currentColor.G;
                trackBarPalitreB.Value = currentColor.B;
                pictureBoxPalitres.CreateGraphics().DrawEllipse(Pens.Purple, e.X - 2, e.Y - 2, 4, 4);
            }
        }
        //рисование кругов
        private void PalitreDrawEilerCircls()
        {
            Palitre palitreBuffer = new Palitre();
            GraphicsPath gp = new GraphicsPath();
            PointF[] pts = { new PointF(130, 130), new PointF(135, 135) };
            gp.AddArc(170 - 130, (180 - 130), 260, 260, -40, 80);
            gp.AddArc(370 - 130, (180 - 130), 260, 260, 140, 80);
            Bitmap bmp = new Bitmap(540, 360);
            Graphics drawIt = Graphics.FromImage(bmp);
            palitreBuffer.BackColor = Color.FromArgb(255, int.Parse(textBoxPalitreColorsBGR.Text.ToString()), int.Parse(textBoxPalitreColorsBGG.Text.ToString()), int.Parse(textBoxPalitreColorsBGB.Text.ToString()));
            palitreBuffer.Blue = Color.FromArgb(255, int.Parse(textBoxPalitreColorsBlueR.Text.ToString()), int.Parse(textBoxPalitreColorsBlueG.Text.ToString()), int.Parse(textBoxPalitreColorsBlueB.Text.ToString()));
            palitreBuffer.Red = Color.FromArgb(255, int.Parse(textBoxPalitreColorsRedR.Text.ToString()), int.Parse(textBoxPalitreColorsRedG.Text.ToString()), int.Parse(textBoxPalitreColorsRedB.Text.ToString()));
            drawIt.Clear(palitreBuffer.BackColor);
            drawIt.FillEllipse((new Pen(palitreBuffer.Blue)).Brush, 170 - 130, (180 - 130), 260, 260);
            drawIt.FillEllipse((new Pen(palitreBuffer.Red)).Brush, 370 - 130, (180 - 130), 260, 260);
            drawIt.FillPath(MashedColor(palitreBuffer), gp);
            pictureBoxPalitre.Image = bmp;

            if (saved == false)
                PalitreActivateSaving();
        }
        //цвет пересечения
        private Brush MashedColor(Palitre palitreBuffer)
        {
            int R = 0, G = 0, B = 0;
            if ((palitreBuffer.Red.R + palitreBuffer.Blue.R) > 255)
                R = 255;
            else
                R = palitreBuffer.Red.R + palitreBuffer.Blue.R;
            if ((palitreBuffer.Red.G + palitreBuffer.Blue.G) > 255)
                G = 255;
            else
                G = palitreBuffer.Red.G + palitreBuffer.Blue.G;
            if ((palitreBuffer.Red.B + palitreBuffer.Blue.B) > 255)
                B = 255;
            else
                B = palitreBuffer.Red.B + palitreBuffer.Blue.B;
            return (new Pen(Color.FromArgb(R, G, B))).Brush;
        }
        //стандартные цвета
        private void buttonPalitreDefault_Click(object sender, EventArgs e)
        {
            textBoxPalitreColorsRedR.Text = "102";
            textBoxPalitreColorsRedG.Text = "1";
            textBoxPalitreColorsRedB.Text = "0";

            textBoxPalitreColorsBlueR.Text = "0";
            textBoxPalitreColorsBlueG.Text = "88";
            textBoxPalitreColorsBlueB.Text = "100";

            textBoxPalitreColorsBGR.Text = "97";
            textBoxPalitreColorsBGG.Text = "97";
            textBoxPalitreColorsBGB.Text = "97";
            saved = false;
            PalitreDrawEilerCircls();
        }
        //активация и деактивация кнопок сохранить/отменить
        private void PalitreActivateSaving(bool activate = true)
        {
            buttonPalitreSave.Enabled = activate;
            buttonPalitreCancel.Enabled = activate;
        }
        //загрузка палитры пациента
        private void PalitreShowInfo(Palitre palitre)
        {
            textBoxPalitreColorsRedR.Text = (Color.FromArgb(palitre.iRed)).R.ToString();
            textBoxPalitreColorsRedG.Text = (Color.FromArgb(palitre.iRed)).G.ToString();
            textBoxPalitreColorsRedB.Text = (Color.FromArgb(palitre.iRed)).B.ToString();

            textBoxPalitreColorsBlueR.Text = (Color.FromArgb(palitre.iBlue)).R.ToString();
            textBoxPalitreColorsBlueG.Text = (Color.FromArgb(palitre.iBlue)).G.ToString();
            textBoxPalitreColorsBlueB.Text = (Color.FromArgb(palitre.iBlue)).B.ToString();

            textBoxPalitreColorsBGR.Text = (Color.FromArgb(palitre.iBG)).R.ToString();
            textBoxPalitreColorsBGG.Text = (Color.FromArgb(palitre.iBG)).G.ToString();
            textBoxPalitreColorsBGB.Text = (Color.FromArgb(palitre.iBG)).B.ToString();
            saved = true;
            PalitreDrawEilerCircls();
        }
        //сохранение состояния палитры
        private void buttonPalitreSave_Click(object sender, EventArgs e)
        {
            saved = true;
            PalitreActivateSaving(false);
            patientsList.patients[patientsList.currentPatient].Palitre.iBG
                = Color.FromArgb(int.Parse(textBoxPalitreColorsBGR.Text), int.Parse(textBoxPalitreColorsBGG.Text), int.Parse(textBoxPalitreColorsBGB.Text)).ToArgb();
            patientsList.patients[patientsList.currentPatient].Palitre.iRed
                = Color.FromArgb(int.Parse(textBoxPalitreColorsRedR.Text), int.Parse(textBoxPalitreColorsRedG.Text), int.Parse(textBoxPalitreColorsRedB.Text)).ToArgb();
            patientsList.patients[patientsList.currentPatient].Palitre.iBlue
                = Color.FromArgb(int.Parse(textBoxPalitreColorsBlueR.Text), int.Parse(textBoxPalitreColorsBlueG.Text), int.Parse(textBoxPalitreColorsBlueB.Text)).ToArgb();
            Patients.Write(file, patientsList);
        }
        //отмена состояния палитры
        private void buttonPalitreCancel_Click(object sender, EventArgs e)
        {
            patientsList = Patients.Read(file);
            PalitreShowInfo(patientsList.patients[patientsList.currentPatient].Palitre);
            saved = true;
            PalitreActivateSaving(false);
        }
        #endregion
        
        #region Результаты
        Patient resPatient;
        //вызов окна справки
        private void buttonResultsHelp_Click(object sender, EventArgs e)
        {
            ShowHelp("resultHelp.txt");
        }
        //загрузка информации в окно
        private void ResultsShowInfo(Patient patient)
        {
            resPatient = patient;
            textBoxResultsPatient.Text = patient.Name;
            textBoxResultsPacientDoneSessions.Text = patient.results.Count.ToString() + " сеансов";
            if (patient.results.Count >= 1)
            {
                int time = 0;
                for (int i = 0; i < patient.results.Count; i++)
                {
                    time += patient.results[i].Length;
                }
                int minutes = time / 60;
                time -= minutes * 60;
                textBoxResultsPacientDoneTime.Text = minutes.ToString() + "мин " + time.ToString() + "сек";
                textBoxResultsPacientFirst.Text = patient.results[0].Date.ToString();
                textBoxResultsPacientsLatest.Text = patient.results[patient.results.Count - 1].Date.ToString();
                //среднее и максимальное
                listViewResultsSum.Items.Clear();
                listViewResultsSum.Items.Add(new ListViewItem(new string[] {
                    "Среднее по сеансам",
                    patient.AverageResult().Length.ToString(),
                    patient.AverageResult().HorDev.ToString(),
                    patient.AverageResult().HorDevDin.ToString(),
                    patient.AverageResult().VerDev.ToString(),
                    patient.AverageResult().VerDevDin.ToString(),
                    patient.AverageResult().Hit.ToString(),
                    patient.AverageResult().Miss.ToString(),
                    patient.AverageResult().Balls.ToString()
                }));
                listViewResultsSum.Items.Add(new ListViewItem(new string[] {
                    "Лучшее по сеансам",
                    patient.BestResults().Length.ToString(),
                    patient.BestResults().HorDev.ToString(),
                    patient.BestResults().HorDevDin.ToString(),
                    patient.BestResults().VerDev.ToString(),
                    patient.BestResults().VerDevDin.ToString(),
                    patient.BestResults().Hit.ToString(),
                    patient.BestResults().Miss.ToString(),
                    patient.BestResults().Balls.ToString()
                }));
                //список
                listViewResults.Items.Clear();
                for (int i = 0; i < patient.results.Count; i++)
                {
                    listViewResults.Items.Add(new ListViewItem(new string[] {
                        (i+1).ToString(),
                        patient.results[i].date.ToString() + " '" + patient.results[i].name +"'",
                        patient.results[i].Length.ToString(),
                        patient.results[i].HorDev.ToString(),
                        patient.results[i].HorDevDin.ToString(),
                        patient.results[i].VerDev.ToString(),
                        patient.results[i].VerDevDin.ToString(),
                        patient.results[i].Hit.ToString(),
                        patient.results[i].Miss.ToString(),
                        patient.results[i].Balls.ToString()
                    }));
                }
            }
        }
        //реакция на выделение строки
        private void listViewResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewResults.SelectedIndices.Count != 0)
            {
                buttonResultsDel.Enabled = true;
                buttonResultsComment.Enabled = true;
            }
            else
            {
                buttonResultsDel.Enabled = false;
                buttonResultsComment.Enabled = false;
            }
        }
        //сохранение в файл
        [DllImport("user32.dll", SetLastError = true)]
        static extern uint GetWindowThreadProcessId(int hWnd, ref int lpdwProcessId);
        private Microsoft.Office.Interop.Excel.Application application;
        private Workbook workBook;
        private Worksheet worksheet;
        Result bufar, bufbr;
        private void buttonResultsFile_Click(object sender, EventArgs e)
        {
            //вызов метода сохранения в файл
            SaveXLS(resPatient);
        }
        private void SaveXLS(Patient patient)
        {
            if (patient.results.Count > 0)
            {
                try
                {
                    // Открываем приложение
                    application = new Microsoft.Office.Interop.Excel.Application
                    {
                        DisplayAlerts = false
                    };

                    // Файл шаблона
                    const string template = "resources/template.xlt";

                    // Открываем книгу
                    workBook = application.Workbooks.Open(Path.Combine(Environment.CurrentDirectory, template));

                    // Получаем активную таблицу
                    worksheet = workBook.ActiveSheet as Worksheet;

                    // Записываем данные
                    //worksheet.Range["A2"].Value = DateTime.Now;
                    worksheet.Range["A1"].Value = "Название сеанса";
                    worksheet.Range["B1"].Value = "Дата";
                    worksheet.Range["C1"].Value = "Продолжительность";
                    worksheet.Range["D1"].Value = "Горизонтальное отклонение";
                    worksheet.Range["E1"].Value = "Горизонтальное отклонение (динамика)";
                    worksheet.Range["F1"].Value = "Вертикальное отклонение";
                    worksheet.Range["G1"].Value = "Вертикальное отклонение (динамика)";
                    worksheet.Range["H1"].Value = "Попадания";
                    worksheet.Range["I1"].Value = "Промахи";
                    worksheet.Range["J1"].Value = "Баллы";
                    worksheet.Range["K1"].Value = "Комментарий";
                    for (int i = 0; i < patient.results.Count; i++)
                    {
                        worksheet.Range["A" + (i + 2).ToString()].Value = patient.results[i].Name;
                        worksheet.Range["B" + (i + 2).ToString()].Value = patient.results[i].Date.ToShortDateString() + " " + patient.results[i].Date.ToShortTimeString();
                        worksheet.Range["C" + (i + 2).ToString()].Value = patient.results[i].Length.ToString();
                        worksheet.Range["D" + (i + 2).ToString()].Value = patient.results[i].HorDev.ToString();
                        worksheet.Range["E" + (i + 2).ToString()].Value = patient.results[i].HorDevDin.ToString();
                        worksheet.Range["F" + (i + 2).ToString()].Value = patient.results[i].VerDev.ToString();
                        worksheet.Range["G" + (i + 2).ToString()].Value = patient.results[i].VerDevDin.ToString();
                        worksheet.Range["H" + (i + 2).ToString()].Value = patient.results[i].Hit.ToString();
                        worksheet.Range["I" + (i + 2).ToString()].Value = patient.results[i].Miss.ToString();
                        worksheet.Range["J" + (i + 2).ToString()].Value = patient.results[i].Balls.ToString();
                        worksheet.Range["K" + (i + 2).ToString()].Value = patient.results[i].Comment;
                    }
                    bufar = patient.AverageResult();
                    worksheet.Range["A" + (patient.results.Count + 4).ToString()].Value = "Средний результат";
                    worksheet.Range["C" + (patient.results.Count + 4).ToString()].Value = bufar.Length.ToString();
                    worksheet.Range["D" + (patient.results.Count + 4).ToString()].Value = bufar.HorDev.ToString();
                    worksheet.Range["E" + (patient.results.Count + 4).ToString()].Value = bufar.HorDevDin.ToString();
                    worksheet.Range["F" + (patient.results.Count + 4).ToString()].Value = bufar.VerDev.ToString();
                    worksheet.Range["G" + (patient.results.Count + 4).ToString()].Value = bufar.VerDevDin.ToString();
                    worksheet.Range["H" + (patient.results.Count + 4).ToString()].Value = bufar.Hit.ToString();
                    worksheet.Range["I" + (patient.results.Count + 4).ToString()].Value = bufar.Miss.ToString();
                    worksheet.Range["J" + (patient.results.Count + 4).ToString()].Value = bufar.Balls.ToString();
                    worksheet.Range["K" + (patient.results.Count + 4).ToString()].Value = bufar.Comment;
                    bufbr = patient.BestResults();
                    worksheet.Range["A" + (patient.results.Count + 5).ToString()].Value = "Лучший результат";
                    worksheet.Range["C" + (patient.results.Count + 5).ToString()].Value = bufbr.Length.ToString();
                    worksheet.Range["D" + (patient.results.Count + 5).ToString()].Value = bufbr.HorDev.ToString();
                    worksheet.Range["E" + (patient.results.Count + 5).ToString()].Value = bufbr.HorDevDin.ToString();
                    worksheet.Range["F" + (patient.results.Count + 5).ToString()].Value = bufbr.VerDev.ToString();
                    worksheet.Range["G" + (patient.results.Count + 5).ToString()].Value = bufbr.VerDevDin.ToString();
                    worksheet.Range["H" + (patient.results.Count + 5).ToString()].Value = bufbr.Hit.ToString();
                    worksheet.Range["I" + (patient.results.Count + 5).ToString()].Value = bufbr.Miss.ToString();
                    worksheet.Range["J" + (patient.results.Count + 5).ToString()].Value = bufbr.Balls.ToString();
                    worksheet.Range["K" + (patient.results.Count + 5).ToString()].Value = bufbr.Comment;
                    //сохранение
                     SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "Таблица результатов пациентов (*.xls)|*.xls";
                    sfd.FileName = patient.Name + "_результаты" + ".xls";
                    if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        workBook.SaveAs(sfd.FileName);

                    //закрытие процесса
                    if (application != null)
                    {
                        int excelProcessId = -1;
                        GetWindowThreadProcessId(application.Hwnd, ref excelProcessId);

                        Marshal.ReleaseComObject(worksheet);
                        workBook.Close();
                        Marshal.ReleaseComObject(workBook);
                        application.Quit();
                        Marshal.ReleaseComObject(application);

                        application = null;
                        // Прибиваем висящий процесс
                        try
                        {
                            Process process = Process.GetProcessById(excelProcessId);
                            process.Kill();
                        }
                        finally { }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Произошла непредвиденная ошибка, попробуйте ещё раз", "Внимание");
                }
            }
        }
        //редактирование комментария
        private void buttonResultsComment_Click(object sender, EventArgs e)
        {
            if (resPatient.results.Count > 0)
            {
                //для текущего пациента
                ResultComment form = new ResultComment(resPatient.results[listViewResults.SelectedIndices[0]].Comment, this);
                form.ShowDialog(this);
                if (dRes == DialogResult.OK)
                {
                    resPatient.results[listViewResults.SelectedIndices[0]].Comment = _com;
                }
                patientsList.patients[patientsList.currentPatient] = resPatient;
                Patients.Write(file, patientsList);
                patientsList = Patients.Read(file);
                ResultsShowInfo(patientsList.patients[patientsList.currentPatient]);
            }
        }
        //обновление результатов
        private void buttonResultUpdateResults_Click(object sender, EventArgs e)
        {
            if (File.Exists(resultsFile))
                ResultsToPatients();
            ResultsShowInfo(patientsList.patients[patientsList.currentPatient]);
        }
        #endregion

        #region Экран

        public ClassesLib.Screen bufferScreen = new ClassesLib.Screen();        //временное значение данных экрана

        //вызов окна помощи
        private void buttonScreenHelp_Click(object sender, EventArgs e)
        {
            ShowHelp("screenHelp.txt");
        }
        //вывод информации при активации панели
        private void ScreenShowInfo(ClassesLib.Screen screen)
        {
            textBoxScreenHeight.Text = screen.Height.ToString();
            textBoxScreenWidth.Text = screen.Width.ToString();
            saved = true;
            ScreenActivateSaving(!saved);
            bufferScreen.Width = screen.Width;
            bufferScreen.Height = screen.Height;
            bufferScreen.PixelHeight = screen.PixelHeight;
            bufferScreen.PixelWidth = screen.PixelWidth;
        }
        //активация/деактивация кнопок сохранения и отмены
        private void ScreenActivateSaving(bool activate = true)
        {
            buttonScreenSave.Enabled = activate;
            buttonScreenCancel.Enabled = activate;
        }
        //реакция на изменение длины/высоты
        private void textBoxScreenHeightWidth_TextChanged(object sender, EventArgs e)
        {
            saved = false;
            ScreenActivateSaving(!saved);
            try
            {
                if (textBoxScreenWidth.Text != "")
                    bufferScreen.Width = double.Parse(textBoxScreenWidth.Text);
                if (textBoxScreenHeight.Text != "")
                    bufferScreen.Height = double.Parse(textBoxScreenHeight.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("Неверный формат ввода", "Ошибка");
                ((System.Windows.Forms.TextBox)sender).Text = "";
            }
        }
        //отмена
        private void buttonScreenCancel_Click(object sender, EventArgs e)
        {
            textBoxScreenHeight.Text = screenData.Height.ToString();
            textBoxScreenWidth.Text = screenData.Width.ToString();
            screenData = ClassesLib.Screen.Read(screenFile);
            ScreenShowInfo(screenData);
            saved = true;
            ScreenActivateSaving(false);
        }
        //сохранение
        private void buttonScreenSave_Click(object sender, EventArgs e)
        {
            PixelParams();
            screenData = bufferScreen;
            saved = true;
            ScreenActivateSaving(false);
            ClassesLib.Screen.Write(screenFile, screenData);
        }
        //функция рассчета ширины и высоты пикселя в мм
        private void PixelParams()
        {
            bufferScreen.PixelHeight = (bufferScreen.Height * 10) / System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
            bufferScreen.PixelWidth = (bufferScreen.Width * 10) / System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
        }
        #endregion
        
        #region Сеанс завершен
        //вызов окна помощи
        private void buttonFinishHelp_Click(object sender, EventArgs e)
        {
            ShowHelp("finishHelp.txt");
        }
        //загрузка информации
        private void FinishShowInfo(Patient patient)
        {
            try
            {
                //создание файла
                if (!((patient.currentSession != -1 && patient.currentSession < patient.sessions.Count)
                    && (patient.currentLevel != -1 && patient.currentLevel < patient.levels.Count)))
                {
                    MessageBox.Show("Ошибка создания файла, возможно невыбраны какие-то параметры", "Внимание");
                    return;
                }
                pictureBoxFinishLoading.Image = Gamma4.Properties.Resources.loading;
                pictureBoxFinishLoading.Visible = true;
                //создание файла
                SaveFileDialog sfd = new SaveFileDialog();
                InnerData.Write("buf.gsf", new InnerData(patient));
                //запуск лаунчера
                Process visual = new Process();
                visual.StartInfo.FileName = "gammaLauncher.exe";
                visual.StartInfo.Arguments = string.Format("-load \"{0}\"", "buf.gsf");
                visual.Start();
                visual.WaitForExit();
                //удаление файла
                if (File.Exists("buf.gsf"))
                    File.Delete("buf.gsf");
                //считывание результатов
                if (File.Exists(resultsFile))
                    ResultsToPatients();
                else
                {
                    MessageBox.Show("Невозможно считать файл результатов, возможно сеанс не завершен или файл поврежден", "Внимание");
                    return;
                }
                pictureBoxFinishLoading.Image = null;
                pictureBoxFinishLoading.Visible = false;
                MessageBox.Show("Поздравляем с успешным окончанием сеанса", "Внимание");
                //вывод результатов на панель
                patient = patientsList.patients[patientsList.currentPatient];
                textBoxFinishPacient.Text = patient.Name;
                if (patient.results.Count > 0)
                {
                    textBoxFinishBalls.Text = patient.results[patient.results.Count - 1].Balls.ToString();
                    listViewFinishCurrentResult.Items.Clear();
                    listViewFinishCurrentResult.Items.Add(new ListViewItem(new string[] {patient.results.Count.ToString(),
                    patient.results[patient.results.Count - 1].Name + " " + patient.results[patient.results.Count - 1].Date.ToString(),
                    patient.results[patient.results.Count - 1].Length.ToString(),
                    patient.results[patient.results.Count - 1].HorDev.ToString(),
                    patient.results[patient.results.Count - 1].HorDevDin.ToString(),
                    patient.results[patient.results.Count - 1].VerDev.ToString(),
                    patient.results[patient.results.Count - 1].VerDevDin.ToString(),
                    patient.results[patient.results.Count - 1].Hit.ToString(),
                    patient.results[patient.results.Count - 1].Miss.ToString(),
                    patient.results[patient.results.Count - 1].Balls.ToString()
                }));
                    listViewFinishResults.Items.Clear();
                    listViewFinishResults.Items.Add(new ListViewItem(new string[] {
                    "Среднее по сеансам",
                    patient.AverageResult().Length.ToString(),
                    patient.AverageResult().HorDev.ToString(),
                    patient.AverageResult().HorDevDin.ToString(),
                    patient.AverageResult().VerDev.ToString(),
                    patient.AverageResult().VerDevDin.ToString(),
                    patient.AverageResult().Hit.ToString(),
                    patient.AverageResult().Miss.ToString(),
                    patient.AverageResult().Balls.ToString()
                }));
                    listViewFinishResults.Items.Add(new ListViewItem(new string[] {
                    "Лучшее по сеансам",
                    patient.BestResults().Length.ToString(),
                    patient.BestResults().HorDev.ToString(),
                    patient.BestResults().HorDevDin.ToString(),
                    patient.BestResults().VerDev.ToString(),
                    patient.BestResults().VerDevDin.ToString(),
                    patient.BestResults().Hit.ToString(),
                    patient.BestResults().Miss.ToString(),
                    patient.BestResults().Balls.ToString()
                }));
                }
                else
                {
                    MessageBox.Show("Не обнаружено ни одного результата. Возможно, был поврежден файл данных", "Внимание");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Во время запуска или выполнения сеанса произошла ошибка, попробуйте еще раз или запустите сеанс из отдельного файла.", "Внимание");
            }
        }

        #endregion

        #region Функции
        //функция вызова окна помощи
        public static void ShowHelp(string fileName)
        {
            formHelp helper = new formHelp(fileName);
            helper.Show();
        }
        //контроль вводимых в числовые поля значений
        public void NumeralsOnly(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
                if ((e.KeyChar != (char)Keys.Back))
                    if (e.KeyChar == '.' || e.KeyChar == ',')
                        e.KeyChar = System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator[0];
                    else
                        e.Handled = true;
        }
        //функция обновления результатов из файла
        private void ResultsToPatients()
        {
            SessionResults results = SessionResults.Read(resultsFile);
            for (int i = 0; i < results.sessionResults.Count; i++)
            {
                for (int j = 0; j < patientsList.patients.Count; j++)
                {
                    if (results.sessionResults[i].patientName == patientsList.patients[j].Name)
                    {
                        patientsList.patients[j].results.Add(OuterToResult(results.sessionResults[i]));
                        break;
                    }
                }
            }
            File.Delete(resultsFile);
        }
        //функция получения Result из OuterData
        private Result OuterToResult(OuterData data)
        {
            Result result = new Result();
            result.Name = data.sessionType;
            result.comment = "";
            result.date = data.sessionDate;
            result.length = data.sessionLength;
            result.hit = data.hits;
            result.miss = data.miss;
            result.balls = data.balls;
            result.horizontalDiviation = Math.Atan((data.horDev*screenData.pixelWidth)/(data.fromMonitor*10.0)) * 180 / Math.PI;
            result.horizontalDiviationDinamic = Math.Atan((data.horDevDin * screenData.pixelWidth) / (data.fromMonitor * 10.0)) * 180 / Math.PI;
            result.verticalDiviation = Math.Atan((data.verDev * screenData.pixelHeight) / (data.fromMonitor * 10.0)) * 180 / Math.PI;
            result.verticalDeviationDinamic = Math.Atan((data.verDevDin * screenData.pixelHeight) / (data.fromMonitor * 10.0)) * 180 / Math.PI;
            return result;
        }
        #endregion

        

       
        
    }
}
