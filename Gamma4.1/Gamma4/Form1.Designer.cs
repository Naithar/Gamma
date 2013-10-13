using ClassesLib;

namespace Gamma4
{
    partial class formMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            Patients.Write(file, patientsList);
            ClassesLib.Screen.Write(screenFile, screenData);
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Среднее по сеансам");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Лучшее по сеансам");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Среднее по сеансам");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("Лучшее по сеансам");
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonScreen = new System.Windows.Forms.Button();
            this.buttonPalitre = new System.Windows.Forms.Button();
            this.buttonResults = new System.Windows.Forms.Button();
            this.buttonLevels = new System.Windows.Forms.Button();
            this.buttonSessions = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonMain = new System.Windows.Forms.Button();
            this.buttonPacients = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.labelMainHead = new System.Windows.Forms.Label();
            this.textBoxMainLevel = new System.Windows.Forms.TextBox();
            this.textBoxMainLevelComment = new System.Windows.Forms.TextBox();
            this.labelMainLevel = new System.Windows.Forms.Label();
            this.textBoxMainSession = new System.Windows.Forms.TextBox();
            this.textBoxMainSessionComment = new System.Windows.Forms.TextBox();
            this.labelMainSession = new System.Windows.Forms.Label();
            this.textBoxMainLatestResult = new System.Windows.Forms.TextBox();
            this.labelMainLatestResult = new System.Windows.Forms.Label();
            this.textBoxMainSessionDuration = new System.Windows.Forms.TextBox();
            this.labelMainSessionDuration = new System.Windows.Forms.Label();
            this.textBoxMainRedFilter = new System.Windows.Forms.TextBox();
            this.groupBoxMainSessionControls = new System.Windows.Forms.GroupBox();
            this.labelMainSessionControls = new System.Windows.Forms.Label();
            this.buttonMainAbout = new System.Windows.Forms.Button();
            this.buttonMainHelp = new System.Windows.Forms.Button();
            this.buttonMainInfo = new System.Windows.Forms.Button();
            this.textBoxMainFromMonitor = new System.Windows.Forms.TextBox();
            this.labelMainFromMonitor = new System.Windows.Forms.Label();
            this.labelMainRedFilter = new System.Windows.Forms.Label();
            this.textBoxMainPacient = new System.Windows.Forms.TextBox();
            this.textBoxMainPacientComment = new System.Windows.Forms.TextBox();
            this.labelMainPacient = new System.Windows.Forms.Label();
            this.panelPacients = new System.Windows.Forms.Panel();
            this.buttonPacientsChangeName = new System.Windows.Forms.Button();
            this.buttonPacientsCancel = new System.Windows.Forms.Button();
            this.buttonPacientsSave = new System.Windows.Forms.Button();
            this.buttonPacientsArch = new System.Windows.Forms.Button();
            this.buttonPacientsDel = new System.Windows.Forms.Button();
            this.labelPacientsHead = new System.Windows.Forms.Label();
            this.labelPacientsFromMonitorSM = new System.Windows.Forms.Label();
            this.textBoxPacientsFromMonitor = new System.Windows.Forms.TextBox();
            this.labelPacientsFromMonitor = new System.Windows.Forms.Label();
            this.labelPacientsFilter = new System.Windows.Forms.Label();
            this.panelPacientsPanelFilter = new System.Windows.Forms.Panel();
            this.radioButtonPacientsFilterLeft = new System.Windows.Forms.RadioButton();
            this.radioButtonPacientsFilterRight = new System.Windows.Forms.RadioButton();
            this.textBoxPacientComment = new System.Windows.Forms.TextBox();
            this.labelPacientsComment = new System.Windows.Forms.Label();
            this.comboBoxPacients = new System.Windows.Forms.ComboBox();
            this.labelPacientsPacient = new System.Windows.Forms.Label();
            this.buttonPacientsCreate = new System.Windows.Forms.Button();
            this.buttonPacientsHelp = new System.Windows.Forms.Button();
            this.panelSessions = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listViewSessionsPaterns = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripPatterns = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSessionsCreate = new System.Windows.Forms.Button();
            this.buttonSessionsSave = new System.Windows.Forms.Button();
            this.buttonSessionsCancel = new System.Windows.Forms.Button();
            this.labelSessionsPaterns = new System.Windows.Forms.Label();
            this.labelSessionsTasks = new System.Windows.Forms.Label();
            this.buttonSessionsDel = new System.Windows.Forms.Button();
            this.buttonSessionsPaternsForm = new System.Windows.Forms.Button();
            this.buttonSessionsForm = new System.Windows.Forms.Button();
            this.listViewSessionsTasks = new System.Windows.Forms.ListView();
            this.columnHeaderTasksN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTasksName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTasksSeconds = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStriptasks = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemUp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDown = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuChanged = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemDel = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxSessionsPaternsAuto = new System.Windows.Forms.CheckBox();
            this.textBoxSessionDuration = new System.Windows.Forms.TextBox();
            this.labelSessionDuration = new System.Windows.Forms.Label();
            this.textBoxSessionComment = new System.Windows.Forms.TextBox();
            this.comboBoxSession = new System.Windows.Forms.ComboBox();
            this.labelSession = new System.Windows.Forms.Label();
            this.labelSessions = new System.Windows.Forms.Label();
            this.buttonSessionsHelp = new System.Windows.Forms.Button();
            this.panelLevels = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxLevelsBonusDinamic = new System.Windows.Forms.TextBox();
            this.labelLevelsBonusDinamic = new System.Windows.Forms.Label();
            this.textBoxLevelsBonusSmall = new System.Windows.Forms.TextBox();
            this.labelLevelsBonusSmall = new System.Windows.Forms.Label();
            this.textBoxLevelsObjectSmallerK = new System.Windows.Forms.TextBox();
            this.labellevelsObjectSmallerK = new System.Windows.Forms.Label();
            this.labelLevelsObjectSmaller = new System.Windows.Forms.Label();
            this.textBoxLevelsObjectCatch = new System.Windows.Forms.TextBox();
            this.labelLevelsObjectCatch = new System.Windows.Forms.Label();
            this.labelLevelsObject = new System.Windows.Forms.Label();
            this.textBoxLevelsToleranceVertical = new System.Windows.Forms.TextBox();
            this.labelLevelsToleranceVertical = new System.Windows.Forms.Label();
            this.textBoxLevelsPacient = new System.Windows.Forms.TextBox();
            this.textBoxLevelsBonusAccur = new System.Windows.Forms.TextBox();
            this.labelLevelsBonusAccur = new System.Windows.Forms.Label();
            this.labelLevelsBonus = new System.Windows.Forms.Label();
            this.textBoxLevelsBallsCatch = new System.Windows.Forms.TextBox();
            this.labelLevelsBallsCatch = new System.Windows.Forms.Label();
            this.labelLevelsBalls = new System.Windows.Forms.Label();
            this.textBoxLevelsToleranceHorizontal = new System.Windows.Forms.TextBox();
            this.labelLevelsToleranceHorizontal = new System.Windows.Forms.Label();
            this.labelLevelsTolerance = new System.Windows.Forms.Label();
            this.labelLevelsTraining = new System.Windows.Forms.Label();
            this.buttonLavelsUseForThisPacient = new System.Windows.Forms.Button();
            this.buttonLevelsSave = new System.Windows.Forms.Button();
            this.buttonLevelsCancel = new System.Windows.Forms.Button();
            this.buttonLevelsDelete = new System.Windows.Forms.Button();
            this.buttonLevelsHelp = new System.Windows.Forms.Button();
            this.textBoxLevelsComment = new System.Windows.Forms.TextBox();
            this.labelLevelsComment = new System.Windows.Forms.Label();
            this.comboBoxLevels = new System.Windows.Forms.ComboBox();
            this.labelLevel = new System.Windows.Forms.Label();
            this.labelLevels = new System.Windows.Forms.Label();
            this.panelResults = new System.Windows.Forms.Panel();
            this.listViewResultsSum = new System.Windows.Forms.ListView();
            this.columnHeaderResultsSumName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderResultsSumTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderResultsSumHor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderResultsSumHorDin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderResultsSumVert = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderResultsSumVertDin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderResultsSumCatch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderResultsSumMiss = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderResultsSumBalls = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxResultsPacientsLatest = new System.Windows.Forms.TextBox();
            this.textBoxResultsPacientFirst = new System.Windows.Forms.TextBox();
            this.labelResultsPacientDates = new System.Windows.Forms.Label();
            this.textBoxResultsPacientDoneTime = new System.Windows.Forms.TextBox();
            this.textBoxResultsPacientDoneSessions = new System.Windows.Forms.TextBox();
            this.labelResultsPacientDone = new System.Windows.Forms.Label();
            this.buttonResultsComment = new System.Windows.Forms.Button();
            this.buttonResultsFile = new System.Windows.Forms.Button();
            this.buttonResultsDel = new System.Windows.Forms.Button();
            this.buttonResultsHelp = new System.Windows.Forms.Button();
            this.listViewResults = new System.Windows.Forms.ListView();
            this.columnHeaderN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDateName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderHorDev = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderHorDevDin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderVertDev = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderVertDevDin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderHit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMiss = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBalls = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxResultsPatient = new System.Windows.Forms.TextBox();
            this.labelResultsPatient = new System.Windows.Forms.Label();
            this.labelResults = new System.Windows.Forms.Label();
            this.panelPalitre = new System.Windows.Forms.Panel();
            this.labelPalitreR = new System.Windows.Forms.Label();
            this.trackBarPalitreR = new System.Windows.Forms.TrackBar();
            this.labelPalitreG = new System.Windows.Forms.Label();
            this.trackBarPalitreG = new System.Windows.Forms.TrackBar();
            this.labelPalitreB = new System.Windows.Forms.Label();
            this.trackBarPalitreB = new System.Windows.Forms.TrackBar();
            this.labelPalitre = new System.Windows.Forms.Label();
            this.buttonPalitreDefault = new System.Windows.Forms.Button();
            this.buttonPalitreSave = new System.Windows.Forms.Button();
            this.buttonPalitreCancel = new System.Windows.Forms.Button();
            this.buttonPalitreHelp = new System.Windows.Forms.Button();
            this.groupBoxPalitreColors = new System.Windows.Forms.GroupBox();
            this.labelPalitreColorsR = new System.Windows.Forms.Label();
            this.labelPalitreColorsG = new System.Windows.Forms.Label();
            this.labelPalitreColorsB = new System.Windows.Forms.Label();
            this.textBoxPalitreColorsRedB = new System.Windows.Forms.TextBox();
            this.textBoxPalitreColorsBlueB = new System.Windows.Forms.TextBox();
            this.textBoxPalitreColorsBGB = new System.Windows.Forms.TextBox();
            this.textBoxPalitreColorsRedG = new System.Windows.Forms.TextBox();
            this.textBoxPalitreColorsBlueG = new System.Windows.Forms.TextBox();
            this.textBoxPalitreColorsBGG = new System.Windows.Forms.TextBox();
            this.radioButtonPalitreColorsBackground = new System.Windows.Forms.RadioButton();
            this.radioButtonPalitreColorsBlue = new System.Windows.Forms.RadioButton();
            this.radioButtonPalitreColorsRed = new System.Windows.Forms.RadioButton();
            this.textBoxPalitreColorsRedR = new System.Windows.Forms.TextBox();
            this.textBoxPalitreColorsBlueR = new System.Windows.Forms.TextBox();
            this.textBoxPalitreColorsBGR = new System.Windows.Forms.TextBox();
            this.panelFinish = new System.Windows.Forms.Panel();
            this.labelFinishTable = new System.Windows.Forms.Label();
            this.labelFinishPacient = new System.Windows.Forms.Label();
            this.listViewFinishCurrentResult = new System.Windows.Forms.ListView();
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewFinishResults = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxFinishBalls = new System.Windows.Forms.TextBox();
            this.labelFinishBalls = new System.Windows.Forms.Label();
            this.textBoxFinishPacient = new System.Windows.Forms.TextBox();
            this.labelFinish = new System.Windows.Forms.Label();
            this.buttonFinishHelp = new System.Windows.Forms.Button();
            this.panelScreen = new System.Windows.Forms.Panel();
            this.textBoxScreenWidth = new System.Windows.Forms.TextBox();
            this.textBoxScreenHeight = new System.Windows.Forms.TextBox();
            this.labelScreenWidth = new System.Windows.Forms.Label();
            this.labelScreenHeight = new System.Windows.Forms.Label();
            this.labelScreenType = new System.Windows.Forms.Label();
            this.buttonScreenSave = new System.Windows.Forms.Button();
            this.buttonScreenCancel = new System.Windows.Forms.Button();
            this.buttonScreenHelp = new System.Windows.Forms.Button();
            this.labelScreen = new System.Windows.Forms.Label();
            this.buttonResultUpdateResults = new System.Windows.Forms.Button();
            this.pictureBoxFinishLoading = new System.Windows.Forms.PictureBox();
            this.pictureBoxPalitres = new System.Windows.Forms.PictureBox();
            this.pictureBoxPalitre = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.groupBoxMainSessionControls.SuspendLayout();
            this.panelPacients.SuspendLayout();
            this.panelPacientsPanelFilter.SuspendLayout();
            this.panelSessions.SuspendLayout();
            this.contextMenuStripPatterns.SuspendLayout();
            this.contextMenuStriptasks.SuspendLayout();
            this.panelLevels.SuspendLayout();
            this.panelResults.SuspendLayout();
            this.panelPalitre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPalitreR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPalitreG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPalitreB)).BeginInit();
            this.groupBoxPalitreColors.SuspendLayout();
            this.panelFinish.SuspendLayout();
            this.panelScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFinishLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPalitres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPalitre)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.Control;
            this.panelMenu.Controls.Add(this.buttonExit);
            this.panelMenu.Controls.Add(this.buttonScreen);
            this.panelMenu.Controls.Add(this.buttonPalitre);
            this.panelMenu.Controls.Add(this.buttonResults);
            this.panelMenu.Controls.Add(this.buttonLevels);
            this.panelMenu.Controls.Add(this.buttonSessions);
            this.panelMenu.Controls.Add(this.buttonStart);
            this.panelMenu.Controls.Add(this.buttonMain);
            this.panelMenu.Controls.Add(this.buttonPacients);
            this.panelMenu.Location = new System.Drawing.Point(5, 5);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 560);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(15, 500);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(170, 50);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonScreen
            // 
            this.buttonScreen.Font = new System.Drawing.Font("Arial Black", 12.25F, System.Drawing.FontStyle.Bold);
            this.buttonScreen.Location = new System.Drawing.Point(15, 430);
            this.buttonScreen.Name = "buttonScreen";
            this.buttonScreen.Size = new System.Drawing.Size(170, 40);
            this.buttonScreen.TabIndex = 6;
            this.buttonScreen.Text = "Экран";
            this.buttonScreen.UseVisualStyleBackColor = true;
            this.buttonScreen.Click += new System.EventHandler(this.buttonScreen_Click);
            // 
            // buttonPalitre
            // 
            this.buttonPalitre.Font = new System.Drawing.Font("Arial Black", 12.25F, System.Drawing.FontStyle.Bold);
            this.buttonPalitre.Location = new System.Drawing.Point(15, 380);
            this.buttonPalitre.Name = "buttonPalitre";
            this.buttonPalitre.Size = new System.Drawing.Size(170, 40);
            this.buttonPalitre.TabIndex = 5;
            this.buttonPalitre.Text = "Палитра";
            this.buttonPalitre.UseVisualStyleBackColor = true;
            this.buttonPalitre.Click += new System.EventHandler(this.buttonPalitre_Click);
            // 
            // buttonResults
            // 
            this.buttonResults.Location = new System.Drawing.Point(15, 250);
            this.buttonResults.Name = "buttonResults";
            this.buttonResults.Size = new System.Drawing.Size(170, 40);
            this.buttonResults.TabIndex = 4;
            this.buttonResults.Text = "Результаты";
            this.buttonResults.UseVisualStyleBackColor = true;
            this.buttonResults.Click += new System.EventHandler(this.buttonResults_Click);
            // 
            // buttonLevels
            // 
            this.buttonLevels.Location = new System.Drawing.Point(15, 200);
            this.buttonLevels.Name = "buttonLevels";
            this.buttonLevels.Size = new System.Drawing.Size(170, 40);
            this.buttonLevels.TabIndex = 3;
            this.buttonLevels.Text = "Уровни";
            this.buttonLevels.UseVisualStyleBackColor = true;
            this.buttonLevels.Click += new System.EventHandler(this.buttonLevels_Click);
            // 
            // buttonSessions
            // 
            this.buttonSessions.Location = new System.Drawing.Point(15, 150);
            this.buttonSessions.Name = "buttonSessions";
            this.buttonSessions.Size = new System.Drawing.Size(170, 40);
            this.buttonSessions.TabIndex = 2;
            this.buttonSessions.Text = "Сеансы";
            this.buttonSessions.UseVisualStyleBackColor = true;
            this.buttonSessions.Click += new System.EventHandler(this.buttonSessions_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(15, 20);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(170, 40);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonMain
            // 
            this.buttonMain.Location = new System.Drawing.Point(15, 300);
            this.buttonMain.Name = "buttonMain";
            this.buttonMain.Size = new System.Drawing.Size(170, 40);
            this.buttonMain.TabIndex = 8;
            this.buttonMain.Text = "Главная";
            this.buttonMain.UseVisualStyleBackColor = true;
            this.buttonMain.Visible = false;
            this.buttonMain.Click += new System.EventHandler(this.buttonMain_Click);
            // 
            // buttonPacients
            // 
            this.buttonPacients.Location = new System.Drawing.Point(15, 100);
            this.buttonPacients.Name = "buttonPacients";
            this.buttonPacients.Size = new System.Drawing.Size(170, 40);
            this.buttonPacients.TabIndex = 1;
            this.buttonPacients.Text = "Пациенты";
            this.buttonPacients.UseVisualStyleBackColor = true;
            this.buttonPacients.Click += new System.EventHandler(this.buttonPacients_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.Control;
            this.panelMain.Controls.Add(this.labelMainHead);
            this.panelMain.Controls.Add(this.textBoxMainLevel);
            this.panelMain.Controls.Add(this.textBoxMainLevelComment);
            this.panelMain.Controls.Add(this.labelMainLevel);
            this.panelMain.Controls.Add(this.textBoxMainSession);
            this.panelMain.Controls.Add(this.textBoxMainSessionComment);
            this.panelMain.Controls.Add(this.labelMainSession);
            this.panelMain.Controls.Add(this.textBoxMainLatestResult);
            this.panelMain.Controls.Add(this.labelMainLatestResult);
            this.panelMain.Controls.Add(this.textBoxMainSessionDuration);
            this.panelMain.Controls.Add(this.labelMainSessionDuration);
            this.panelMain.Controls.Add(this.textBoxMainRedFilter);
            this.panelMain.Controls.Add(this.groupBoxMainSessionControls);
            this.panelMain.Controls.Add(this.buttonMainAbout);
            this.panelMain.Controls.Add(this.buttonMainHelp);
            this.panelMain.Controls.Add(this.buttonMainInfo);
            this.panelMain.Controls.Add(this.textBoxMainFromMonitor);
            this.panelMain.Controls.Add(this.labelMainFromMonitor);
            this.panelMain.Controls.Add(this.labelMainRedFilter);
            this.panelMain.Controls.Add(this.textBoxMainPacient);
            this.panelMain.Controls.Add(this.textBoxMainPacientComment);
            this.panelMain.Controls.Add(this.labelMainPacient);
            this.panelMain.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelMain.Location = new System.Drawing.Point(210, 5);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 560);
            this.panelMain.TabIndex = 1;
            this.panelMain.Visible = false;
            // 
            // labelMainHead
            // 
            this.labelMainHead.AutoSize = true;
            this.labelMainHead.Location = new System.Drawing.Point(5, 5);
            this.labelMainHead.Name = "labelMainHead";
            this.labelMainHead.Size = new System.Drawing.Size(111, 30);
            this.labelMainHead.TabIndex = 33;
            this.labelMainHead.Text = "Главная";
            // 
            // textBoxMainLevel
            // 
            this.textBoxMainLevel.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMainLevel.Location = new System.Drawing.Point(20, 340);
            this.textBoxMainLevel.Name = "textBoxMainLevel";
            this.textBoxMainLevel.ReadOnly = true;
            this.textBoxMainLevel.Size = new System.Drawing.Size(200, 29);
            this.textBoxMainLevel.TabIndex = 32;
            // 
            // textBoxMainLevelComment
            // 
            this.textBoxMainLevelComment.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMainLevelComment.Location = new System.Drawing.Point(240, 310);
            this.textBoxMainLevelComment.Multiline = true;
            this.textBoxMainLevelComment.Name = "textBoxMainLevelComment";
            this.textBoxMainLevelComment.ReadOnly = true;
            this.textBoxMainLevelComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMainLevelComment.Size = new System.Drawing.Size(290, 110);
            this.textBoxMainLevelComment.TabIndex = 31;
            // 
            // labelMainLevel
            // 
            this.labelMainLevel.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMainLevel.Location = new System.Drawing.Point(20, 310);
            this.labelMainLevel.Name = "labelMainLevel";
            this.labelMainLevel.Size = new System.Drawing.Size(90, 25);
            this.labelMainLevel.TabIndex = 30;
            this.labelMainLevel.Text = "Уровень";
            // 
            // textBoxMainSession
            // 
            this.textBoxMainSession.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMainSession.Location = new System.Drawing.Point(20, 210);
            this.textBoxMainSession.Name = "textBoxMainSession";
            this.textBoxMainSession.ReadOnly = true;
            this.textBoxMainSession.Size = new System.Drawing.Size(200, 29);
            this.textBoxMainSession.TabIndex = 29;
            // 
            // textBoxMainSessionComment
            // 
            this.textBoxMainSessionComment.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMainSessionComment.Location = new System.Drawing.Point(240, 180);
            this.textBoxMainSessionComment.Multiline = true;
            this.textBoxMainSessionComment.Name = "textBoxMainSessionComment";
            this.textBoxMainSessionComment.ReadOnly = true;
            this.textBoxMainSessionComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMainSessionComment.Size = new System.Drawing.Size(290, 110);
            this.textBoxMainSessionComment.TabIndex = 28;
            // 
            // labelMainSession
            // 
            this.labelMainSession.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMainSession.Location = new System.Drawing.Point(20, 180);
            this.labelMainSession.Name = "labelMainSession";
            this.labelMainSession.Size = new System.Drawing.Size(90, 25);
            this.labelMainSession.TabIndex = 27;
            this.labelMainSession.Text = "Сеанс";
            // 
            // textBoxMainLatestResult
            // 
            this.textBoxMainLatestResult.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBoxMainLatestResult.Location = new System.Drawing.Point(335, 450);
            this.textBoxMainLatestResult.Name = "textBoxMainLatestResult";
            this.textBoxMainLatestResult.ReadOnly = true;
            this.textBoxMainLatestResult.Size = new System.Drawing.Size(110, 29);
            this.textBoxMainLatestResult.TabIndex = 26;
            // 
            // labelMainLatestResult
            // 
            this.labelMainLatestResult.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelMainLatestResult.Location = new System.Drawing.Point(220, 440);
            this.labelMainLatestResult.Name = "labelMainLatestResult";
            this.labelMainLatestResult.Size = new System.Drawing.Size(110, 50);
            this.labelMainLatestResult.TabIndex = 25;
            this.labelMainLatestResult.Text = "последний результат";
            // 
            // textBoxMainSessionDuration
            // 
            this.textBoxMainSessionDuration.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBoxMainSessionDuration.Location = new System.Drawing.Point(650, 450);
            this.textBoxMainSessionDuration.Name = "textBoxMainSessionDuration";
            this.textBoxMainSessionDuration.ReadOnly = true;
            this.textBoxMainSessionDuration.Size = new System.Drawing.Size(110, 29);
            this.textBoxMainSessionDuration.TabIndex = 24;
            // 
            // labelMainSessionDuration
            // 
            this.labelMainSessionDuration.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelMainSessionDuration.Location = new System.Drawing.Point(450, 440);
            this.labelMainSessionDuration.Name = "labelMainSessionDuration";
            this.labelMainSessionDuration.Size = new System.Drawing.Size(190, 50);
            this.labelMainSessionDuration.TabIndex = 23;
            this.labelMainSessionDuration.Text = "продолжительность сеанса";
            // 
            // textBoxMainRedFilter
            // 
            this.textBoxMainRedFilter.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMainRedFilter.Location = new System.Drawing.Point(116, 510);
            this.textBoxMainRedFilter.Name = "textBoxMainRedFilter";
            this.textBoxMainRedFilter.ReadOnly = true;
            this.textBoxMainRedFilter.Size = new System.Drawing.Size(90, 29);
            this.textBoxMainRedFilter.TabIndex = 22;
            // 
            // groupBoxMainSessionControls
            // 
            this.groupBoxMainSessionControls.Controls.Add(this.labelMainSessionControls);
            this.groupBoxMainSessionControls.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxMainSessionControls.Location = new System.Drawing.Point(535, 150);
            this.groupBoxMainSessionControls.Name = "groupBoxMainSessionControls";
            this.groupBoxMainSessionControls.Size = new System.Drawing.Size(260, 275);
            this.groupBoxMainSessionControls.TabIndex = 21;
            this.groupBoxMainSessionControls.TabStop = false;
            this.groupBoxMainSessionControls.Text = "Управление в сеансе";
            // 
            // labelMainSessionControls
            // 
            this.labelMainSessionControls.Location = new System.Drawing.Point(5, 20);
            this.labelMainSessionControls.Name = "labelMainSessionControls";
            this.labelMainSessionControls.Size = new System.Drawing.Size(250, 250);
            this.labelMainSessionControls.TabIndex = 0;
            this.labelMainSessionControls.Text = resources.GetString("labelMainSessionControls.Text");
            // 
            // buttonMainAbout
            // 
            this.buttonMainAbout.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonMainAbout.Location = new System.Drawing.Point(660, 90);
            this.buttonMainAbout.Name = "buttonMainAbout";
            this.buttonMainAbout.Size = new System.Drawing.Size(130, 30);
            this.buttonMainAbout.TabIndex = 20;
            this.buttonMainAbout.Text = "О программе";
            this.buttonMainAbout.UseVisualStyleBackColor = true;
            this.buttonMainAbout.Click += new System.EventHandler(this.buttonMainAbout_Click);
            // 
            // buttonMainHelp
            // 
            this.buttonMainHelp.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMainHelp.Location = new System.Drawing.Point(660, 50);
            this.buttonMainHelp.Name = "buttonMainHelp";
            this.buttonMainHelp.Size = new System.Drawing.Size(130, 30);
            this.buttonMainHelp.TabIndex = 19;
            this.buttonMainHelp.Text = "Помощь";
            this.buttonMainHelp.UseVisualStyleBackColor = true;
            this.buttonMainHelp.Click += new System.EventHandler(this.buttonMainHelp_Click);
            // 
            // buttonMainInfo
            // 
            this.buttonMainInfo.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMainInfo.Location = new System.Drawing.Point(660, 10);
            this.buttonMainInfo.Name = "buttonMainInfo";
            this.buttonMainInfo.Size = new System.Drawing.Size(130, 30);
            this.buttonMainInfo.TabIndex = 18;
            this.buttonMainInfo.Text = "Справка";
            this.buttonMainInfo.UseVisualStyleBackColor = true;
            this.buttonMainInfo.Click += new System.EventHandler(this.buttonMainInfo_Click);
            // 
            // textBoxMainFromMonitor
            // 
            this.textBoxMainFromMonitor.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBoxMainFromMonitor.Location = new System.Drawing.Point(135, 450);
            this.textBoxMainFromMonitor.Name = "textBoxMainFromMonitor";
            this.textBoxMainFromMonitor.ReadOnly = true;
            this.textBoxMainFromMonitor.Size = new System.Drawing.Size(70, 29);
            this.textBoxMainFromMonitor.TabIndex = 12;
            // 
            // labelMainFromMonitor
            // 
            this.labelMainFromMonitor.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelMainFromMonitor.Location = new System.Drawing.Point(15, 455);
            this.labelMainFromMonitor.Name = "labelMainFromMonitor";
            this.labelMainFromMonitor.Size = new System.Drawing.Size(120, 25);
            this.labelMainFromMonitor.TabIndex = 11;
            this.labelMainFromMonitor.Text = "до монитора";
            // 
            // labelMainRedFilter
            // 
            this.labelMainRedFilter.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMainRedFilter.Location = new System.Drawing.Point(16, 500);
            this.labelMainRedFilter.Name = "labelMainRedFilter";
            this.labelMainRedFilter.Size = new System.Drawing.Size(90, 50);
            this.labelMainRedFilter.TabIndex = 9;
            this.labelMainRedFilter.Text = "красный фильтр";
            // 
            // textBoxMainPacient
            // 
            this.textBoxMainPacient.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMainPacient.Location = new System.Drawing.Point(20, 80);
            this.textBoxMainPacient.Name = "textBoxMainPacient";
            this.textBoxMainPacient.ReadOnly = true;
            this.textBoxMainPacient.Size = new System.Drawing.Size(200, 29);
            this.textBoxMainPacient.TabIndex = 2;
            // 
            // textBoxMainPacientComment
            // 
            this.textBoxMainPacientComment.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMainPacientComment.Location = new System.Drawing.Point(240, 50);
            this.textBoxMainPacientComment.Multiline = true;
            this.textBoxMainPacientComment.Name = "textBoxMainPacientComment";
            this.textBoxMainPacientComment.ReadOnly = true;
            this.textBoxMainPacientComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMainPacientComment.Size = new System.Drawing.Size(290, 110);
            this.textBoxMainPacientComment.TabIndex = 1;
            // 
            // labelMainPacient
            // 
            this.labelMainPacient.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMainPacient.Location = new System.Drawing.Point(20, 50);
            this.labelMainPacient.Name = "labelMainPacient";
            this.labelMainPacient.Size = new System.Drawing.Size(90, 25);
            this.labelMainPacient.TabIndex = 0;
            this.labelMainPacient.Text = "Пациент";
            // 
            // panelPacients
            // 
            this.panelPacients.BackColor = System.Drawing.SystemColors.Control;
            this.panelPacients.Controls.Add(this.buttonPacientsChangeName);
            this.panelPacients.Controls.Add(this.buttonPacientsCancel);
            this.panelPacients.Controls.Add(this.buttonPacientsSave);
            this.panelPacients.Controls.Add(this.buttonPacientsArch);
            this.panelPacients.Controls.Add(this.buttonPacientsDel);
            this.panelPacients.Controls.Add(this.labelPacientsHead);
            this.panelPacients.Controls.Add(this.labelPacientsFromMonitorSM);
            this.panelPacients.Controls.Add(this.textBoxPacientsFromMonitor);
            this.panelPacients.Controls.Add(this.labelPacientsFromMonitor);
            this.panelPacients.Controls.Add(this.labelPacientsFilter);
            this.panelPacients.Controls.Add(this.panelPacientsPanelFilter);
            this.panelPacients.Controls.Add(this.textBoxPacientComment);
            this.panelPacients.Controls.Add(this.labelPacientsComment);
            this.panelPacients.Controls.Add(this.comboBoxPacients);
            this.panelPacients.Controls.Add(this.labelPacientsPacient);
            this.panelPacients.Controls.Add(this.buttonPacientsCreate);
            this.panelPacients.Controls.Add(this.buttonPacientsHelp);
            this.panelPacients.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelPacients.Location = new System.Drawing.Point(210, 5);
            this.panelPacients.Name = "panelPacients";
            this.panelPacients.Size = new System.Drawing.Size(800, 560);
            this.panelPacients.TabIndex = 2;
            this.panelPacients.Visible = false;
            // 
            // buttonPacientsChangeName
            // 
            this.buttonPacientsChangeName.Location = new System.Drawing.Point(188, 80);
            this.buttonPacientsChangeName.Name = "buttonPacientsChangeName";
            this.buttonPacientsChangeName.Size = new System.Drawing.Size(20, 30);
            this.buttonPacientsChangeName.TabIndex = 22;
            this.buttonPacientsChangeName.Text = "!";
            this.buttonPacientsChangeName.UseVisualStyleBackColor = true;
            this.buttonPacientsChangeName.Click += new System.EventHandler(this.buttonPacientsChangeName_Click);
            // 
            // buttonPacientsCancel
            // 
            this.buttonPacientsCancel.Enabled = false;
            this.buttonPacientsCancel.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPacientsCancel.Location = new System.Drawing.Point(670, 480);
            this.buttonPacientsCancel.Name = "buttonPacientsCancel";
            this.buttonPacientsCancel.Size = new System.Drawing.Size(120, 30);
            this.buttonPacientsCancel.TabIndex = 21;
            this.buttonPacientsCancel.Text = "Отменить";
            this.buttonPacientsCancel.UseVisualStyleBackColor = true;
            this.buttonPacientsCancel.Click += new System.EventHandler(this.buttonPacientsCancel_Click);
            // 
            // buttonPacientsSave
            // 
            this.buttonPacientsSave.Enabled = false;
            this.buttonPacientsSave.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPacientsSave.Location = new System.Drawing.Point(540, 480);
            this.buttonPacientsSave.Name = "buttonPacientsSave";
            this.buttonPacientsSave.Size = new System.Drawing.Size(120, 30);
            this.buttonPacientsSave.TabIndex = 20;
            this.buttonPacientsSave.Text = "Сохранить";
            this.buttonPacientsSave.UseVisualStyleBackColor = true;
            this.buttonPacientsSave.Click += new System.EventHandler(this.buttonPacientsSave_Click);
            // 
            // buttonPacientsArch
            // 
            this.buttonPacientsArch.Enabled = false;
            this.buttonPacientsArch.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPacientsArch.Location = new System.Drawing.Point(670, 520);
            this.buttonPacientsArch.Name = "buttonPacientsArch";
            this.buttonPacientsArch.Size = new System.Drawing.Size(120, 30);
            this.buttonPacientsArch.TabIndex = 19;
            this.buttonPacientsArch.Text = "В архив";
            this.buttonPacientsArch.UseVisualStyleBackColor = true;
            this.buttonPacientsArch.Click += new System.EventHandler(this.buttonPacientsArch_Click);
            // 
            // buttonPacientsDel
            // 
            this.buttonPacientsDel.Enabled = false;
            this.buttonPacientsDel.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPacientsDel.Location = new System.Drawing.Point(540, 520);
            this.buttonPacientsDel.Name = "buttonPacientsDel";
            this.buttonPacientsDel.Size = new System.Drawing.Size(120, 30);
            this.buttonPacientsDel.TabIndex = 18;
            this.buttonPacientsDel.Text = "Удалить";
            this.buttonPacientsDel.UseVisualStyleBackColor = true;
            this.buttonPacientsDel.Click += new System.EventHandler(this.buttonPacientsDel_Click);
            // 
            // labelPacientsHead
            // 
            this.labelPacientsHead.AutoSize = true;
            this.labelPacientsHead.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPacientsHead.Location = new System.Drawing.Point(5, 5);
            this.labelPacientsHead.Name = "labelPacientsHead";
            this.labelPacientsHead.Size = new System.Drawing.Size(134, 30);
            this.labelPacientsHead.TabIndex = 16;
            this.labelPacientsHead.Text = "Пациенты";
            // 
            // labelPacientsFromMonitorSM
            // 
            this.labelPacientsFromMonitorSM.AutoSize = true;
            this.labelPacientsFromMonitorSM.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPacientsFromMonitorSM.Location = new System.Drawing.Point(305, 465);
            this.labelPacientsFromMonitorSM.Name = "labelPacientsFromMonitorSM";
            this.labelPacientsFromMonitorSM.Size = new System.Drawing.Size(33, 22);
            this.labelPacientsFromMonitorSM.TabIndex = 15;
            this.labelPacientsFromMonitorSM.Text = "см";
            // 
            // textBoxPacientsFromMonitor
            // 
            this.textBoxPacientsFromMonitor.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPacientsFromMonitor.Location = new System.Drawing.Point(250, 460);
            this.textBoxPacientsFromMonitor.MaxLength = 3;
            this.textBoxPacientsFromMonitor.Name = "textBoxPacientsFromMonitor";
            this.textBoxPacientsFromMonitor.Size = new System.Drawing.Size(50, 29);
            this.textBoxPacientsFromMonitor.TabIndex = 14;
            this.textBoxPacientsFromMonitor.TextChanged += new System.EventHandler(this.textBoxPacientComment_TextChanged);
            this.textBoxPacientsFromMonitor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumeralsOnly);
            // 
            // labelPacientsFromMonitor
            // 
            this.labelPacientsFromMonitor.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPacientsFromMonitor.Location = new System.Drawing.Point(10, 460);
            this.labelPacientsFromMonitor.Name = "labelPacientsFromMonitor";
            this.labelPacientsFromMonitor.Size = new System.Drawing.Size(240, 30);
            this.labelPacientsFromMonitor.TabIndex = 13;
            this.labelPacientsFromMonitor.Text = "Расстояние до монитора";
            // 
            // labelPacientsFilter
            // 
            this.labelPacientsFilter.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPacientsFilter.Location = new System.Drawing.Point(10, 380);
            this.labelPacientsFilter.Name = "labelPacientsFilter";
            this.labelPacientsFilter.Size = new System.Drawing.Size(95, 50);
            this.labelPacientsFilter.TabIndex = 12;
            this.labelPacientsFilter.Text = "Красный фильтр";
            // 
            // panelPacientsPanelFilter
            // 
            this.panelPacientsPanelFilter.Controls.Add(this.radioButtonPacientsFilterLeft);
            this.panelPacientsPanelFilter.Controls.Add(this.radioButtonPacientsFilterRight);
            this.panelPacientsPanelFilter.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelPacientsPanelFilter.Location = new System.Drawing.Point(110, 370);
            this.panelPacientsPanelFilter.Name = "panelPacientsPanelFilter";
            this.panelPacientsPanelFilter.Size = new System.Drawing.Size(100, 80);
            this.panelPacientsPanelFilter.TabIndex = 11;
            // 
            // radioButtonPacientsFilterLeft
            // 
            this.radioButtonPacientsFilterLeft.AutoSize = true;
            this.radioButtonPacientsFilterLeft.Location = new System.Drawing.Point(5, 41);
            this.radioButtonPacientsFilterLeft.Name = "radioButtonPacientsFilterLeft";
            this.radioButtonPacientsFilterLeft.Size = new System.Drawing.Size(83, 26);
            this.radioButtonPacientsFilterLeft.TabIndex = 1;
            this.radioButtonPacientsFilterLeft.Text = "левый";
            this.radioButtonPacientsFilterLeft.UseVisualStyleBackColor = true;
            this.radioButtonPacientsFilterLeft.CheckedChanged += new System.EventHandler(this.radioButtonPacientsFilterLeft_CheckedChanged);
            // 
            // radioButtonPacientsFilterRight
            // 
            this.radioButtonPacientsFilterRight.AutoSize = true;
            this.radioButtonPacientsFilterRight.Location = new System.Drawing.Point(5, 5);
            this.radioButtonPacientsFilterRight.Name = "radioButtonPacientsFilterRight";
            this.radioButtonPacientsFilterRight.Size = new System.Drawing.Size(92, 26);
            this.radioButtonPacientsFilterRight.TabIndex = 0;
            this.radioButtonPacientsFilterRight.Text = "правый";
            this.radioButtonPacientsFilterRight.UseVisualStyleBackColor = true;
            this.radioButtonPacientsFilterRight.CheckedChanged += new System.EventHandler(this.radioButtonPacientsFilterRight_CheckedChanged);
            // 
            // textBoxPacientComment
            // 
            this.textBoxPacientComment.Location = new System.Drawing.Point(220, 100);
            this.textBoxPacientComment.Multiline = true;
            this.textBoxPacientComment.Name = "textBoxPacientComment";
            this.textBoxPacientComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPacientComment.Size = new System.Drawing.Size(430, 250);
            this.textBoxPacientComment.TabIndex = 10;
            this.textBoxPacientComment.TextChanged += new System.EventHandler(this.textBoxPacientComment_TextChanged);
            // 
            // labelPacientsComment
            // 
            this.labelPacientsComment.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPacientsComment.Location = new System.Drawing.Point(220, 70);
            this.labelPacientsComment.Name = "labelPacientsComment";
            this.labelPacientsComment.Size = new System.Drawing.Size(130, 20);
            this.labelPacientsComment.TabIndex = 9;
            this.labelPacientsComment.Text = "Комментарий";
            // 
            // comboBoxPacients
            // 
            this.comboBoxPacients.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxPacients.FormattingEnabled = true;
            this.comboBoxPacients.Location = new System.Drawing.Point(20, 80);
            this.comboBoxPacients.Name = "comboBoxPacients";
            this.comboBoxPacients.Size = new System.Drawing.Size(165, 30);
            this.comboBoxPacients.TabIndex = 8;
            this.comboBoxPacients.SelectedIndexChanged += new System.EventHandler(this.comboBoxPacients_SelectedIndexChanged);
            // 
            // labelPacientsPacient
            // 
            this.labelPacientsPacient.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPacientsPacient.Location = new System.Drawing.Point(20, 50);
            this.labelPacientsPacient.Name = "labelPacientsPacient";
            this.labelPacientsPacient.Size = new System.Drawing.Size(90, 20);
            this.labelPacientsPacient.TabIndex = 7;
            this.labelPacientsPacient.Text = "пациент";
            // 
            // buttonPacientsCreate
            // 
            this.buttonPacientsCreate.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPacientsCreate.Location = new System.Drawing.Point(410, 520);
            this.buttonPacientsCreate.Name = "buttonPacientsCreate";
            this.buttonPacientsCreate.Size = new System.Drawing.Size(120, 30);
            this.buttonPacientsCreate.TabIndex = 4;
            this.buttonPacientsCreate.Text = "Создать";
            this.buttonPacientsCreate.UseVisualStyleBackColor = true;
            this.buttonPacientsCreate.Click += new System.EventHandler(this.buttonPacientsCreate_Click);
            // 
            // buttonPacientsHelp
            // 
            this.buttonPacientsHelp.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPacientsHelp.Location = new System.Drawing.Point(660, 50);
            this.buttonPacientsHelp.Name = "buttonPacientsHelp";
            this.buttonPacientsHelp.Size = new System.Drawing.Size(130, 30);
            this.buttonPacientsHelp.TabIndex = 0;
            this.buttonPacientsHelp.Text = "Помощь";
            this.buttonPacientsHelp.UseVisualStyleBackColor = true;
            this.buttonPacientsHelp.Click += new System.EventHandler(this.buttonPacientsHelp_Click);
            // 
            // panelSessions
            // 
            this.panelSessions.BackColor = System.Drawing.SystemColors.Control;
            this.panelSessions.Controls.Add(this.button3);
            this.panelSessions.Controls.Add(this.button1);
            this.panelSessions.Controls.Add(this.listViewSessionsPaterns);
            this.panelSessions.Controls.Add(this.buttonSessionsCreate);
            this.panelSessions.Controls.Add(this.buttonSessionsSave);
            this.panelSessions.Controls.Add(this.buttonSessionsCancel);
            this.panelSessions.Controls.Add(this.labelSessionsPaterns);
            this.panelSessions.Controls.Add(this.labelSessionsTasks);
            this.panelSessions.Controls.Add(this.buttonSessionsDel);
            this.panelSessions.Controls.Add(this.buttonSessionsPaternsForm);
            this.panelSessions.Controls.Add(this.buttonSessionsForm);
            this.panelSessions.Controls.Add(this.listViewSessionsTasks);
            this.panelSessions.Controls.Add(this.checkBoxSessionsPaternsAuto);
            this.panelSessions.Controls.Add(this.textBoxSessionDuration);
            this.panelSessions.Controls.Add(this.labelSessionDuration);
            this.panelSessions.Controls.Add(this.textBoxSessionComment);
            this.panelSessions.Controls.Add(this.comboBoxSession);
            this.panelSessions.Controls.Add(this.labelSession);
            this.panelSessions.Controls.Add(this.labelSessions);
            this.panelSessions.Controls.Add(this.buttonSessionsHelp);
            this.panelSessions.Location = new System.Drawing.Point(210, 5);
            this.panelSessions.Name = "panelSessions";
            this.panelSessions.Size = new System.Drawing.Size(800, 560);
            this.panelSessions.TabIndex = 3;
            this.panelSessions.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(162, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(20, 30);
            this.button3.TabIndex = 72;
            this.button3.Text = "!";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(10, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 30);
            this.button1.TabIndex = 26;
            this.button1.Text = "Сохранить ярлык";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listViewSessionsPaterns
            // 
            this.listViewSessionsPaterns.AutoArrange = false;
            this.listViewSessionsPaterns.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewSessionsPaterns.ContextMenuStrip = this.contextMenuStripPatterns;
            this.listViewSessionsPaterns.Enabled = false;
            this.listViewSessionsPaterns.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewSessionsPaterns.FullRowSelect = true;
            this.listViewSessionsPaterns.GridLines = true;
            this.listViewSessionsPaterns.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewSessionsPaterns.HideSelection = false;
            this.listViewSessionsPaterns.Location = new System.Drawing.Point(410, 200);
            this.listViewSessionsPaterns.MultiSelect = false;
            this.listViewSessionsPaterns.Name = "listViewSessionsPaterns";
            this.listViewSessionsPaterns.Size = new System.Drawing.Size(380, 220);
            this.listViewSessionsPaterns.TabIndex = 23;
            this.listViewSessionsPaterns.UseCompatibleStateImageBehavior = false;
            this.listViewSessionsPaterns.View = System.Windows.Forms.View.Details;
            this.listViewSessionsPaterns.SelectedIndexChanged += new System.EventHandler(this.listViewSessionsPaterns_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "№";
            this.columnHeader2.Width = 30;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Название";
            this.columnHeader3.Width = 300;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "сек.";
            this.columnHeader4.Width = 45;
            // 
            // contextMenuStripPatterns
            // 
            this.contextMenuStripPatterns.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripSeparator4,
            this.toolStripMenuItem3,
            this.toolStripSeparator5,
            this.toolStripMenuItem4,
            this.toolStripSeparator6,
            this.toolStripMenuItem5});
            this.contextMenuStripPatterns.Name = "contextMenuStriptasksNPaterns";
            this.contextMenuStripPatterns.Size = new System.Drawing.Size(129, 132);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.toolStripMenuItem1.Text = "Выше";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Enabled = false;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(128, 22);
            this.toolStripMenuItem2.Text = "Ниже";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(125, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(128, 22);
            this.toolStripMenuItem3.Text = "Добавить";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.buttonSessionsPaternsForm_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(125, 6);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Enabled = false;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(128, 22);
            this.toolStripMenuItem4.Text = "Изменить";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(125, 6);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Enabled = false;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(128, 22);
            this.toolStripMenuItem5.Text = "Удалить";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // buttonSessionsCreate
            // 
            this.buttonSessionsCreate.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSessionsCreate.Location = new System.Drawing.Point(410, 520);
            this.buttonSessionsCreate.Name = "buttonSessionsCreate";
            this.buttonSessionsCreate.Size = new System.Drawing.Size(120, 30);
            this.buttonSessionsCreate.TabIndex = 21;
            this.buttonSessionsCreate.Text = "Создать";
            this.buttonSessionsCreate.UseVisualStyleBackColor = true;
            this.buttonSessionsCreate.Click += new System.EventHandler(this.buttonSessionsCreate_Click);
            // 
            // buttonSessionsSave
            // 
            this.buttonSessionsSave.Enabled = false;
            this.buttonSessionsSave.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSessionsSave.Location = new System.Drawing.Point(540, 480);
            this.buttonSessionsSave.Name = "buttonSessionsSave";
            this.buttonSessionsSave.Size = new System.Drawing.Size(120, 30);
            this.buttonSessionsSave.TabIndex = 20;
            this.buttonSessionsSave.Text = "Сохранить";
            this.buttonSessionsSave.UseVisualStyleBackColor = true;
            this.buttonSessionsSave.Click += new System.EventHandler(this.buttonSessionsSave_Click);
            // 
            // buttonSessionsCancel
            // 
            this.buttonSessionsCancel.Enabled = false;
            this.buttonSessionsCancel.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSessionsCancel.Location = new System.Drawing.Point(670, 480);
            this.buttonSessionsCancel.Name = "buttonSessionsCancel";
            this.buttonSessionsCancel.Size = new System.Drawing.Size(120, 30);
            this.buttonSessionsCancel.TabIndex = 19;
            this.buttonSessionsCancel.Text = "Отменить";
            this.buttonSessionsCancel.UseVisualStyleBackColor = true;
            this.buttonSessionsCancel.Click += new System.EventHandler(this.buttonSessionsCancel_Click);
            // 
            // labelSessionsPaterns
            // 
            this.labelSessionsPaterns.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSessionsPaterns.Location = new System.Drawing.Point(405, 170);
            this.labelSessionsPaterns.Name = "labelSessionsPaterns";
            this.labelSessionsPaterns.Size = new System.Drawing.Size(100, 20);
            this.labelSessionsPaterns.TabIndex = 18;
            this.labelSessionsPaterns.Text = "паттерны";
            // 
            // labelSessionsTasks
            // 
            this.labelSessionsTasks.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSessionsTasks.Location = new System.Drawing.Point(20, 170);
            this.labelSessionsTasks.Name = "labelSessionsTasks";
            this.labelSessionsTasks.Size = new System.Drawing.Size(130, 20);
            this.labelSessionsTasks.TabIndex = 17;
            this.labelSessionsTasks.Text = "упражнения";
            // 
            // buttonSessionsDel
            // 
            this.buttonSessionsDel.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSessionsDel.Location = new System.Drawing.Point(540, 520);
            this.buttonSessionsDel.Name = "buttonSessionsDel";
            this.buttonSessionsDel.Size = new System.Drawing.Size(120, 30);
            this.buttonSessionsDel.TabIndex = 12;
            this.buttonSessionsDel.Text = "Удалить";
            this.buttonSessionsDel.UseVisualStyleBackColor = true;
            this.buttonSessionsDel.Click += new System.EventHandler(this.buttonSessionsDel_Click);
            // 
            // buttonSessionsPaternsForm
            // 
            this.buttonSessionsPaternsForm.Enabled = false;
            this.buttonSessionsPaternsForm.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSessionsPaternsForm.Location = new System.Drawing.Point(410, 430);
            this.buttonSessionsPaternsForm.Name = "buttonSessionsPaternsForm";
            this.buttonSessionsPaternsForm.Size = new System.Drawing.Size(240, 30);
            this.buttonSessionsPaternsForm.TabIndex = 11;
            this.buttonSessionsPaternsForm.Text = "Формирование паттернов";
            this.buttonSessionsPaternsForm.UseVisualStyleBackColor = true;
            this.buttonSessionsPaternsForm.Click += new System.EventHandler(this.buttonSessionsPaternsForm_Click);
            // 
            // buttonSessionsForm
            // 
            this.buttonSessionsForm.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSessionsForm.Location = new System.Drawing.Point(20, 430);
            this.buttonSessionsForm.Name = "buttonSessionsForm";
            this.buttonSessionsForm.Size = new System.Drawing.Size(260, 30);
            this.buttonSessionsForm.TabIndex = 10;
            this.buttonSessionsForm.Text = "Формирование упражнений";
            this.buttonSessionsForm.UseVisualStyleBackColor = true;
            this.buttonSessionsForm.Click += new System.EventHandler(this.buttonSessionsForm_Click);
            // 
            // listViewSessionsTasks
            // 
            this.listViewSessionsTasks.AutoArrange = false;
            this.listViewSessionsTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTasksN,
            this.columnHeaderTasksName,
            this.columnHeaderTasksSeconds});
            this.listViewSessionsTasks.ContextMenuStrip = this.contextMenuStriptasks;
            this.listViewSessionsTasks.Enabled = false;
            this.listViewSessionsTasks.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewSessionsTasks.FullRowSelect = true;
            this.listViewSessionsTasks.GridLines = true;
            this.listViewSessionsTasks.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewSessionsTasks.HideSelection = false;
            this.listViewSessionsTasks.Location = new System.Drawing.Point(20, 200);
            this.listViewSessionsTasks.MultiSelect = false;
            this.listViewSessionsTasks.Name = "listViewSessionsTasks";
            this.listViewSessionsTasks.Size = new System.Drawing.Size(380, 220);
            this.listViewSessionsTasks.TabIndex = 8;
            this.listViewSessionsTasks.UseCompatibleStateImageBehavior = false;
            this.listViewSessionsTasks.View = System.Windows.Forms.View.Details;
            this.listViewSessionsTasks.SelectedIndexChanged += new System.EventHandler(this.listViewSessionsTasks_SelectedIndexChanged);
            // 
            // columnHeaderTasksN
            // 
            this.columnHeaderTasksN.Text = "№";
            this.columnHeaderTasksN.Width = 30;
            // 
            // columnHeaderTasksName
            // 
            this.columnHeaderTasksName.Text = "Название";
            this.columnHeaderTasksName.Width = 300;
            // 
            // columnHeaderTasksSeconds
            // 
            this.columnHeaderTasksSeconds.Text = "сек.";
            this.columnHeaderTasksSeconds.Width = 45;
            // 
            // contextMenuStriptasks
            // 
            this.contextMenuStriptasks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemUp,
            this.toolStripMenuItemDown,
            this.toolStripSeparator1,
            this.toolStripMenuItemAdd,
            this.toolStripSeparator2,
            this.toolStripMenuChanged,
            this.toolStripSeparator3,
            this.toolStripMenuItemDel});
            this.contextMenuStriptasks.Name = "contextMenuStriptasksNPaterns";
            this.contextMenuStriptasks.Size = new System.Drawing.Size(129, 132);
            // 
            // toolStripMenuItemUp
            // 
            this.toolStripMenuItemUp.Enabled = false;
            this.toolStripMenuItemUp.Name = "toolStripMenuItemUp";
            this.toolStripMenuItemUp.Size = new System.Drawing.Size(128, 22);
            this.toolStripMenuItemUp.Text = "Выше";
            this.toolStripMenuItemUp.Click += new System.EventHandler(this.toolStripMenuItemUp_Click);
            // 
            // toolStripMenuItemDown
            // 
            this.toolStripMenuItemDown.Enabled = false;
            this.toolStripMenuItemDown.Name = "toolStripMenuItemDown";
            this.toolStripMenuItemDown.Size = new System.Drawing.Size(128, 22);
            this.toolStripMenuItemDown.Text = "Ниже";
            this.toolStripMenuItemDown.Click += new System.EventHandler(this.toolStripMenuItemDown_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(125, 6);
            // 
            // toolStripMenuItemAdd
            // 
            this.toolStripMenuItemAdd.Name = "toolStripMenuItemAdd";
            this.toolStripMenuItemAdd.Size = new System.Drawing.Size(128, 22);
            this.toolStripMenuItemAdd.Text = "Добавить";
            this.toolStripMenuItemAdd.Click += new System.EventHandler(this.buttonSessionsForm_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(125, 6);
            // 
            // toolStripMenuChanged
            // 
            this.toolStripMenuChanged.Enabled = false;
            this.toolStripMenuChanged.Name = "toolStripMenuChanged";
            this.toolStripMenuChanged.Size = new System.Drawing.Size(128, 22);
            this.toolStripMenuChanged.Text = "Изменить";
            this.toolStripMenuChanged.Click += new System.EventHandler(this.toolStripMenuChanged_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(125, 6);
            // 
            // toolStripMenuItemDel
            // 
            this.toolStripMenuItemDel.Enabled = false;
            this.toolStripMenuItemDel.Name = "toolStripMenuItemDel";
            this.toolStripMenuItemDel.Size = new System.Drawing.Size(128, 22);
            this.toolStripMenuItemDel.Text = "Удалить";
            this.toolStripMenuItemDel.Click += new System.EventHandler(this.toolStripMenuItemDel_Click);
            // 
            // checkBoxSessionsPaternsAuto
            // 
            this.checkBoxSessionsPaternsAuto.Enabled = false;
            this.checkBoxSessionsPaternsAuto.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxSessionsPaternsAuto.Location = new System.Drawing.Point(560, 170);
            this.checkBoxSessionsPaternsAuto.Name = "checkBoxSessionsPaternsAuto";
            this.checkBoxSessionsPaternsAuto.Size = new System.Drawing.Size(235, 20);
            this.checkBoxSessionsPaternsAuto.TabIndex = 7;
            this.checkBoxSessionsPaternsAuto.Text = "самостоятельное создание";
            this.checkBoxSessionsPaternsAuto.UseVisualStyleBackColor = true;
            this.checkBoxSessionsPaternsAuto.CheckedChanged += new System.EventHandler(this.checkBoxSessionsPaternsAuto_CheckedChanged);
            // 
            // textBoxSessionDuration
            // 
            this.textBoxSessionDuration.Enabled = false;
            this.textBoxSessionDuration.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSessionDuration.Location = new System.Drawing.Point(220, 125);
            this.textBoxSessionDuration.MaxLength = 5;
            this.textBoxSessionDuration.Name = "textBoxSessionDuration";
            this.textBoxSessionDuration.ReadOnly = true;
            this.textBoxSessionDuration.Size = new System.Drawing.Size(60, 26);
            this.textBoxSessionDuration.TabIndex = 6;
            // 
            // labelSessionDuration
            // 
            this.labelSessionDuration.AutoSize = true;
            this.labelSessionDuration.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSessionDuration.Location = new System.Drawing.Point(15, 130);
            this.labelSessionDuration.Name = "labelSessionDuration";
            this.labelSessionDuration.Size = new System.Drawing.Size(198, 18);
            this.labelSessionDuration.TabIndex = 5;
            this.labelSessionDuration.Text = "продолжительность (сек)";
            // 
            // textBoxSessionComment
            // 
            this.textBoxSessionComment.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSessionComment.Location = new System.Drawing.Point(190, 40);
            this.textBoxSessionComment.Multiline = true;
            this.textBoxSessionComment.Name = "textBoxSessionComment";
            this.textBoxSessionComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSessionComment.Size = new System.Drawing.Size(450, 80);
            this.textBoxSessionComment.TabIndex = 4;
            // 
            // comboBoxSession
            // 
            this.comboBoxSession.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSession.FormattingEnabled = true;
            this.comboBoxSession.Location = new System.Drawing.Point(10, 70);
            this.comboBoxSession.Name = "comboBoxSession";
            this.comboBoxSession.Size = new System.Drawing.Size(150, 30);
            this.comboBoxSession.TabIndex = 3;
            this.comboBoxSession.SelectedIndexChanged += new System.EventHandler(this.comboBoxSession_SelectedIndexChanged);
            // 
            // labelSession
            // 
            this.labelSession.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSession.Location = new System.Drawing.Point(10, 40);
            this.labelSession.Name = "labelSession";
            this.labelSession.Size = new System.Drawing.Size(70, 20);
            this.labelSession.TabIndex = 2;
            this.labelSession.Text = "сеанс";
            // 
            // labelSessions
            // 
            this.labelSessions.AutoSize = true;
            this.labelSessions.Location = new System.Drawing.Point(5, 5);
            this.labelSessions.Name = "labelSessions";
            this.labelSessions.Size = new System.Drawing.Size(105, 30);
            this.labelSessions.TabIndex = 1;
            this.labelSessions.Text = "Сеансы";
            // 
            // buttonSessionsHelp
            // 
            this.buttonSessionsHelp.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSessionsHelp.Location = new System.Drawing.Point(660, 50);
            this.buttonSessionsHelp.Name = "buttonSessionsHelp";
            this.buttonSessionsHelp.Size = new System.Drawing.Size(130, 30);
            this.buttonSessionsHelp.TabIndex = 0;
            this.buttonSessionsHelp.Text = "Помощь";
            this.buttonSessionsHelp.UseVisualStyleBackColor = true;
            this.buttonSessionsHelp.Click += new System.EventHandler(this.buttonSessionsHelp_Click);
            // 
            // panelLevels
            // 
            this.panelLevels.BackColor = System.Drawing.SystemColors.Control;
            this.panelLevels.Controls.Add(this.button2);
            this.panelLevels.Controls.Add(this.textBoxLevelsBonusDinamic);
            this.panelLevels.Controls.Add(this.labelLevelsBonusDinamic);
            this.panelLevels.Controls.Add(this.textBoxLevelsBonusSmall);
            this.panelLevels.Controls.Add(this.labelLevelsBonusSmall);
            this.panelLevels.Controls.Add(this.textBoxLevelsObjectSmallerK);
            this.panelLevels.Controls.Add(this.labellevelsObjectSmallerK);
            this.panelLevels.Controls.Add(this.labelLevelsObjectSmaller);
            this.panelLevels.Controls.Add(this.textBoxLevelsObjectCatch);
            this.panelLevels.Controls.Add(this.labelLevelsObjectCatch);
            this.panelLevels.Controls.Add(this.labelLevelsObject);
            this.panelLevels.Controls.Add(this.textBoxLevelsToleranceVertical);
            this.panelLevels.Controls.Add(this.labelLevelsToleranceVertical);
            this.panelLevels.Controls.Add(this.textBoxLevelsPacient);
            this.panelLevels.Controls.Add(this.textBoxLevelsBonusAccur);
            this.panelLevels.Controls.Add(this.labelLevelsBonusAccur);
            this.panelLevels.Controls.Add(this.labelLevelsBonus);
            this.panelLevels.Controls.Add(this.textBoxLevelsBallsCatch);
            this.panelLevels.Controls.Add(this.labelLevelsBallsCatch);
            this.panelLevels.Controls.Add(this.labelLevelsBalls);
            this.panelLevels.Controls.Add(this.textBoxLevelsToleranceHorizontal);
            this.panelLevels.Controls.Add(this.labelLevelsToleranceHorizontal);
            this.panelLevels.Controls.Add(this.labelLevelsTolerance);
            this.panelLevels.Controls.Add(this.labelLevelsTraining);
            this.panelLevels.Controls.Add(this.buttonLavelsUseForThisPacient);
            this.panelLevels.Controls.Add(this.buttonLevelsSave);
            this.panelLevels.Controls.Add(this.buttonLevelsCancel);
            this.panelLevels.Controls.Add(this.buttonLevelsDelete);
            this.panelLevels.Controls.Add(this.buttonLevelsHelp);
            this.panelLevels.Controls.Add(this.textBoxLevelsComment);
            this.panelLevels.Controls.Add(this.labelLevelsComment);
            this.panelLevels.Controls.Add(this.comboBoxLevels);
            this.panelLevels.Controls.Add(this.labelLevel);
            this.panelLevels.Controls.Add(this.labelLevels);
            this.panelLevels.Location = new System.Drawing.Point(210, 5);
            this.panelLevels.Name = "panelLevels";
            this.panelLevels.Size = new System.Drawing.Size(800, 560);
            this.panelLevels.TabIndex = 4;
            this.panelLevels.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(167, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(20, 30);
            this.button2.TabIndex = 71;
            this.button2.Text = "!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxLevelsBonusDinamic
            // 
            this.textBoxLevelsBonusDinamic.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLevelsBonusDinamic.Location = new System.Drawing.Point(540, 395);
            this.textBoxLevelsBonusDinamic.MaxLength = 3;
            this.textBoxLevelsBonusDinamic.Name = "textBoxLevelsBonusDinamic";
            this.textBoxLevelsBonusDinamic.Size = new System.Drawing.Size(40, 25);
            this.textBoxLevelsBonusDinamic.TabIndex = 70;
            this.textBoxLevelsBonusDinamic.TextChanged += new System.EventHandler(this.textBoxLevels_TextChanged);
            this.textBoxLevelsBonusDinamic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumeralsOnly);
            // 
            // labelLevelsBonusDinamic
            // 
            this.labelLevelsBonusDinamic.AutoSize = true;
            this.labelLevelsBonusDinamic.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLevelsBonusDinamic.Location = new System.Drawing.Point(420, 400);
            this.labelLevelsBonusDinamic.Name = "labelLevelsBonusDinamic";
            this.labelLevelsBonusDinamic.Size = new System.Drawing.Size(89, 18);
            this.labelLevelsBonusDinamic.TabIndex = 69;
            this.labelLevelsBonusDinamic.Text = "- динамика";
            // 
            // textBoxLevelsBonusSmall
            // 
            this.textBoxLevelsBonusSmall.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLevelsBonusSmall.Location = new System.Drawing.Point(540, 365);
            this.textBoxLevelsBonusSmall.MaxLength = 3;
            this.textBoxLevelsBonusSmall.Name = "textBoxLevelsBonusSmall";
            this.textBoxLevelsBonusSmall.Size = new System.Drawing.Size(40, 25);
            this.textBoxLevelsBonusSmall.TabIndex = 68;
            this.textBoxLevelsBonusSmall.TextChanged += new System.EventHandler(this.textBoxLevels_TextChanged);
            this.textBoxLevelsBonusSmall.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumeralsOnly);
            // 
            // labelLevelsBonusSmall
            // 
            this.labelLevelsBonusSmall.AutoSize = true;
            this.labelLevelsBonusSmall.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLevelsBonusSmall.Location = new System.Drawing.Point(420, 370);
            this.labelLevelsBonusSmall.Name = "labelLevelsBonusSmall";
            this.labelLevelsBonusSmall.Size = new System.Drawing.Size(70, 18);
            this.labelLevelsBonusSmall.TabIndex = 67;
            this.labelLevelsBonusSmall.Text = "- размер";
            // 
            // textBoxLevelsObjectSmallerK
            // 
            this.textBoxLevelsObjectSmallerK.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLevelsObjectSmallerK.Location = new System.Drawing.Point(310, 429);
            this.textBoxLevelsObjectSmallerK.MaxLength = 3;
            this.textBoxLevelsObjectSmallerK.Name = "textBoxLevelsObjectSmallerK";
            this.textBoxLevelsObjectSmallerK.Size = new System.Drawing.Size(40, 25);
            this.textBoxLevelsObjectSmallerK.TabIndex = 64;
            this.textBoxLevelsObjectSmallerK.TextChanged += new System.EventHandler(this.textBoxLevels_TextChanged);
            this.textBoxLevelsObjectSmallerK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumeralsOnly);
            // 
            // labellevelsObjectSmallerK
            // 
            this.labellevelsObjectSmallerK.AutoSize = true;
            this.labellevelsObjectSmallerK.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labellevelsObjectSmallerK.Location = new System.Drawing.Point(167, 432);
            this.labellevelsObjectSmallerK.Name = "labellevelsObjectSmallerK";
            this.labellevelsObjectSmallerK.Size = new System.Drawing.Size(139, 18);
            this.labellevelsObjectSmallerK.TabIndex = 63;
            this.labellevelsObjectSmallerK.Text = "коэффициент (%)";
            // 
            // labelLevelsObjectSmaller
            // 
            this.labelLevelsObjectSmaller.AutoSize = true;
            this.labelLevelsObjectSmaller.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLevelsObjectSmaller.Location = new System.Drawing.Point(30, 420);
            this.labelLevelsObjectSmaller.Name = "labelLevelsObjectSmaller";
            this.labelLevelsObjectSmaller.Size = new System.Drawing.Size(84, 46);
            this.labelLevelsObjectSmaller.TabIndex = 62;
            this.labelLevelsObjectSmaller.Text = "размер\r\nобъекта";
            // 
            // textBoxLevelsObjectCatch
            // 
            this.textBoxLevelsObjectCatch.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLevelsObjectCatch.Location = new System.Drawing.Point(310, 343);
            this.textBoxLevelsObjectCatch.MaxLength = 3;
            this.textBoxLevelsObjectCatch.Name = "textBoxLevelsObjectCatch";
            this.textBoxLevelsObjectCatch.Size = new System.Drawing.Size(40, 25);
            this.textBoxLevelsObjectCatch.TabIndex = 59;
            this.textBoxLevelsObjectCatch.Text = "1";
            this.textBoxLevelsObjectCatch.TextChanged += new System.EventHandler(this.textBoxLevels_TextChanged);
            this.textBoxLevelsObjectCatch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumeralsOnly);
            // 
            // labelLevelsObjectCatch
            // 
            this.labelLevelsObjectCatch.AutoSize = true;
            this.labelLevelsObjectCatch.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLevelsObjectCatch.Location = new System.Drawing.Point(143, 338);
            this.labelLevelsObjectCatch.Name = "labelLevelsObjectCatch";
            this.labelLevelsObjectCatch.Size = new System.Drawing.Size(157, 36);
            this.labelLevelsObjectCatch.TabIndex = 58;
            this.labelLevelsObjectCatch.Text = "количество показов\r\nобъекта";
            // 
            // labelLevelsObject
            // 
            this.labelLevelsObject.AutoSize = true;
            this.labelLevelsObject.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLevelsObject.Location = new System.Drawing.Point(30, 340);
            this.labelLevelsObject.Name = "labelLevelsObject";
            this.labelLevelsObject.Size = new System.Drawing.Size(84, 46);
            this.labelLevelsObject.TabIndex = 57;
            this.labelLevelsObject.Text = "смена \r\nобъекта";
            // 
            // textBoxLevelsToleranceVertical
            // 
            this.textBoxLevelsToleranceVertical.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLevelsToleranceVertical.Location = new System.Drawing.Point(310, 285);
            this.textBoxLevelsToleranceVertical.MaxLength = 3;
            this.textBoxLevelsToleranceVertical.Name = "textBoxLevelsToleranceVertical";
            this.textBoxLevelsToleranceVertical.Size = new System.Drawing.Size(40, 25);
            this.textBoxLevelsToleranceVertical.TabIndex = 56;
            this.textBoxLevelsToleranceVertical.TextChanged += new System.EventHandler(this.textBoxLevels_TextChanged);
            this.textBoxLevelsToleranceVertical.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumeralsOnly);
            // 
            // labelLevelsToleranceVertical
            // 
            this.labelLevelsToleranceVertical.AutoSize = true;
            this.labelLevelsToleranceVertical.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLevelsToleranceVertical.Location = new System.Drawing.Point(170, 290);
            this.labelLevelsToleranceVertical.Name = "labelLevelsToleranceVertical";
            this.labelLevelsToleranceVertical.Size = new System.Drawing.Size(116, 18);
            this.labelLevelsToleranceVertical.TabIndex = 55;
            this.labelLevelsToleranceVertical.Text = "вертикальный";
            // 
            // textBoxLevelsPacient
            // 
            this.textBoxLevelsPacient.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLevelsPacient.Location = new System.Drawing.Point(120, 30);
            this.textBoxLevelsPacient.Name = "textBoxLevelsPacient";
            this.textBoxLevelsPacient.ReadOnly = true;
            this.textBoxLevelsPacient.Size = new System.Drawing.Size(300, 34);
            this.textBoxLevelsPacient.TabIndex = 54;
            // 
            // textBoxLevelsBonusAccur
            // 
            this.textBoxLevelsBonusAccur.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLevelsBonusAccur.Location = new System.Drawing.Point(540, 335);
            this.textBoxLevelsBonusAccur.MaxLength = 3;
            this.textBoxLevelsBonusAccur.Name = "textBoxLevelsBonusAccur";
            this.textBoxLevelsBonusAccur.Size = new System.Drawing.Size(40, 25);
            this.textBoxLevelsBonusAccur.TabIndex = 49;
            this.textBoxLevelsBonusAccur.TextChanged += new System.EventHandler(this.textBoxLevels_TextChanged);
            this.textBoxLevelsBonusAccur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumeralsOnly);
            // 
            // labelLevelsBonusAccur
            // 
            this.labelLevelsBonusAccur.AutoSize = true;
            this.labelLevelsBonusAccur.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLevelsBonusAccur.Location = new System.Drawing.Point(420, 340);
            this.labelLevelsBonusAccur.Name = "labelLevelsBonusAccur";
            this.labelLevelsBonusAccur.Size = new System.Drawing.Size(82, 18);
            this.labelLevelsBonusAccur.TabIndex = 48;
            this.labelLevelsBonusAccur.Text = "- точность";
            // 
            // labelLevelsBonus
            // 
            this.labelLevelsBonus.AutoSize = true;
            this.labelLevelsBonus.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLevelsBonus.Location = new System.Drawing.Point(450, 300);
            this.labelLevelsBonus.Name = "labelLevelsBonus";
            this.labelLevelsBonus.Size = new System.Drawing.Size(112, 23);
            this.labelLevelsBonus.TabIndex = 47;
            this.labelLevelsBonus.Text = "бонусы (%)";
            // 
            // textBoxLevelsBallsCatch
            // 
            this.textBoxLevelsBallsCatch.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLevelsBallsCatch.Location = new System.Drawing.Point(540, 255);
            this.textBoxLevelsBallsCatch.MaxLength = 3;
            this.textBoxLevelsBallsCatch.Name = "textBoxLevelsBallsCatch";
            this.textBoxLevelsBallsCatch.Size = new System.Drawing.Size(40, 25);
            this.textBoxLevelsBallsCatch.TabIndex = 46;
            this.textBoxLevelsBallsCatch.TextChanged += new System.EventHandler(this.textBoxLevels_TextChanged);
            this.textBoxLevelsBallsCatch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumeralsOnly);
            // 
            // labelLevelsBallsCatch
            // 
            this.labelLevelsBallsCatch.AutoSize = true;
            this.labelLevelsBallsCatch.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLevelsBallsCatch.Location = new System.Drawing.Point(420, 260);
            this.labelLevelsBallsCatch.Name = "labelLevelsBallsCatch";
            this.labelLevelsBallsCatch.Size = new System.Drawing.Size(107, 18);
            this.labelLevelsBallsCatch.TabIndex = 45;
            this.labelLevelsBallsCatch.Text = "за попадание";
            // 
            // labelLevelsBalls
            // 
            this.labelLevelsBalls.AutoSize = true;
            this.labelLevelsBalls.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLevelsBalls.Location = new System.Drawing.Point(450, 220);
            this.labelLevelsBalls.Name = "labelLevelsBalls";
            this.labelLevelsBalls.Size = new System.Drawing.Size(69, 23);
            this.labelLevelsBalls.TabIndex = 44;
            this.labelLevelsBalls.Text = "баллы";
            // 
            // textBoxLevelsToleranceHorizontal
            // 
            this.textBoxLevelsToleranceHorizontal.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLevelsToleranceHorizontal.Location = new System.Drawing.Point(310, 255);
            this.textBoxLevelsToleranceHorizontal.MaxLength = 3;
            this.textBoxLevelsToleranceHorizontal.Name = "textBoxLevelsToleranceHorizontal";
            this.textBoxLevelsToleranceHorizontal.Size = new System.Drawing.Size(40, 25);
            this.textBoxLevelsToleranceHorizontal.TabIndex = 32;
            this.textBoxLevelsToleranceHorizontal.TextChanged += new System.EventHandler(this.textBoxLevels_TextChanged);
            this.textBoxLevelsToleranceHorizontal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumeralsOnly);
            // 
            // labelLevelsToleranceHorizontal
            // 
            this.labelLevelsToleranceHorizontal.AutoSize = true;
            this.labelLevelsToleranceHorizontal.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLevelsToleranceHorizontal.Location = new System.Drawing.Point(170, 260);
            this.labelLevelsToleranceHorizontal.Name = "labelLevelsToleranceHorizontal";
            this.labelLevelsToleranceHorizontal.Size = new System.Drawing.Size(130, 18);
            this.labelLevelsToleranceHorizontal.TabIndex = 30;
            this.labelLevelsToleranceHorizontal.Text = "горизонтальный";
            // 
            // labelLevelsTolerance
            // 
            this.labelLevelsTolerance.AutoSize = true;
            this.labelLevelsTolerance.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLevelsTolerance.Location = new System.Drawing.Point(30, 270);
            this.labelLevelsTolerance.Name = "labelLevelsTolerance";
            this.labelLevelsTolerance.Size = new System.Drawing.Size(74, 23);
            this.labelLevelsTolerance.TabIndex = 29;
            this.labelLevelsTolerance.Text = "допуск";
            // 
            // labelLevelsTraining
            // 
            this.labelLevelsTraining.AutoSize = true;
            this.labelLevelsTraining.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLevelsTraining.Location = new System.Drawing.Point(60, 220);
            this.labelLevelsTraining.Name = "labelLevelsTraining";
            this.labelLevelsTraining.Size = new System.Drawing.Size(115, 23);
            this.labelLevelsTraining.TabIndex = 28;
            this.labelLevelsTraining.Text = "тренировка";
            // 
            // buttonLavelsUseForThisPacient
            // 
            this.buttonLavelsUseForThisPacient.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLavelsUseForThisPacient.Location = new System.Drawing.Point(410, 521);
            this.buttonLavelsUseForThisPacient.Name = "buttonLavelsUseForThisPacient";
            this.buttonLavelsUseForThisPacient.Size = new System.Drawing.Size(120, 30);
            this.buttonLavelsUseForThisPacient.TabIndex = 26;
            this.buttonLavelsUseForThisPacient.Text = "Создать";
            this.buttonLavelsUseForThisPacient.UseVisualStyleBackColor = true;
            this.buttonLavelsUseForThisPacient.Click += new System.EventHandler(this.buttonLavelsUseForThisPacient_Click);
            // 
            // buttonLevelsSave
            // 
            this.buttonLevelsSave.Enabled = false;
            this.buttonLevelsSave.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLevelsSave.Location = new System.Drawing.Point(540, 480);
            this.buttonLevelsSave.Name = "buttonLevelsSave";
            this.buttonLevelsSave.Size = new System.Drawing.Size(120, 30);
            this.buttonLevelsSave.TabIndex = 25;
            this.buttonLevelsSave.Text = "Сохранить";
            this.buttonLevelsSave.UseVisualStyleBackColor = true;
            this.buttonLevelsSave.Click += new System.EventHandler(this.buttonLevelsSave_Click);
            // 
            // buttonLevelsCancel
            // 
            this.buttonLevelsCancel.Enabled = false;
            this.buttonLevelsCancel.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLevelsCancel.Location = new System.Drawing.Point(670, 480);
            this.buttonLevelsCancel.Name = "buttonLevelsCancel";
            this.buttonLevelsCancel.Size = new System.Drawing.Size(120, 30);
            this.buttonLevelsCancel.TabIndex = 24;
            this.buttonLevelsCancel.Text = "Отменить";
            this.buttonLevelsCancel.UseVisualStyleBackColor = true;
            this.buttonLevelsCancel.Click += new System.EventHandler(this.buttonLevelsCancel_Click);
            // 
            // buttonLevelsDelete
            // 
            this.buttonLevelsDelete.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLevelsDelete.Location = new System.Drawing.Point(540, 520);
            this.buttonLevelsDelete.Name = "buttonLevelsDelete";
            this.buttonLevelsDelete.Size = new System.Drawing.Size(120, 30);
            this.buttonLevelsDelete.TabIndex = 23;
            this.buttonLevelsDelete.Text = "Удалить";
            this.buttonLevelsDelete.UseVisualStyleBackColor = true;
            this.buttonLevelsDelete.Click += new System.EventHandler(this.buttonLevelsDelete_Click);
            // 
            // buttonLevelsHelp
            // 
            this.buttonLevelsHelp.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonLevelsHelp.Location = new System.Drawing.Point(660, 50);
            this.buttonLevelsHelp.Name = "buttonLevelsHelp";
            this.buttonLevelsHelp.Size = new System.Drawing.Size(130, 30);
            this.buttonLevelsHelp.TabIndex = 6;
            this.buttonLevelsHelp.Text = "Помощь";
            this.buttonLevelsHelp.UseVisualStyleBackColor = true;
            this.buttonLevelsHelp.Click += new System.EventHandler(this.buttonLevelsHelp_Click);
            // 
            // textBoxLevelsComment
            // 
            this.textBoxLevelsComment.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLevelsComment.Location = new System.Drawing.Point(190, 110);
            this.textBoxLevelsComment.Multiline = true;
            this.textBoxLevelsComment.Name = "textBoxLevelsComment";
            this.textBoxLevelsComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLevelsComment.Size = new System.Drawing.Size(450, 80);
            this.textBoxLevelsComment.TabIndex = 5;
            this.textBoxLevelsComment.TextChanged += new System.EventHandler(this.textBoxLevels_TextChanged);
            // 
            // labelLevelsComment
            // 
            this.labelLevelsComment.AutoSize = true;
            this.labelLevelsComment.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLevelsComment.Location = new System.Drawing.Point(200, 80);
            this.labelLevelsComment.Name = "labelLevelsComment";
            this.labelLevelsComment.Size = new System.Drawing.Size(133, 23);
            this.labelLevelsComment.TabIndex = 4;
            this.labelLevelsComment.Text = "комментарий";
            // 
            // comboBoxLevels
            // 
            this.comboBoxLevels.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxLevels.FormattingEnabled = true;
            this.comboBoxLevels.Location = new System.Drawing.Point(15, 110);
            this.comboBoxLevels.Name = "comboBoxLevels";
            this.comboBoxLevels.Size = new System.Drawing.Size(150, 26);
            this.comboBoxLevels.TabIndex = 3;
            this.comboBoxLevels.SelectedIndexChanged += new System.EventHandler(this.comboBoxLevels_SelectedIndexChanged);
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLevel.Location = new System.Drawing.Point(15, 80);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(84, 23);
            this.labelLevel.TabIndex = 2;
            this.labelLevel.Text = "уровень";
            // 
            // labelLevels
            // 
            this.labelLevels.AutoSize = true;
            this.labelLevels.Location = new System.Drawing.Point(5, 5);
            this.labelLevels.Name = "labelLevels";
            this.labelLevels.Size = new System.Drawing.Size(98, 30);
            this.labelLevels.TabIndex = 0;
            this.labelLevels.Text = "Уровни";
            // 
            // panelResults
            // 
            this.panelResults.BackColor = System.Drawing.SystemColors.Control;
            this.panelResults.Controls.Add(this.buttonResultUpdateResults);
            this.panelResults.Controls.Add(this.listViewResultsSum);
            this.panelResults.Controls.Add(this.textBoxResultsPacientsLatest);
            this.panelResults.Controls.Add(this.textBoxResultsPacientFirst);
            this.panelResults.Controls.Add(this.labelResultsPacientDates);
            this.panelResults.Controls.Add(this.textBoxResultsPacientDoneTime);
            this.panelResults.Controls.Add(this.textBoxResultsPacientDoneSessions);
            this.panelResults.Controls.Add(this.labelResultsPacientDone);
            this.panelResults.Controls.Add(this.buttonResultsComment);
            this.panelResults.Controls.Add(this.buttonResultsFile);
            this.panelResults.Controls.Add(this.buttonResultsDel);
            this.panelResults.Controls.Add(this.buttonResultsHelp);
            this.panelResults.Controls.Add(this.listViewResults);
            this.panelResults.Controls.Add(this.textBoxResultsPatient);
            this.panelResults.Controls.Add(this.labelResultsPatient);
            this.panelResults.Controls.Add(this.labelResults);
            this.panelResults.Location = new System.Drawing.Point(210, 5);
            this.panelResults.Name = "panelResults";
            this.panelResults.Size = new System.Drawing.Size(800, 560);
            this.panelResults.TabIndex = 5;
            this.panelResults.Visible = false;
            // 
            // listViewResultsSum
            // 
            this.listViewResultsSum.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderResultsSumName,
            this.columnHeaderResultsSumTime,
            this.columnHeaderResultsSumHor,
            this.columnHeaderResultsSumHorDin,
            this.columnHeaderResultsSumVert,
            this.columnHeaderResultsSumVertDin,
            this.columnHeaderResultsSumCatch,
            this.columnHeaderResultsSumMiss,
            this.columnHeaderResultsSumBalls});
            this.listViewResultsSum.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewResultsSum.FullRowSelect = true;
            this.listViewResultsSum.GridLines = true;
            this.listViewResultsSum.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewResultsSum.HideSelection = false;
            this.listViewResultsSum.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5,
            listViewItem6});
            this.listViewResultsSum.Location = new System.Drawing.Point(20, 460);
            this.listViewResultsSum.Name = "listViewResultsSum";
            this.listViewResultsSum.Size = new System.Drawing.Size(760, 45);
            this.listViewResultsSum.TabIndex = 41;
            this.listViewResultsSum.UseCompatibleStateImageBehavior = false;
            this.listViewResultsSum.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderResultsSumName
            // 
            this.columnHeaderResultsSumName.Text = "Дата";
            this.columnHeaderResultsSumName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderResultsSumName.Width = 235;
            // 
            // columnHeaderResultsSumTime
            // 
            this.columnHeaderResultsSumTime.Text = "Время";
            this.columnHeaderResultsSumTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderResultsSumTime.Width = 70;
            // 
            // columnHeaderResultsSumHor
            // 
            this.columnHeaderResultsSumHor.Text = "горизонт.откл.";
            this.columnHeaderResultsSumHor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeaderResultsSumHorDin
            // 
            this.columnHeaderResultsSumHorDin.Text = "гор.дин.";
            this.columnHeaderResultsSumHorDin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeaderResultsSumVert
            // 
            this.columnHeaderResultsSumVert.Text = "вертикал.откл";
            this.columnHeaderResultsSumVert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderResultsSumVert.Width = 65;
            // 
            // columnHeaderResultsSumVertDin
            // 
            this.columnHeaderResultsSumVertDin.Text = "верт.дин.";
            this.columnHeaderResultsSumVertDin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderResultsSumVertDin.Width = 65;
            // 
            // columnHeaderResultsSumCatch
            // 
            this.columnHeaderResultsSumCatch.Text = "Попадание";
            this.columnHeaderResultsSumCatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderResultsSumCatch.Width = 80;
            // 
            // columnHeaderResultsSumMiss
            // 
            this.columnHeaderResultsSumMiss.Text = "Промах";
            this.columnHeaderResultsSumMiss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeaderResultsSumBalls
            // 
            this.columnHeaderResultsSumBalls.Text = "Баллы";
            this.columnHeaderResultsSumBalls.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxResultsPacientsLatest
            // 
            this.textBoxResultsPacientsLatest.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResultsPacientsLatest.Location = new System.Drawing.Point(320, 115);
            this.textBoxResultsPacientsLatest.Name = "textBoxResultsPacientsLatest";
            this.textBoxResultsPacientsLatest.ReadOnly = true;
            this.textBoxResultsPacientsLatest.Size = new System.Drawing.Size(150, 25);
            this.textBoxResultsPacientsLatest.TabIndex = 40;
            this.textBoxResultsPacientsLatest.Text = "последняя";
            // 
            // textBoxResultsPacientFirst
            // 
            this.textBoxResultsPacientFirst.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResultsPacientFirst.Location = new System.Drawing.Point(320, 85);
            this.textBoxResultsPacientFirst.Name = "textBoxResultsPacientFirst";
            this.textBoxResultsPacientFirst.ReadOnly = true;
            this.textBoxResultsPacientFirst.Size = new System.Drawing.Size(150, 25);
            this.textBoxResultsPacientFirst.TabIndex = 39;
            this.textBoxResultsPacientFirst.Text = "первая";
            // 
            // labelResultsPacientDates
            // 
            this.labelResultsPacientDates.AutoSize = true;
            this.labelResultsPacientDates.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResultsPacientDates.Location = new System.Drawing.Point(160, 90);
            this.labelResultsPacientDates.Name = "labelResultsPacientDates";
            this.labelResultsPacientDates.Size = new System.Drawing.Size(150, 19);
            this.labelResultsPacientDates.TabIndex = 38;
            this.labelResultsPacientDates.Text = "Даты тренировок";
            // 
            // textBoxResultsPacientDoneTime
            // 
            this.textBoxResultsPacientDoneTime.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResultsPacientDoneTime.Location = new System.Drawing.Point(430, 55);
            this.textBoxResultsPacientDoneTime.Name = "textBoxResultsPacientDoneTime";
            this.textBoxResultsPacientDoneTime.ReadOnly = true;
            this.textBoxResultsPacientDoneTime.Size = new System.Drawing.Size(150, 25);
            this.textBoxResultsPacientDoneTime.TabIndex = 37;
            this.textBoxResultsPacientDoneTime.Text = "время";
            // 
            // textBoxResultsPacientDoneSessions
            // 
            this.textBoxResultsPacientDoneSessions.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResultsPacientDoneSessions.Location = new System.Drawing.Point(270, 55);
            this.textBoxResultsPacientDoneSessions.Name = "textBoxResultsPacientDoneSessions";
            this.textBoxResultsPacientDoneSessions.ReadOnly = true;
            this.textBoxResultsPacientDoneSessions.Size = new System.Drawing.Size(150, 25);
            this.textBoxResultsPacientDoneSessions.TabIndex = 36;
            this.textBoxResultsPacientDoneSessions.Text = "сеансов";
            // 
            // labelResultsPacientDone
            // 
            this.labelResultsPacientDone.AutoSize = true;
            this.labelResultsPacientDone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResultsPacientDone.Location = new System.Drawing.Point(160, 60);
            this.labelResultsPacientDone.Name = "labelResultsPacientDone";
            this.labelResultsPacientDone.Size = new System.Drawing.Size(104, 19);
            this.labelResultsPacientDone.TabIndex = 35;
            this.labelResultsPacientDone.Text = "Выполнено";
            // 
            // buttonResultsComment
            // 
            this.buttonResultsComment.Enabled = false;
            this.buttonResultsComment.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResultsComment.Location = new System.Drawing.Point(20, 520);
            this.buttonResultsComment.Name = "buttonResultsComment";
            this.buttonResultsComment.Size = new System.Drawing.Size(160, 30);
            this.buttonResultsComment.TabIndex = 34;
            this.buttonResultsComment.Text = "Комментарий";
            this.buttonResultsComment.UseVisualStyleBackColor = true;
            this.buttonResultsComment.Click += new System.EventHandler(this.buttonResultsComment_Click);
            // 
            // buttonResultsFile
            // 
            this.buttonResultsFile.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResultsFile.Location = new System.Drawing.Point(660, 520);
            this.buttonResultsFile.Name = "buttonResultsFile";
            this.buttonResultsFile.Size = new System.Drawing.Size(120, 30);
            this.buttonResultsFile.TabIndex = 33;
            this.buttonResultsFile.Text = "Сохранить в файл";
            this.buttonResultsFile.UseVisualStyleBackColor = true;
            this.buttonResultsFile.Click += new System.EventHandler(this.buttonResultsFile_Click);
            // 
            // buttonResultsDel
            // 
            this.buttonResultsDel.Enabled = false;
            this.buttonResultsDel.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonResultsDel.Location = new System.Drawing.Point(530, 520);
            this.buttonResultsDel.Name = "buttonResultsDel";
            this.buttonResultsDel.Size = new System.Drawing.Size(120, 30);
            this.buttonResultsDel.TabIndex = 28;
            this.buttonResultsDel.Text = "Удалить запись";
            this.buttonResultsDel.UseVisualStyleBackColor = true;
            // 
            // buttonResultsHelp
            // 
            this.buttonResultsHelp.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResultsHelp.Location = new System.Drawing.Point(660, 50);
            this.buttonResultsHelp.Name = "buttonResultsHelp";
            this.buttonResultsHelp.Size = new System.Drawing.Size(130, 30);
            this.buttonResultsHelp.TabIndex = 10;
            this.buttonResultsHelp.Text = "Помощь";
            this.buttonResultsHelp.UseVisualStyleBackColor = true;
            this.buttonResultsHelp.Click += new System.EventHandler(this.buttonResultsHelp_Click);
            // 
            // listViewResults
            // 
            this.listViewResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderN,
            this.columnHeaderDateName,
            this.columnHeaderTime,
            this.columnHeaderHorDev,
            this.columnHeaderHorDevDin,
            this.columnHeaderVertDev,
            this.columnHeaderVertDevDin,
            this.columnHeaderHit,
            this.columnHeaderMiss,
            this.columnHeaderBalls});
            this.listViewResults.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewResults.FullRowSelect = true;
            this.listViewResults.GridLines = true;
            this.listViewResults.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewResults.HideSelection = false;
            this.listViewResults.Location = new System.Drawing.Point(20, 150);
            this.listViewResults.MultiSelect = false;
            this.listViewResults.Name = "listViewResults";
            this.listViewResults.Size = new System.Drawing.Size(760, 310);
            this.listViewResults.TabIndex = 9;
            this.listViewResults.UseCompatibleStateImageBehavior = false;
            this.listViewResults.View = System.Windows.Forms.View.Details;
            this.listViewResults.SelectedIndexChanged += new System.EventHandler(this.listViewResults_SelectedIndexChanged);
            // 
            // columnHeaderN
            // 
            this.columnHeaderN.Text = "№";
            this.columnHeaderN.Width = 30;
            // 
            // columnHeaderDateName
            // 
            this.columnHeaderDateName.Text = "Дата и название";
            this.columnHeaderDateName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderDateName.Width = 205;
            // 
            // columnHeaderTime
            // 
            this.columnHeaderTime.Text = "Время";
            this.columnHeaderTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderTime.Width = 70;
            // 
            // columnHeaderHorDev
            // 
            this.columnHeaderHorDev.Text = "гор.откл.";
            this.columnHeaderHorDev.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeaderHorDevDin
            // 
            this.columnHeaderHorDevDin.Text = "гор.дин.";
            this.columnHeaderHorDevDin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeaderVertDev
            // 
            this.columnHeaderVertDev.Text = "верт.откл";
            this.columnHeaderVertDev.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderVertDev.Width = 65;
            // 
            // columnHeaderVertDevDin
            // 
            this.columnHeaderVertDevDin.Text = "верт.дин.";
            this.columnHeaderVertDevDin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderVertDevDin.Width = 65;
            // 
            // columnHeaderHit
            // 
            this.columnHeaderHit.Text = "Попадание";
            this.columnHeaderHit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderHit.Width = 80;
            // 
            // columnHeaderMiss
            // 
            this.columnHeaderMiss.Text = "Промах";
            this.columnHeaderMiss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeaderBalls
            // 
            this.columnHeaderBalls.Text = "Баллы";
            this.columnHeaderBalls.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxResultsPatient
            // 
            this.textBoxResultsPatient.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResultsPatient.Location = new System.Drawing.Point(250, 25);
            this.textBoxResultsPatient.Name = "textBoxResultsPatient";
            this.textBoxResultsPatient.ReadOnly = true;
            this.textBoxResultsPatient.Size = new System.Drawing.Size(200, 25);
            this.textBoxResultsPatient.TabIndex = 2;
            // 
            // labelResultsPatient
            // 
            this.labelResultsPatient.AutoSize = true;
            this.labelResultsPatient.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResultsPatient.Location = new System.Drawing.Point(160, 30);
            this.labelResultsPatient.Name = "labelResultsPatient";
            this.labelResultsPatient.Size = new System.Drawing.Size(77, 19);
            this.labelResultsPatient.TabIndex = 1;
            this.labelResultsPatient.Text = "Пациент";
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Location = new System.Drawing.Point(5, 5);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(152, 30);
            this.labelResults.TabIndex = 0;
            this.labelResults.Text = "Результаты";
            // 
            // panelPalitre
            // 
            this.panelPalitre.BackColor = System.Drawing.SystemColors.Control;
            this.panelPalitre.Controls.Add(this.pictureBoxPalitres);
            this.panelPalitre.Controls.Add(this.labelPalitreR);
            this.panelPalitre.Controls.Add(this.trackBarPalitreR);
            this.panelPalitre.Controls.Add(this.labelPalitreG);
            this.panelPalitre.Controls.Add(this.trackBarPalitreG);
            this.panelPalitre.Controls.Add(this.labelPalitreB);
            this.panelPalitre.Controls.Add(this.trackBarPalitreB);
            this.panelPalitre.Controls.Add(this.labelPalitre);
            this.panelPalitre.Controls.Add(this.buttonPalitreDefault);
            this.panelPalitre.Controls.Add(this.buttonPalitreSave);
            this.panelPalitre.Controls.Add(this.buttonPalitreCancel);
            this.panelPalitre.Controls.Add(this.buttonPalitreHelp);
            this.panelPalitre.Controls.Add(this.groupBoxPalitreColors);
            this.panelPalitre.Controls.Add(this.pictureBoxPalitre);
            this.panelPalitre.Location = new System.Drawing.Point(210, 5);
            this.panelPalitre.Name = "panelPalitre";
            this.panelPalitre.Size = new System.Drawing.Size(800, 560);
            this.panelPalitre.TabIndex = 6;
            this.panelPalitre.Visible = false;
            // 
            // labelPalitreR
            // 
            this.labelPalitreR.AutoSize = true;
            this.labelPalitreR.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPalitreR.Location = new System.Drawing.Point(560, 10);
            this.labelPalitreR.Name = "labelPalitreR";
            this.labelPalitreR.Size = new System.Drawing.Size(22, 23);
            this.labelPalitreR.TabIndex = 45;
            this.labelPalitreR.Text = "R";
            // 
            // trackBarPalitreR
            // 
            this.trackBarPalitreR.AutoSize = false;
            this.trackBarPalitreR.Enabled = false;
            this.trackBarPalitreR.LargeChange = 50;
            this.trackBarPalitreR.Location = new System.Drawing.Point(560, 30);
            this.trackBarPalitreR.Maximum = 255;
            this.trackBarPalitreR.Name = "trackBarPalitreR";
            this.trackBarPalitreR.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarPalitreR.Size = new System.Drawing.Size(20, 470);
            this.trackBarPalitreR.SmallChange = 10;
            this.trackBarPalitreR.TabIndex = 44;
            this.trackBarPalitreR.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarPalitreR.Scroll += new System.EventHandler(this.trackBarPalitreR_Scroll);
            this.trackBarPalitreR.ValueChanged += new System.EventHandler(this.trackBarPalitreR_Scroll);
            // 
            // labelPalitreG
            // 
            this.labelPalitreG.AutoSize = true;
            this.labelPalitreG.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPalitreG.Location = new System.Drawing.Point(590, 10);
            this.labelPalitreG.Name = "labelPalitreG";
            this.labelPalitreG.Size = new System.Drawing.Size(23, 23);
            this.labelPalitreG.TabIndex = 43;
            this.labelPalitreG.Text = "G";
            // 
            // trackBarPalitreG
            // 
            this.trackBarPalitreG.AutoSize = false;
            this.trackBarPalitreG.Enabled = false;
            this.trackBarPalitreG.LargeChange = 50;
            this.trackBarPalitreG.Location = new System.Drawing.Point(590, 30);
            this.trackBarPalitreG.Maximum = 255;
            this.trackBarPalitreG.Name = "trackBarPalitreG";
            this.trackBarPalitreG.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarPalitreG.Size = new System.Drawing.Size(20, 470);
            this.trackBarPalitreG.SmallChange = 10;
            this.trackBarPalitreG.TabIndex = 42;
            this.trackBarPalitreG.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarPalitreG.Scroll += new System.EventHandler(this.trackBarPalitreG_Scroll);
            this.trackBarPalitreG.ValueChanged += new System.EventHandler(this.trackBarPalitreG_Scroll);
            // 
            // labelPalitreB
            // 
            this.labelPalitreB.AutoSize = true;
            this.labelPalitreB.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPalitreB.Location = new System.Drawing.Point(620, 10);
            this.labelPalitreB.Name = "labelPalitreB";
            this.labelPalitreB.Size = new System.Drawing.Size(22, 23);
            this.labelPalitreB.TabIndex = 41;
            this.labelPalitreB.Text = "B";
            // 
            // trackBarPalitreB
            // 
            this.trackBarPalitreB.AutoSize = false;
            this.trackBarPalitreB.Enabled = false;
            this.trackBarPalitreB.LargeChange = 50;
            this.trackBarPalitreB.Location = new System.Drawing.Point(620, 30);
            this.trackBarPalitreB.Maximum = 255;
            this.trackBarPalitreB.Name = "trackBarPalitreB";
            this.trackBarPalitreB.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarPalitreB.Size = new System.Drawing.Size(20, 470);
            this.trackBarPalitreB.SmallChange = 10;
            this.trackBarPalitreB.TabIndex = 40;
            this.trackBarPalitreB.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarPalitreB.Scroll += new System.EventHandler(this.trackBarPalitreB_Scroll);
            this.trackBarPalitreB.ValueChanged += new System.EventHandler(this.trackBarPalitreB_Scroll);
            // 
            // labelPalitre
            // 
            this.labelPalitre.Location = new System.Drawing.Point(5, 5);
            this.labelPalitre.Name = "labelPalitre";
            this.labelPalitre.Size = new System.Drawing.Size(120, 28);
            this.labelPalitre.TabIndex = 38;
            this.labelPalitre.Text = "Палитра";
            // 
            // buttonPalitreDefault
            // 
            this.buttonPalitreDefault.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPalitreDefault.Location = new System.Drawing.Point(380, 520);
            this.buttonPalitreDefault.Name = "buttonPalitreDefault";
            this.buttonPalitreDefault.Size = new System.Drawing.Size(150, 30);
            this.buttonPalitreDefault.TabIndex = 37;
            this.buttonPalitreDefault.Text = "Стандартные цвета";
            this.buttonPalitreDefault.UseVisualStyleBackColor = true;
            this.buttonPalitreDefault.Click += new System.EventHandler(this.buttonPalitreDefault_Click);
            // 
            // buttonPalitreSave
            // 
            this.buttonPalitreSave.Enabled = false;
            this.buttonPalitreSave.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPalitreSave.Location = new System.Drawing.Point(540, 520);
            this.buttonPalitreSave.Name = "buttonPalitreSave";
            this.buttonPalitreSave.Size = new System.Drawing.Size(120, 30);
            this.buttonPalitreSave.TabIndex = 36;
            this.buttonPalitreSave.Text = "Сохранить";
            this.buttonPalitreSave.UseVisualStyleBackColor = true;
            this.buttonPalitreSave.Click += new System.EventHandler(this.buttonPalitreSave_Click);
            // 
            // buttonPalitreCancel
            // 
            this.buttonPalitreCancel.Enabled = false;
            this.buttonPalitreCancel.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPalitreCancel.Location = new System.Drawing.Point(670, 520);
            this.buttonPalitreCancel.Name = "buttonPalitreCancel";
            this.buttonPalitreCancel.Size = new System.Drawing.Size(120, 30);
            this.buttonPalitreCancel.TabIndex = 35;
            this.buttonPalitreCancel.Text = "Отменить";
            this.buttonPalitreCancel.UseVisualStyleBackColor = true;
            this.buttonPalitreCancel.Click += new System.EventHandler(this.buttonPalitreCancel_Click);
            // 
            // buttonPalitreHelp
            // 
            this.buttonPalitreHelp.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPalitreHelp.Location = new System.Drawing.Point(660, 50);
            this.buttonPalitreHelp.Name = "buttonPalitreHelp";
            this.buttonPalitreHelp.Size = new System.Drawing.Size(130, 30);
            this.buttonPalitreHelp.TabIndex = 34;
            this.buttonPalitreHelp.Text = "Помощь";
            this.buttonPalitreHelp.UseVisualStyleBackColor = true;
            this.buttonPalitreHelp.Click += new System.EventHandler(this.buttonPalitreHelp_Click);
            // 
            // groupBoxPalitreColors
            // 
            this.groupBoxPalitreColors.Controls.Add(this.labelPalitreColorsR);
            this.groupBoxPalitreColors.Controls.Add(this.labelPalitreColorsG);
            this.groupBoxPalitreColors.Controls.Add(this.labelPalitreColorsB);
            this.groupBoxPalitreColors.Controls.Add(this.textBoxPalitreColorsRedB);
            this.groupBoxPalitreColors.Controls.Add(this.textBoxPalitreColorsBlueB);
            this.groupBoxPalitreColors.Controls.Add(this.textBoxPalitreColorsBGB);
            this.groupBoxPalitreColors.Controls.Add(this.textBoxPalitreColorsRedG);
            this.groupBoxPalitreColors.Controls.Add(this.textBoxPalitreColorsBlueG);
            this.groupBoxPalitreColors.Controls.Add(this.textBoxPalitreColorsBGG);
            this.groupBoxPalitreColors.Controls.Add(this.radioButtonPalitreColorsBackground);
            this.groupBoxPalitreColors.Controls.Add(this.radioButtonPalitreColorsBlue);
            this.groupBoxPalitreColors.Controls.Add(this.radioButtonPalitreColorsRed);
            this.groupBoxPalitreColors.Controls.Add(this.textBoxPalitreColorsRedR);
            this.groupBoxPalitreColors.Controls.Add(this.textBoxPalitreColorsBlueR);
            this.groupBoxPalitreColors.Controls.Add(this.textBoxPalitreColorsBGR);
            this.groupBoxPalitreColors.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxPalitreColors.Location = new System.Drawing.Point(20, 400);
            this.groupBoxPalitreColors.Name = "groupBoxPalitreColors";
            this.groupBoxPalitreColors.Size = new System.Drawing.Size(250, 140);
            this.groupBoxPalitreColors.TabIndex = 5;
            this.groupBoxPalitreColors.TabStop = false;
            this.groupBoxPalitreColors.Text = "Выберите цвет";
            // 
            // labelPalitreColorsR
            // 
            this.labelPalitreColorsR.AutoSize = true;
            this.labelPalitreColorsR.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPalitreColorsR.Location = new System.Drawing.Point(135, 15);
            this.labelPalitreColorsR.Name = "labelPalitreColorsR";
            this.labelPalitreColorsR.Size = new System.Drawing.Size(22, 23);
            this.labelPalitreColorsR.TabIndex = 48;
            this.labelPalitreColorsR.Text = "R";
            // 
            // labelPalitreColorsG
            // 
            this.labelPalitreColorsG.AutoSize = true;
            this.labelPalitreColorsG.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPalitreColorsG.Location = new System.Drawing.Point(170, 15);
            this.labelPalitreColorsG.Name = "labelPalitreColorsG";
            this.labelPalitreColorsG.Size = new System.Drawing.Size(23, 23);
            this.labelPalitreColorsG.TabIndex = 47;
            this.labelPalitreColorsG.Text = "G";
            // 
            // labelPalitreColorsB
            // 
            this.labelPalitreColorsB.AutoSize = true;
            this.labelPalitreColorsB.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPalitreColorsB.Location = new System.Drawing.Point(205, 15);
            this.labelPalitreColorsB.Name = "labelPalitreColorsB";
            this.labelPalitreColorsB.Size = new System.Drawing.Size(22, 23);
            this.labelPalitreColorsB.TabIndex = 46;
            this.labelPalitreColorsB.Text = "B";
            // 
            // textBoxPalitreColorsRedB
            // 
            this.textBoxPalitreColorsRedB.Enabled = false;
            this.textBoxPalitreColorsRedB.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPalitreColorsRedB.Location = new System.Drawing.Point(200, 45);
            this.textBoxPalitreColorsRedB.MaxLength = 3;
            this.textBoxPalitreColorsRedB.Name = "textBoxPalitreColorsRedB";
            this.textBoxPalitreColorsRedB.Size = new System.Drawing.Size(30, 24);
            this.textBoxPalitreColorsRedB.TabIndex = 16;
            this.textBoxPalitreColorsRedB.Text = "0";
            this.textBoxPalitreColorsRedB.TextChanged += new System.EventHandler(this.textBoxPalitreColors_TextChanged);
            this.textBoxPalitreColorsRedB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumeralsOnly);
            // 
            // textBoxPalitreColorsBlueB
            // 
            this.textBoxPalitreColorsBlueB.Enabled = false;
            this.textBoxPalitreColorsBlueB.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPalitreColorsBlueB.Location = new System.Drawing.Point(200, 75);
            this.textBoxPalitreColorsBlueB.MaxLength = 3;
            this.textBoxPalitreColorsBlueB.Name = "textBoxPalitreColorsBlueB";
            this.textBoxPalitreColorsBlueB.Size = new System.Drawing.Size(30, 24);
            this.textBoxPalitreColorsBlueB.TabIndex = 17;
            this.textBoxPalitreColorsBlueB.Text = "100";
            this.textBoxPalitreColorsBlueB.TextChanged += new System.EventHandler(this.textBoxPalitreColors_TextChanged);
            this.textBoxPalitreColorsBlueB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumeralsOnly);
            // 
            // textBoxPalitreColorsBGB
            // 
            this.textBoxPalitreColorsBGB.Enabled = false;
            this.textBoxPalitreColorsBGB.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPalitreColorsBGB.Location = new System.Drawing.Point(200, 105);
            this.textBoxPalitreColorsBGB.MaxLength = 3;
            this.textBoxPalitreColorsBGB.Name = "textBoxPalitreColorsBGB";
            this.textBoxPalitreColorsBGB.Size = new System.Drawing.Size(30, 24);
            this.textBoxPalitreColorsBGB.TabIndex = 18;
            this.textBoxPalitreColorsBGB.Text = "97";
            this.textBoxPalitreColorsBGB.TextChanged += new System.EventHandler(this.textBoxPalitreColors_TextChanged);
            this.textBoxPalitreColorsBGB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumeralsOnly);
            // 
            // textBoxPalitreColorsRedG
            // 
            this.textBoxPalitreColorsRedG.Enabled = false;
            this.textBoxPalitreColorsRedG.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPalitreColorsRedG.Location = new System.Drawing.Point(165, 45);
            this.textBoxPalitreColorsRedG.MaxLength = 3;
            this.textBoxPalitreColorsRedG.Name = "textBoxPalitreColorsRedG";
            this.textBoxPalitreColorsRedG.Size = new System.Drawing.Size(30, 24);
            this.textBoxPalitreColorsRedG.TabIndex = 13;
            this.textBoxPalitreColorsRedG.Text = "1";
            this.textBoxPalitreColorsRedG.TextChanged += new System.EventHandler(this.textBoxPalitreColors_TextChanged);
            this.textBoxPalitreColorsRedG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumeralsOnly);
            // 
            // textBoxPalitreColorsBlueG
            // 
            this.textBoxPalitreColorsBlueG.Enabled = false;
            this.textBoxPalitreColorsBlueG.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPalitreColorsBlueG.Location = new System.Drawing.Point(165, 75);
            this.textBoxPalitreColorsBlueG.MaxLength = 3;
            this.textBoxPalitreColorsBlueG.Name = "textBoxPalitreColorsBlueG";
            this.textBoxPalitreColorsBlueG.Size = new System.Drawing.Size(30, 24);
            this.textBoxPalitreColorsBlueG.TabIndex = 14;
            this.textBoxPalitreColorsBlueG.Text = "88";
            this.textBoxPalitreColorsBlueG.TextChanged += new System.EventHandler(this.textBoxPalitreColors_TextChanged);
            this.textBoxPalitreColorsBlueG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumeralsOnly);
            // 
            // textBoxPalitreColorsBGG
            // 
            this.textBoxPalitreColorsBGG.Enabled = false;
            this.textBoxPalitreColorsBGG.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPalitreColorsBGG.Location = new System.Drawing.Point(165, 105);
            this.textBoxPalitreColorsBGG.MaxLength = 3;
            this.textBoxPalitreColorsBGG.Name = "textBoxPalitreColorsBGG";
            this.textBoxPalitreColorsBGG.Size = new System.Drawing.Size(30, 24);
            this.textBoxPalitreColorsBGG.TabIndex = 15;
            this.textBoxPalitreColorsBGG.Text = "97";
            this.textBoxPalitreColorsBGG.TextChanged += new System.EventHandler(this.textBoxPalitreColors_TextChanged);
            this.textBoxPalitreColorsBGG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumeralsOnly);
            // 
            // radioButtonPalitreColorsBackground
            // 
            this.radioButtonPalitreColorsBackground.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonPalitreColorsBackground.Location = new System.Drawing.Point(20, 100);
            this.radioButtonPalitreColorsBackground.Name = "radioButtonPalitreColorsBackground";
            this.radioButtonPalitreColorsBackground.Size = new System.Drawing.Size(100, 20);
            this.radioButtonPalitreColorsBackground.TabIndex = 2;
            this.radioButtonPalitreColorsBackground.TabStop = true;
            this.radioButtonPalitreColorsBackground.Text = "Фон";
            this.radioButtonPalitreColorsBackground.UseVisualStyleBackColor = true;
            this.radioButtonPalitreColorsBackground.CheckedChanged += new System.EventHandler(this.radioButtonPalitreColorsBackground_CheckedChanged);
            // 
            // radioButtonPalitreColorsBlue
            // 
            this.radioButtonPalitreColorsBlue.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonPalitreColorsBlue.Location = new System.Drawing.Point(20, 70);
            this.radioButtonPalitreColorsBlue.Name = "radioButtonPalitreColorsBlue";
            this.radioButtonPalitreColorsBlue.Size = new System.Drawing.Size(100, 20);
            this.radioButtonPalitreColorsBlue.TabIndex = 1;
            this.radioButtonPalitreColorsBlue.TabStop = true;
            this.radioButtonPalitreColorsBlue.Text = "Синий";
            this.radioButtonPalitreColorsBlue.UseVisualStyleBackColor = true;
            this.radioButtonPalitreColorsBlue.CheckedChanged += new System.EventHandler(this.radioButtonPalitreColorsBlue_CheckedChanged);
            // 
            // radioButtonPalitreColorsRed
            // 
            this.radioButtonPalitreColorsRed.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonPalitreColorsRed.Location = new System.Drawing.Point(20, 40);
            this.radioButtonPalitreColorsRed.Name = "radioButtonPalitreColorsRed";
            this.radioButtonPalitreColorsRed.Size = new System.Drawing.Size(100, 20);
            this.radioButtonPalitreColorsRed.TabIndex = 0;
            this.radioButtonPalitreColorsRed.Text = "Красный";
            this.radioButtonPalitreColorsRed.UseVisualStyleBackColor = true;
            this.radioButtonPalitreColorsRed.CheckedChanged += new System.EventHandler(this.radioButtonPalitreColorsRed_CheckedChanged);
            // 
            // textBoxPalitreColorsRedR
            // 
            this.textBoxPalitreColorsRedR.Enabled = false;
            this.textBoxPalitreColorsRedR.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPalitreColorsRedR.Location = new System.Drawing.Point(130, 45);
            this.textBoxPalitreColorsRedR.MaxLength = 3;
            this.textBoxPalitreColorsRedR.Name = "textBoxPalitreColorsRedR";
            this.textBoxPalitreColorsRedR.Size = new System.Drawing.Size(30, 24);
            this.textBoxPalitreColorsRedR.TabIndex = 6;
            this.textBoxPalitreColorsRedR.Text = "102";
            this.textBoxPalitreColorsRedR.TextChanged += new System.EventHandler(this.textBoxPalitreColors_TextChanged);
            this.textBoxPalitreColorsRedR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumeralsOnly);
            // 
            // textBoxPalitreColorsBlueR
            // 
            this.textBoxPalitreColorsBlueR.Enabled = false;
            this.textBoxPalitreColorsBlueR.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPalitreColorsBlueR.Location = new System.Drawing.Point(130, 75);
            this.textBoxPalitreColorsBlueR.MaxLength = 3;
            this.textBoxPalitreColorsBlueR.Name = "textBoxPalitreColorsBlueR";
            this.textBoxPalitreColorsBlueR.Size = new System.Drawing.Size(30, 24);
            this.textBoxPalitreColorsBlueR.TabIndex = 9;
            this.textBoxPalitreColorsBlueR.Text = "0";
            this.textBoxPalitreColorsBlueR.TextChanged += new System.EventHandler(this.textBoxPalitreColors_TextChanged);
            this.textBoxPalitreColorsBlueR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumeralsOnly);
            // 
            // textBoxPalitreColorsBGR
            // 
            this.textBoxPalitreColorsBGR.Enabled = false;
            this.textBoxPalitreColorsBGR.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPalitreColorsBGR.Location = new System.Drawing.Point(130, 105);
            this.textBoxPalitreColorsBGR.MaxLength = 3;
            this.textBoxPalitreColorsBGR.Name = "textBoxPalitreColorsBGR";
            this.textBoxPalitreColorsBGR.Size = new System.Drawing.Size(30, 24);
            this.textBoxPalitreColorsBGR.TabIndex = 12;
            this.textBoxPalitreColorsBGR.Text = "97";
            this.textBoxPalitreColorsBGR.TextChanged += new System.EventHandler(this.textBoxPalitreColors_TextChanged);
            this.textBoxPalitreColorsBGR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumeralsOnly);
            // 
            // panelFinish
            // 
            this.panelFinish.BackColor = System.Drawing.SystemColors.Control;
            this.panelFinish.Controls.Add(this.pictureBoxFinishLoading);
            this.panelFinish.Controls.Add(this.labelFinishTable);
            this.panelFinish.Controls.Add(this.labelFinishPacient);
            this.panelFinish.Controls.Add(this.listViewFinishCurrentResult);
            this.panelFinish.Controls.Add(this.listViewFinishResults);
            this.panelFinish.Controls.Add(this.textBoxFinishBalls);
            this.panelFinish.Controls.Add(this.labelFinishBalls);
            this.panelFinish.Controls.Add(this.textBoxFinishPacient);
            this.panelFinish.Controls.Add(this.labelFinish);
            this.panelFinish.Controls.Add(this.buttonFinishHelp);
            this.panelFinish.Location = new System.Drawing.Point(210, 5);
            this.panelFinish.Name = "panelFinish";
            this.panelFinish.Size = new System.Drawing.Size(800, 560);
            this.panelFinish.TabIndex = 7;
            this.panelFinish.Visible = false;
            // 
            // labelFinishTable
            // 
            this.labelFinishTable.AutoSize = true;
            this.labelFinishTable.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFinishTable.Location = new System.Drawing.Point(20, 260);
            this.labelFinishTable.Name = "labelFinishTable";
            this.labelFinishTable.Size = new System.Drawing.Size(192, 22);
            this.labelFinishTable.TabIndex = 45;
            this.labelFinishTable.Text = "Таблица результатов";
            // 
            // labelFinishPacient
            // 
            this.labelFinishPacient.AutoSize = true;
            this.labelFinishPacient.Location = new System.Drawing.Point(120, 100);
            this.labelFinishPacient.Name = "labelFinishPacient";
            this.labelFinishPacient.Size = new System.Drawing.Size(115, 30);
            this.labelFinishPacient.TabIndex = 44;
            this.labelFinishPacient.Text = "Пациент";
            // 
            // listViewFinishCurrentResult
            // 
            this.listViewFinishCurrentResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader23,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22});
            this.listViewFinishCurrentResult.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewFinishCurrentResult.FullRowSelect = true;
            this.listViewFinishCurrentResult.GridLines = true;
            this.listViewFinishCurrentResult.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewFinishCurrentResult.HideSelection = false;
            this.listViewFinishCurrentResult.Location = new System.Drawing.Point(20, 290);
            this.listViewFinishCurrentResult.Name = "listViewFinishCurrentResult";
            this.listViewFinishCurrentResult.Size = new System.Drawing.Size(760, 50);
            this.listViewFinishCurrentResult.TabIndex = 43;
            this.listViewFinishCurrentResult.UseCompatibleStateImageBehavior = false;
            this.listViewFinishCurrentResult.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "№";
            this.columnHeader23.Width = 30;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Дата и название";
            this.columnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader14.Width = 150;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Время";
            this.columnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader15.Width = 70;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "горизонт.откл.";
            this.columnHeader16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader16.Width = 88;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "гор.дин.";
            this.columnHeader17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "вертикал.откл";
            this.columnHeader18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader18.Width = 90;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "верт.дин.";
            this.columnHeader19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader19.Width = 65;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Попадание";
            this.columnHeader20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader20.Width = 80;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Промах";
            this.columnHeader21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Баллы";
            this.columnHeader22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listViewFinishResults
            // 
            this.listViewFinishResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.listViewFinishResults.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewFinishResults.FullRowSelect = true;
            this.listViewFinishResults.GridLines = true;
            this.listViewFinishResults.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewFinishResults.HideSelection = false;
            this.listViewFinishResults.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem7,
            listViewItem8});
            this.listViewFinishResults.Location = new System.Drawing.Point(20, 340);
            this.listViewFinishResults.Name = "listViewFinishResults";
            this.listViewFinishResults.Size = new System.Drawing.Size(760, 45);
            this.listViewFinishResults.TabIndex = 42;
            this.listViewFinishResults.UseCompatibleStateImageBehavior = false;
            this.listViewFinishResults.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Дата";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 180;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Время";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 70;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "горизонт.откл.";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 88;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "гор.дин.";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "вертикал.откл";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 90;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "верт.дин.";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 65;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Попадание";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 80;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Промах";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Баллы";
            this.columnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxFinishBalls
            // 
            this.textBoxFinishBalls.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFinishBalls.Location = new System.Drawing.Point(300, 150);
            this.textBoxFinishBalls.Name = "textBoxFinishBalls";
            this.textBoxFinishBalls.ReadOnly = true;
            this.textBoxFinishBalls.Size = new System.Drawing.Size(100, 30);
            this.textBoxFinishBalls.TabIndex = 4;
            // 
            // labelFinishBalls
            // 
            this.labelFinishBalls.AutoSize = true;
            this.labelFinishBalls.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFinishBalls.Location = new System.Drawing.Point(200, 150);
            this.labelFinishBalls.Name = "labelFinishBalls";
            this.labelFinishBalls.Size = new System.Drawing.Size(91, 27);
            this.labelFinishBalls.TabIndex = 3;
            this.labelFinishBalls.Text = "баллов";
            // 
            // textBoxFinishPacient
            // 
            this.textBoxFinishPacient.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFinishPacient.Location = new System.Drawing.Point(240, 100);
            this.textBoxFinishPacient.Name = "textBoxFinishPacient";
            this.textBoxFinishPacient.ReadOnly = true;
            this.textBoxFinishPacient.Size = new System.Drawing.Size(300, 34);
            this.textBoxFinishPacient.TabIndex = 2;
            // 
            // labelFinish
            // 
            this.labelFinish.AutoSize = true;
            this.labelFinish.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFinish.Location = new System.Drawing.Point(250, 20);
            this.labelFinish.Name = "labelFinish";
            this.labelFinish.Size = new System.Drawing.Size(242, 33);
            this.labelFinish.TabIndex = 1;
            this.labelFinish.Text = "Сеанс завершен";
            // 
            // buttonFinishHelp
            // 
            this.buttonFinishHelp.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFinishHelp.Location = new System.Drawing.Point(660, 50);
            this.buttonFinishHelp.Name = "buttonFinishHelp";
            this.buttonFinishHelp.Size = new System.Drawing.Size(130, 30);
            this.buttonFinishHelp.TabIndex = 0;
            this.buttonFinishHelp.Text = "Помощь";
            this.buttonFinishHelp.UseVisualStyleBackColor = true;
            this.buttonFinishHelp.Click += new System.EventHandler(this.buttonFinishHelp_Click);
            // 
            // panelScreen
            // 
            this.panelScreen.BackColor = System.Drawing.SystemColors.Control;
            this.panelScreen.Controls.Add(this.textBoxScreenWidth);
            this.panelScreen.Controls.Add(this.textBoxScreenHeight);
            this.panelScreen.Controls.Add(this.labelScreenWidth);
            this.panelScreen.Controls.Add(this.labelScreenHeight);
            this.panelScreen.Controls.Add(this.labelScreenType);
            this.panelScreen.Controls.Add(this.buttonScreenSave);
            this.panelScreen.Controls.Add(this.buttonScreenCancel);
            this.panelScreen.Controls.Add(this.buttonScreenHelp);
            this.panelScreen.Controls.Add(this.labelScreen);
            this.panelScreen.Location = new System.Drawing.Point(210, 5);
            this.panelScreen.Name = "panelScreen";
            this.panelScreen.Size = new System.Drawing.Size(800, 560);
            this.panelScreen.TabIndex = 8;
            this.panelScreen.Visible = false;
            // 
            // textBoxScreenWidth
            // 
            this.textBoxScreenWidth.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxScreenWidth.Location = new System.Drawing.Point(250, 170);
            this.textBoxScreenWidth.Name = "textBoxScreenWidth";
            this.textBoxScreenWidth.Size = new System.Drawing.Size(80, 26);
            this.textBoxScreenWidth.TabIndex = 8;
            this.textBoxScreenWidth.Text = "0";
            this.textBoxScreenWidth.TextChanged += new System.EventHandler(this.textBoxScreenHeightWidth_TextChanged);
            this.textBoxScreenWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumeralsOnly);
            // 
            // textBoxScreenHeight
            // 
            this.textBoxScreenHeight.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxScreenHeight.Location = new System.Drawing.Point(250, 140);
            this.textBoxScreenHeight.Name = "textBoxScreenHeight";
            this.textBoxScreenHeight.Size = new System.Drawing.Size(80, 26);
            this.textBoxScreenHeight.TabIndex = 7;
            this.textBoxScreenHeight.Text = "0";
            this.textBoxScreenHeight.TextChanged += new System.EventHandler(this.textBoxScreenHeightWidth_TextChanged);
            this.textBoxScreenHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumeralsOnly);
            // 
            // labelScreenWidth
            // 
            this.labelScreenWidth.AutoSize = true;
            this.labelScreenWidth.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScreenWidth.Location = new System.Drawing.Point(100, 170);
            this.labelScreenWidth.Name = "labelScreenWidth";
            this.labelScreenWidth.Size = new System.Drawing.Size(118, 22);
            this.labelScreenWidth.TabIndex = 6;
            this.labelScreenWidth.Text = "ширина (см)";
            // 
            // labelScreenHeight
            // 
            this.labelScreenHeight.AutoSize = true;
            this.labelScreenHeight.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScreenHeight.Location = new System.Drawing.Point(100, 140);
            this.labelScreenHeight.Name = "labelScreenHeight";
            this.labelScreenHeight.Size = new System.Drawing.Size(111, 22);
            this.labelScreenHeight.TabIndex = 5;
            this.labelScreenHeight.Text = "высота (см)";
            // 
            // labelScreenType
            // 
            this.labelScreenType.AutoSize = true;
            this.labelScreenType.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScreenType.Location = new System.Drawing.Point(60, 100);
            this.labelScreenType.Name = "labelScreenType";
            this.labelScreenType.Size = new System.Drawing.Size(101, 27);
            this.labelScreenType.TabIndex = 4;
            this.labelScreenType.Text = "Введите";
            // 
            // buttonScreenSave
            // 
            this.buttonScreenSave.Enabled = false;
            this.buttonScreenSave.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonScreenSave.Location = new System.Drawing.Point(540, 520);
            this.buttonScreenSave.Name = "buttonScreenSave";
            this.buttonScreenSave.Size = new System.Drawing.Size(120, 30);
            this.buttonScreenSave.TabIndex = 3;
            this.buttonScreenSave.Text = "Сохранить";
            this.buttonScreenSave.UseVisualStyleBackColor = true;
            this.buttonScreenSave.Click += new System.EventHandler(this.buttonScreenSave_Click);
            // 
            // buttonScreenCancel
            // 
            this.buttonScreenCancel.Enabled = false;
            this.buttonScreenCancel.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonScreenCancel.Location = new System.Drawing.Point(670, 520);
            this.buttonScreenCancel.Name = "buttonScreenCancel";
            this.buttonScreenCancel.Size = new System.Drawing.Size(120, 30);
            this.buttonScreenCancel.TabIndex = 2;
            this.buttonScreenCancel.Text = "Отменить";
            this.buttonScreenCancel.UseVisualStyleBackColor = true;
            this.buttonScreenCancel.Click += new System.EventHandler(this.buttonScreenCancel_Click);
            // 
            // buttonScreenHelp
            // 
            this.buttonScreenHelp.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonScreenHelp.Location = new System.Drawing.Point(660, 50);
            this.buttonScreenHelp.Name = "buttonScreenHelp";
            this.buttonScreenHelp.Size = new System.Drawing.Size(130, 30);
            this.buttonScreenHelp.TabIndex = 1;
            this.buttonScreenHelp.Text = "Помощь";
            this.buttonScreenHelp.UseVisualStyleBackColor = true;
            this.buttonScreenHelp.Click += new System.EventHandler(this.buttonScreenHelp_Click);
            // 
            // labelScreen
            // 
            this.labelScreen.AutoSize = true;
            this.labelScreen.Location = new System.Drawing.Point(5, 5);
            this.labelScreen.Name = "labelScreen";
            this.labelScreen.Size = new System.Drawing.Size(86, 30);
            this.labelScreen.TabIndex = 0;
            this.labelScreen.Text = "Экран";
            // 
            // buttonResultUpdateResults
            // 
            this.buttonResultUpdateResults.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.buttonResultUpdateResults.Location = new System.Drawing.Point(185, 520);
            this.buttonResultUpdateResults.Name = "buttonResultUpdateResults";
            this.buttonResultUpdateResults.Size = new System.Drawing.Size(220, 30);
            this.buttonResultUpdateResults.TabIndex = 42;
            this.buttonResultUpdateResults.Text = "Обновить результаты";
            this.buttonResultUpdateResults.UseVisualStyleBackColor = true;
            this.buttonResultUpdateResults.Click += new System.EventHandler(this.buttonResultUpdateResults_Click);
            // 
            // pictureBoxFinishLoading
            // 
            this.pictureBoxFinishLoading.Location = new System.Drawing.Point(300, 180);
            this.pictureBoxFinishLoading.Name = "pictureBoxFinishLoading";
            this.pictureBoxFinishLoading.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxFinishLoading.TabIndex = 46;
            this.pictureBoxFinishLoading.TabStop = false;
            this.pictureBoxFinishLoading.Visible = false;
            // 
            // pictureBoxPalitres
            // 
            this.pictureBoxPalitres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPalitres.Location = new System.Drawing.Point(660, 100);
            this.pictureBoxPalitres.Name = "pictureBoxPalitres";
            this.pictureBoxPalitres.Size = new System.Drawing.Size(100, 400);
            this.pictureBoxPalitres.TabIndex = 46;
            this.pictureBoxPalitres.TabStop = false;
            this.pictureBoxPalitres.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPalitres_MouseClick);
            // 
            // pictureBoxPalitre
            // 
            this.pictureBoxPalitre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxPalitre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPalitre.Location = new System.Drawing.Point(5, 35);
            this.pictureBoxPalitre.Name = "pictureBoxPalitre";
            this.pictureBoxPalitre.Size = new System.Drawing.Size(540, 360);
            this.pictureBoxPalitre.TabIndex = 0;
            this.pictureBoxPalitre.TabStop = false;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1015, 572);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelFinish);
            this.Controls.Add(this.panelResults);
            this.Controls.Add(this.panelLevels);
            this.Controls.Add(this.panelSessions);
            this.Controls.Add(this.panelPacients);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelPalitre);
            this.Controls.Add(this.panelScreen);
            this.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1035, 615);
            this.Name = "formMain";
            this.Text = "БЗК-1 (Gamma v4.1)";
            this.panelMenu.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.groupBoxMainSessionControls.ResumeLayout(false);
            this.panelPacients.ResumeLayout(false);
            this.panelPacients.PerformLayout();
            this.panelPacientsPanelFilter.ResumeLayout(false);
            this.panelPacientsPanelFilter.PerformLayout();
            this.panelSessions.ResumeLayout(false);
            this.panelSessions.PerformLayout();
            this.contextMenuStripPatterns.ResumeLayout(false);
            this.contextMenuStriptasks.ResumeLayout(false);
            this.panelLevels.ResumeLayout(false);
            this.panelLevels.PerformLayout();
            this.panelResults.ResumeLayout(false);
            this.panelResults.PerformLayout();
            this.panelPalitre.ResumeLayout(false);
            this.panelPalitre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPalitreR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPalitreG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPalitreB)).EndInit();
            this.groupBoxPalitreColors.ResumeLayout(false);
            this.groupBoxPalitreColors.PerformLayout();
            this.panelFinish.ResumeLayout(false);
            this.panelFinish.PerformLayout();
            this.panelScreen.ResumeLayout(false);
            this.panelScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFinishLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPalitres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPalitre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonScreen;
        private System.Windows.Forms.Button buttonPalitre;
        private System.Windows.Forms.Button buttonResults;
        private System.Windows.Forms.Button buttonLevels;
        private System.Windows.Forms.Button buttonSessions;
        private System.Windows.Forms.Button buttonPacients;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.GroupBox groupBoxMainSessionControls;
        private System.Windows.Forms.Label labelMainSessionControls;
        private System.Windows.Forms.Button buttonMainAbout;
        private System.Windows.Forms.Button buttonMainHelp;
        private System.Windows.Forms.Button buttonMainInfo;
        private System.Windows.Forms.TextBox textBoxMainFromMonitor;
        private System.Windows.Forms.Label labelMainFromMonitor;
        private System.Windows.Forms.Label labelMainRedFilter;
        private System.Windows.Forms.TextBox textBoxMainPacient;
        private System.Windows.Forms.TextBox textBoxMainPacientComment;
        private System.Windows.Forms.Label labelMainPacient;
        private System.Windows.Forms.TextBox textBoxMainRedFilter;
        private System.Windows.Forms.TextBox textBoxMainLatestResult;
        private System.Windows.Forms.Label labelMainLatestResult;
        private System.Windows.Forms.TextBox textBoxMainSessionDuration;
        private System.Windows.Forms.Label labelMainSessionDuration;
        private System.Windows.Forms.TextBox textBoxMainLevel;
        private System.Windows.Forms.TextBox textBoxMainLevelComment;
        private System.Windows.Forms.Label labelMainLevel;
        private System.Windows.Forms.TextBox textBoxMainSession;
        private System.Windows.Forms.TextBox textBoxMainSessionComment;
        private System.Windows.Forms.Label labelMainSession;
        private System.Windows.Forms.Button buttonMain;
        private System.Windows.Forms.Panel panelPacients;
        private System.Windows.Forms.Label labelPacientsFromMonitorSM;
        private System.Windows.Forms.TextBox textBoxPacientsFromMonitor;
        private System.Windows.Forms.Label labelPacientsFromMonitor;
        private System.Windows.Forms.Label labelPacientsFilter;
        private System.Windows.Forms.Panel panelPacientsPanelFilter;
        private System.Windows.Forms.RadioButton radioButtonPacientsFilterLeft;
        private System.Windows.Forms.RadioButton radioButtonPacientsFilterRight;
        private System.Windows.Forms.TextBox textBoxPacientComment;
        private System.Windows.Forms.Label labelPacientsComment;
        private System.Windows.Forms.ComboBox comboBoxPacients;
        private System.Windows.Forms.Label labelPacientsPacient;
        private System.Windows.Forms.Button buttonPacientsCreate;
        private System.Windows.Forms.Button buttonPacientsHelp;
        private System.Windows.Forms.Label labelMainHead;
        private System.Windows.Forms.Label labelPacientsHead;
        private System.Windows.Forms.Button buttonPacientsArch;
        private System.Windows.Forms.Button buttonPacientsDel;
        private System.Windows.Forms.Button buttonPacientsCancel;
        private System.Windows.Forms.Button buttonPacientsSave;
        private System.Windows.Forms.Panel panelSessions;
        private System.Windows.Forms.Button buttonSessionsSave;
        private System.Windows.Forms.Button buttonSessionsCancel;
        private System.Windows.Forms.Label labelSessionsPaterns;
        private System.Windows.Forms.Label labelSessionsTasks;
        private System.Windows.Forms.Button buttonSessionsDel;
        private System.Windows.Forms.Button buttonSessionsPaternsForm;
        private System.Windows.Forms.Button buttonSessionsForm;
        private System.Windows.Forms.ListView listViewSessionsTasks;
        private System.Windows.Forms.CheckBox checkBoxSessionsPaternsAuto;
        private System.Windows.Forms.TextBox textBoxSessionDuration;
        private System.Windows.Forms.Label labelSessionDuration;
        private System.Windows.Forms.TextBox textBoxSessionComment;
        private System.Windows.Forms.ComboBox comboBoxSession;
        private System.Windows.Forms.Label labelSession;
        private System.Windows.Forms.Label labelSessions;
        private System.Windows.Forms.Button buttonSessionsHelp;
        private System.Windows.Forms.Button buttonSessionsCreate;
        private System.Windows.Forms.ColumnHeader columnHeaderTasksN;
        private System.Windows.Forms.ColumnHeader columnHeaderTasksName;
        private System.Windows.Forms.ColumnHeader columnHeaderTasksSeconds;
        private System.Windows.Forms.ListView listViewSessionsPaterns;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStriptasks;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemUp;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDown;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDel;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuChanged;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Panel panelLevels;
        private System.Windows.Forms.TextBox textBoxLevelsPacient;
        private System.Windows.Forms.TextBox textBoxLevelsBonusAccur;
        private System.Windows.Forms.Label labelLevelsBonusAccur;
        private System.Windows.Forms.Label labelLevelsBonus;
        private System.Windows.Forms.TextBox textBoxLevelsBallsCatch;
        private System.Windows.Forms.Label labelLevelsBallsCatch;
        private System.Windows.Forms.Label labelLevelsBalls;
        private System.Windows.Forms.TextBox textBoxLevelsToleranceHorizontal;
        private System.Windows.Forms.Label labelLevelsToleranceHorizontal;
        private System.Windows.Forms.Label labelLevelsTolerance;
        private System.Windows.Forms.Label labelLevelsTraining;
        private System.Windows.Forms.Button buttonLavelsUseForThisPacient;
        private System.Windows.Forms.Button buttonLevelsSave;
        private System.Windows.Forms.Button buttonLevelsCancel;
        private System.Windows.Forms.Button buttonLevelsDelete;
        private System.Windows.Forms.Button buttonLevelsHelp;
        private System.Windows.Forms.TextBox textBoxLevelsComment;
        private System.Windows.Forms.Label labelLevelsComment;
        private System.Windows.Forms.ComboBox comboBoxLevels;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.Label labelLevels;
        private System.Windows.Forms.TextBox textBoxLevelsObjectCatch;
        private System.Windows.Forms.Label labelLevelsObjectCatch;
        private System.Windows.Forms.Label labelLevelsObject;
        private System.Windows.Forms.TextBox textBoxLevelsToleranceVertical;
        private System.Windows.Forms.Label labelLevelsToleranceVertical;
        private System.Windows.Forms.TextBox textBoxLevelsObjectSmallerK;
        private System.Windows.Forms.Label labellevelsObjectSmallerK;
        private System.Windows.Forms.Label labelLevelsObjectSmaller;
        private System.Windows.Forms.TextBox textBoxLevelsBonusDinamic;
        private System.Windows.Forms.Label labelLevelsBonusDinamic;
        private System.Windows.Forms.TextBox textBoxLevelsBonusSmall;
        private System.Windows.Forms.Label labelLevelsBonusSmall;
        private System.Windows.Forms.Panel panelResults;
        private System.Windows.Forms.Button buttonResultsFile;
        private System.Windows.Forms.Button buttonResultsDel;
        private System.Windows.Forms.Button buttonResultsHelp;
        private System.Windows.Forms.ListView listViewResults;
        private System.Windows.Forms.TextBox textBoxResultsPatient;
        private System.Windows.Forms.Label labelResultsPatient;
        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.TextBox textBoxResultsPacientsLatest;
        private System.Windows.Forms.TextBox textBoxResultsPacientFirst;
        private System.Windows.Forms.Label labelResultsPacientDates;
        private System.Windows.Forms.TextBox textBoxResultsPacientDoneTime;
        private System.Windows.Forms.TextBox textBoxResultsPacientDoneSessions;
        private System.Windows.Forms.Label labelResultsPacientDone;
        private System.Windows.Forms.ColumnHeader columnHeaderN;
        private System.Windows.Forms.ColumnHeader columnHeaderDateName;
        private System.Windows.Forms.ColumnHeader columnHeaderTime;
        private System.Windows.Forms.ColumnHeader columnHeaderHorDev;
        private System.Windows.Forms.ColumnHeader columnHeaderHorDevDin;
        private System.Windows.Forms.ColumnHeader columnHeaderVertDev;
        private System.Windows.Forms.ColumnHeader columnHeaderVertDevDin;
        private System.Windows.Forms.ColumnHeader columnHeaderHit;
        private System.Windows.Forms.ColumnHeader columnHeaderMiss;
        private System.Windows.Forms.ColumnHeader columnHeaderBalls;
        private System.Windows.Forms.Panel panelPalitre;
        private System.Windows.Forms.Label labelPalitreR;
        private System.Windows.Forms.TrackBar trackBarPalitreR;
        private System.Windows.Forms.Label labelPalitreG;
        private System.Windows.Forms.TrackBar trackBarPalitreG;
        private System.Windows.Forms.Label labelPalitreB;
        private System.Windows.Forms.TrackBar trackBarPalitreB;
        private System.Windows.Forms.Label labelPalitre;
        private System.Windows.Forms.Button buttonPalitreDefault;
        private System.Windows.Forms.Button buttonPalitreSave;
        private System.Windows.Forms.Button buttonPalitreCancel;
        private System.Windows.Forms.Button buttonPalitreHelp;
        private System.Windows.Forms.GroupBox groupBoxPalitreColors;
        private System.Windows.Forms.RadioButton radioButtonPalitreColorsBackground;
        private System.Windows.Forms.RadioButton radioButtonPalitreColorsBlue;
        private System.Windows.Forms.RadioButton radioButtonPalitreColorsRed;
        private System.Windows.Forms.TextBox textBoxPalitreColorsRedR;
        private System.Windows.Forms.TextBox textBoxPalitreColorsBlueR;
        private System.Windows.Forms.TextBox textBoxPalitreColorsBGR;
        private System.Windows.Forms.PictureBox pictureBoxPalitre;
        private System.Windows.Forms.Label labelPalitreColorsR;
        private System.Windows.Forms.Label labelPalitreColorsG;
        private System.Windows.Forms.Label labelPalitreColorsB;
        private System.Windows.Forms.TextBox textBoxPalitreColorsRedB;
        private System.Windows.Forms.TextBox textBoxPalitreColorsBlueB;
        private System.Windows.Forms.TextBox textBoxPalitreColorsBGB;
        private System.Windows.Forms.TextBox textBoxPalitreColorsRedG;
        private System.Windows.Forms.TextBox textBoxPalitreColorsBlueG;
        private System.Windows.Forms.TextBox textBoxPalitreColorsBGG;
        private System.Windows.Forms.PictureBox pictureBoxPalitres;
        private System.Windows.Forms.ListView listViewResultsSum;
        private System.Windows.Forms.ColumnHeader columnHeaderResultsSumName;
        private System.Windows.Forms.ColumnHeader columnHeaderResultsSumTime;
        private System.Windows.Forms.ColumnHeader columnHeaderResultsSumHor;
        private System.Windows.Forms.ColumnHeader columnHeaderResultsSumHorDin;
        private System.Windows.Forms.ColumnHeader columnHeaderResultsSumVert;
        private System.Windows.Forms.ColumnHeader columnHeaderResultsSumVertDin;
        private System.Windows.Forms.ColumnHeader columnHeaderResultsSumCatch;
        private System.Windows.Forms.ColumnHeader columnHeaderResultsSumMiss;
        private System.Windows.Forms.ColumnHeader columnHeaderResultsSumBalls;
        private System.Windows.Forms.Panel panelFinish;
        private System.Windows.Forms.ListView listViewFinishCurrentResult;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ListView listViewFinishResults;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.TextBox textBoxFinishBalls;
        private System.Windows.Forms.Label labelFinishBalls;
        private System.Windows.Forms.TextBox textBoxFinishPacient;
        private System.Windows.Forms.Label labelFinish;
        private System.Windows.Forms.Button buttonFinishHelp;
        private System.Windows.Forms.Label labelFinishPacient;
        private System.Windows.Forms.Label labelFinishTable;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.Panel panelScreen;
        private System.Windows.Forms.TextBox textBoxScreenWidth;
        private System.Windows.Forms.TextBox textBoxScreenHeight;
        private System.Windows.Forms.Label labelScreenWidth;
        private System.Windows.Forms.Label labelScreenHeight;
        private System.Windows.Forms.Label labelScreenType;
        private System.Windows.Forms.Button buttonScreenSave;
        private System.Windows.Forms.Button buttonScreenCancel;
        private System.Windows.Forms.Button buttonScreenHelp;
        private System.Windows.Forms.Label labelScreen;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripPatterns;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonResultsComment;
        private System.Windows.Forms.Button buttonPacientsChangeName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonResultUpdateResults;
        private System.Windows.Forms.PictureBox pictureBoxFinishLoading;
    }
}

