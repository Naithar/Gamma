using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Drawing;


namespace ClassesLib
{
    //класс информации по экрану
        [Serializable()]
        public class Screen
        {
            //члены класса
            public double width;           //ширина экрана в сантиметрах
            public double height;          //высота экрана в сантиметрах
            public double pixelHeight;     //высота пикселя в мм
            public double pixelWidth;      //ширина пикселя в мм
            //
            //методы
            //конструктор нулевых значений
            public Screen()
            {
                this.width = 0;
                this.height = 0;
                this.pixelWidth = 0;
                this.pixelHeight = 0;
            }
            //установить/получить ширину экрана
            [XmlIgnore]
            public double Width
            {
                get
                {
                    return width;
                }
                set
                {
                    width = value;
                }
            }
            //установить/получить высоту экрана
            [XmlIgnore]
            public double Height
            {
                get
                {
                    return height;
                }
                set
                {
                    height = value;
                }
            }
            //установить/получить высоту пикселя
            [XmlIgnore]
            public double PixelHeight
            {
                get
                {
                    return pixelHeight;
                }
                set
                {
                    pixelHeight = value;
                }
            }
            //установить/получить ширину пикселя
            [XmlIgnore]
            public double PixelWidth
            {
                get
                {
                    return pixelWidth;
                }
                set
                {
                    pixelWidth = value;
                }
            }
            //сохранение в файл
            public static void Write(string fileName, Screen screen)
            {
                XmlSerializer writer = new XmlSerializer(typeof(Screen));
                Stream file = File.Open(fileName, FileMode.Create);
                writer.Serialize(file, screen);
                file.Close();
            }
            //чтение из файла
            public static Screen Read(string fileName)
            {
                Screen data = new Screen();
                XmlSerializer writer = new XmlSerializer(typeof(Screen));
                Stream file = File.OpenRead(fileName);
                data = (Screen)writer.Deserialize(file);
                file.Close();
                return data;
            }
        }
        //класс всех пациентов
        [Serializable]
        public class Patients
        {
            //члены
            public List<Patient> patients;      //список всех пациентов
            public int currentPatient;          //текущий пациент
            //методы
            //конструктор
            public Patients()
            {
                patients = new List<Patient>();
                currentPatient = -1;
            }
            //запись в файл
            public static void Write(string fileName, Patients data)
            {
                XmlSerializer writer = new XmlSerializer(typeof(Patients));
                Stream file = File.Open(fileName, FileMode.Create);
                writer.Serialize(file, data);
                file.Close();
            }
            //чтение из файла
            public static Patients Read(string fileName)
            {
                Patients data = new Patients();
                XmlSerializer writer = new XmlSerializer(typeof(Patients));
                Stream file = File.OpenRead(fileName);
                data = (Patients)writer.Deserialize(file);
                file.Close();
                return data;
            }
        }
        //класс информации по пациенту
        [Serializable()]
        public class Patient
        {
            //члены
            public string name;            //имя пациента
            public string comment;         //комментарий к нему
            public bool redOnRight;        //находится ли красный фильтр напротив правого глаза
            public int fromMonitor;        //расстояние до монитора (см)
            public Palitre palitre;        //палитра данного пациента
            public List<Session> sessions;  //список сеансов данного пациента
            public List<Level> levels;      //список уровней сложности для пациента
            public List<Result> results;    //список результатов
            public int currentSession;     //текущий выбранный сеанс для данного пациента
            public int currentLevel;       //текущий выбранный уровень для пациента
            //
            //методы
            //конструктор
            public Patient()
            {
                name = "";
                comment = "";
                redOnRight = true;
                fromMonitor = 65;
                palitre = new Palitre();
                sessions = new List<Session>();
                levels = new List<Level>();
                results = new List<Result>();
                currentSession = -1;
                currentLevel = -1;
            }
            //конструктор с параметрами
            public Patient(string patientName, string patienComment, bool patientRedFilterOnRight = true, int patientFromMonitor = 65)
            {
                name = patientName;
                comment = patienComment;
                redOnRight = patientRedFilterOnRight;
                fromMonitor = patientFromMonitor;
                palitre = new Palitre();
                sessions = new List<Session>();
                levels = new List<Level>();
                results = new List<Result>();
                currentSession = -1;
                currentLevel = -1;
            }
            //изменить/получить имя
            [XmlIgnore]
            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }
            //изменить/получить комментарий
            [XmlIgnore]
            public string Comment
            {
                get
                {
                    return comment;
                }
                set
                {
                    comment = value;
                }
            }
            //изменить/получить находится ли фильт напротив правого глаза
            [XmlIgnore]
            public bool RedOnRight
            {
                get
                {
                    return redOnRight;
                }
                set
                {
                    redOnRight = value;
                }
            }
            //изменить/получить расстояние до монитора
            [XmlIgnore]
            public int FromMonitor
            {
                get
                {
                    return fromMonitor;
                }
                set
                {
                    fromMonitor = value;
                }
            }
            //получить/изменить палитру
            [XmlIgnore]
            public Palitre Palitre
            {
                get
                {
                    return palitre;
                }
                set
                {
                    palitre.Red = value.Red;
                    palitre.Blue = value.Blue;
                    palitre.BackColor = value.BackColor;
                }
            }
            //получить/изменить текущий выбранный сеанс для данного пациента
            [XmlIgnore]
            public int CurrentSession
            {
                get
                {
                    return currentSession;
                }
                set
                {
                    currentSession = value;
                }
            }
            //получить изменить текущий уровень
            [XmlIgnore]
            public int CurrentLevel
            {
                get
                {
                    return currentLevel;
                }
                set
                {
                    currentLevel = value;
                }
            }
            //посчитать среднее значение для сеансов
            public Result AverageResult()
            {
                Result ar = new Result();
                for (int i = 0; i < results.Count; i++)
                {
                    ar.Length += results[i].Length;
                    ar.Hit += results[i].Hit;
                    ar.Miss += results[i].Miss;
                    ar.HorDev += results[i].HorDev;
                    ar.HorDevDin += results[i].HorDevDin;
                    ar.VerDev += results[i].VerDev;
                    ar.VerDevDin += results[i].VerDevDin;
                    ar.Balls += results[i].Balls;
                }
                ar.Length /= results.Count;
                ar.Hit /= results.Count;
                ar.Miss /= results.Count;
                ar.HorDev /= results.Count;
                ar.HorDevDin /= results.Count;
                ar.VerDev /= results.Count;
                ar.VerDevDin /= results.Count;
                ar.Balls /= results.Count;
                return ar;
            }
            //выбрать лучшие значения
            public Result BestResults()
            {
                Result br = new Result();
                for (int i = 0; i < results.Count; i++)
                {
                    if (results[i].Hit > br.Hit)
                        br.Hit = results[i].Hit;
                    if (results[i].Balls > br.Balls)
                        br.Balls = results[i].Balls;
                    if (results[i].Miss < br.Miss)
                        br.Miss = results[i].Miss;
                    if (results[i].HorDev < br.HorDev)
                        br.HorDev = results[i].HorDev;
                    if (results[i].HorDevDin < br.HorDevDin)
                        br.HorDevDin = results[i].HorDevDin;
                    if (results[i].VerDev < br.VerDev)
                        br.VerDev = results[i].VerDev;
                    if (results[i].VerDevDin < br.VerDevDin)
                        br.VerDevDin = results[i].VerDevDin;
                }
                return br;
            }
            //возвращает общую продолжительность всех завершенных сеансов
            public int SessionLength()
            {
                int l = 0;
                for (int i = 0; i < results.Count; i++)
                    l += results[i].Length;
                return l;
            }
            //класс сортировки по имени
            public class SortByName : IComparer<Patient>
            {
                public int Compare(Patient x, Patient y)
                {
                    return x.Name.CompareTo(y.Name);
                }
            }
            //запись в файл
            public void Write(string fileName, Patient data)
            {
            //    data.palitre.iRed = data.palitre.red.ToArgb();
            //    data.palitre.iBlue = data.palitre.blue.ToArgb();
            //    data.palitre.iBG = data.palitre.backColor.ToArgb();
                XmlSerializer writer = new XmlSerializer(typeof(Patient));
                Stream file = File.Open(fileName, FileMode.Create);
                writer.Serialize(file, data);
                file.Close();
            }
            //чтение из файла
            public Patient Read(string fileName)
            {
                Patient data = new Patient();
                XmlSerializer writer = new XmlSerializer(typeof(Patient));
                Stream file = File.OpenRead(fileName);
                data = (Patient)writer.Deserialize(file);
                file.Close();
                //palitre.red = Color.FromArgb(palitre.iRed);
                //palitre.blue = Color.FromArgb(palitre.iBlue);
                //palitre.backColor = Color.FromArgb(palitre.iBG);
                return data;
            }
        }
        //класс настроек палитры пациента
        [Serializable()]
        public class Palitre
        {
            //члены класса
            public Color red;                      //красный цвет
            public int iRed;
            public Color blue;                     //синий цвет
            public int iBlue;
            public Color backColor;                //фон
            public int iBG;
            //
            //методы
            //конструктор
            public Palitre()
            {
                //пока работаем с прозрачностью, она у цветов - 50%, у фона - 100%
                this.red = Color.FromArgb(255, 102, 1, 0);
                this.blue = Color.FromArgb(255, 0, 88, 100);
                this.backColor = Color.FromArgb(255, 97, 97, 97);
            }
            //изменить/получить красный цвет
            [XmlIgnore]
            public Color Red
            {
                get
                {
                    return red;
                }
                set
                {
                    red = value;
                }
            }
            //изменить/получить cиний цвет
            [XmlIgnore]
            public Color Blue
            {
                get
                {
                    return blue;
                }
                set
                {
                    blue = value;
                }
            }
            //изменить/получить красный цвет
            [XmlIgnore]
            public Color BackColor
            {
                get
                {
                    return backColor;
                }
                set
                {
                    backColor = value;
                }
            }
        }
        //класс сеансов, включает список Упражнений и Паттернов
        [Serializable()]
        public class Session
        {
            //члены класса
            public string name;                    //название сеанса
            public string comment;                 //комментарий к сеансу
            public int length;                     //длительность сеанса в секундах
            public List<Pattern> patterns;          //список паттернов
            public List<Task> tasks;                //список упражнений
            public bool autoPatterns;              //автоматизация создания паттернов
            //
            //методы
            //конструктор
            public Session()
            {
                name = "";
                comment = "";
                length = 300;
                patterns = new List<Pattern>();
                tasks = new List<Task>();
                autoPatterns = true;
            }
            //конструктор
            public Session(string _name, string _comment, int _length)
            {
                name = _name;
                comment = _comment;
                length = _length;
                patterns = new List<Pattern>();
                tasks = new List<Task>();
                autoPatterns = true;
            }
            //получение/изменение названия
            [XmlIgnore]
            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }
            //получение/изменение комментария
            [XmlIgnore]
            public string Comment
            {
                get
                {
                    return comment;
                }
                set
                {
                    comment = value;
                }
            }
            //получение/изменение продолжительности сеанса
            [XmlIgnore]
            public int Length
            {
                get
                {
                    return length;
                }
                set
                {
                    length = value;
                }
            }
            //получение/изменение возможности создания паттернов вручную
            [XmlIgnore]
            public bool AutoPatterns
            {
                get
                {
                    return autoPatterns;
                }
                set
                {
                    autoPatterns = value;
                }
            }
            //возвращает текстовое имя типа задания
            public static string TaskName(int type)
            {
                switch (type)
                {
                    case 0:
                        return "Демонстрационный";
                    case 1:
                        return "Совмещение";
                    case 2:
                        return "Удержание";
                    case 3:
                        return "Центрирование";
                    default:
                        return "wrong type";
                }
            }
            //возвращает текстовое имя типа паттерна
            public static string PatternName(int type)
            {
                switch (type)
                {
                    case 0:
                        return "Демонстрационный";
                    case 1:
                        return "Вертикальный";
                    case 2:
                        return "Горизонтальный";
                    default:
                        return "wrong type";
                }
            }
        }
        //класс паттерна
        [Serializable()]
        public class Pattern
        {
            //члены класса
            public int type;                       //тип паттерна, 0 - по умолчанию, остальные типы в зависимости от их предназначения
            public int length;                     //продолжительность паттерна в секундах
            public int direction;                  //направление паттерна:
                                                   //0 - слева направо
                                                   //1 - справа налево
                                                   //2 - сверху вниз
                                                   //3 - снизу вверх
            public int color;                      //цвет объектов: 1 - красный, 2 - синий, 0 - белый
            //методы
            //конструктор по умолчанию
            public Pattern()
            {
                type = 0;
                length = 10;
                direction = 0;
                color = 0;
            }
            //конструктор
            public Pattern(int _length, int _type, int _direction = 0, int _color = 0)
            {
                length = _length;
                type = _type;
                direction = _direction;
                color = _color;
            }
            //получить/изменить тип
            [XmlIgnore]
            public int Type
            {
                get
                {
                    return type;
                }
                set
                {
                    type = value;
                }
            }
            //получить/изменить длительность
            [XmlIgnore]
            public int Length
            {
                get
                {
                    return length;
                }
                set
                {
                    length = value;
                }
            }
        }
        //класс упражнения
        [Serializable()]
        public class Task
        {
            //члены класса
            public int type;                       /*тип упражнения: 0 - демонстрационный вариант
                                                     * 1 - совмещение
                                                    * 2 - центрирование
                                                    * 3 - удерживание*/
            public int length;                     //продолжительность упражнения в секундах
            public bool rotation;                  //признак вращения, по-умолчанию - false - нет вращения
            public int blinkType;                  //признак мигания: по-умолчанию - 0 - нет мигания, 1 - одновременное, 2 - поочередное
            public int blinkPeriod;                //период мигания
            public bool hitObject;                 //если true  - после первого выстрела начать медленное сведение объектов до их визуального расхождения
            //методы
            //
            public Task()
            {
                type = 0;
                length = 0;
                rotation = false;
                blinkType = 0;
                blinkPeriod = 0;
                hitObject = false;
            }
            //конструктор
            public Task(int _type, int _length, bool _hitObject = false, bool _rotation = false, int _blinkType = 0, int _blinkPerod = 0)
            {
                type = _type;
                length = _length;
                rotation = _rotation;
                blinkType = _blinkType;
                blinkPeriod = _blinkPerod;
                hitObject = _hitObject;
            }
            //получение/изменение типа
            [XmlIgnore]
            public int Type
            {
                get
                {
                    return type;
                }
                set
                {
                    type = value;
                }
            }
            //получение/изменение признака вращения
            [XmlIgnore]
            public bool Rotation
            {
                get
                {
                    return rotation;
                }
                set
                {
                    rotation = value;
                }
            }
            //получение/изменение признака мигания
            [XmlIgnore]
            public int BlinkType
            {
                get
                {
                    return blinkType;
                }
                set
                {
                    blinkType = value;
                }
            }
            //получение/изменение длительности мигания
            [XmlIgnore]
            public int BlinkPeriod
            {
                get
                {
                    return blinkPeriod;
                }
                set
                {
                    blinkPeriod = value;
                }
            }
            //получение/изменение продолжительности упраженения
            [XmlIgnore]
            public int Length
            {
                get
                {
                    return length;
                }
                set
                {
                    length = value;
                }
            }
        }
        //класс уровня
        [Serializable()]
        public class Level
        {
            //члены класса
            public string name;                            //имя уровня
            public string comment;                         //комментарий
            public int horizontalDeviation;                //допуск горизонтального отклонения в % от размера
            public int verticalDeviation;                  //допуск вертикального отклонения в % от размера
            public int showTimes;                          //количество показов одного объекта
            public int objectK;                            //коэффициент изменения размера объекта в %
            public int hitBalls;                           //баллы за попадание
            public int bonusAccuracy;                      //% бонус за точность
            public int bonusSize;                          //% бонус за размер
            public int bonusDinamic;                       //% бонус за динамику
            //
            //методы
            //конструктор по умолчанию
            public Level()
            {
                name = "";
                comment = "";
                horizontalDeviation = 0;
                verticalDeviation = 0;
                showTimes = 1;
                objectK = 0;
                hitBalls = 0;
                bonusAccuracy = 0;
                bonusDinamic = 0;
                bonusSize = 0;
            }
            //конструктор
            public Level(string _name, string _comment = "", int _st = 1, int _hd = 0, int _vd = 0, int _ok = 0, int _hb = 0, int _ba = 0, int _bs = 0, int _bd = 0)
            {
                name = _name;
                comment = _comment;
                horizontalDeviation = _hd;
                verticalDeviation = _vd;
                showTimes = _st;
                objectK = _ok;
                hitBalls = _hb;
                bonusAccuracy = _ba;
                bonusSize = _bs;
                bonusDinamic = _bd;
            }
            //получение/изменение имени
            [XmlIgnore]
            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }
            //получение/изменение комментария
            [XmlIgnore]
            public string Comment
            {
                get
                {
                    return comment;
                }
                set
                {
                    comment = value;
                }
            }
            //получение/изменение верт.допуска
            [XmlIgnore]
            public int VerticalDeviation
            {
                get
                {
                    return verticalDeviation;
                }
                set
                {
                    verticalDeviation = value;
                }
            }
            //получение/изменение гор.допуска
            [XmlIgnore]
            public int HorizontalDeviation
            {
                get
                {
                    return horizontalDeviation;
                }
                set
                {
                    horizontalDeviation = value;
                }
            }
            //получение/изменение количества попаданий до смены объекта
            [XmlIgnore]
            public int ObjectK
            {
                get
                {
                    return objectK;
                }
                set
                {
                    objectK = value;
                }
            }
            //получение/изменение баллов за попадание
            [XmlIgnore]
            public int HitBalls
            {
                get
                {
                    return hitBalls;
                }
                set
                {
                    hitBalls = value;
                }
            }
            //получение/изменение бонуса за точность
            [XmlIgnore]
            public int BonusAccuracy
            {
                get
                {
                    return bonusAccuracy;
                }
                set
                {
                    bonusAccuracy = value;
                }
            }
            //получение/изменение бонуса за размер
            [XmlIgnore]
            public int BonusSize
            {
                get
                {
                    return bonusSize;
                }
                set
                {
                    bonusSize = value;
                }
            }
            //получение/изменение бонуса за динамику
            [XmlIgnore]
            public int BonusDinamic
            {
                get
                {
                    return bonusDinamic;
                }
                set
                {
                    bonusDinamic = value;
                }
            }
        }
        //класс результата
        [Serializable()]
        public class Result
        {
            //члены класса
            public string name;                            //название сеанса
            public string comment;                         //комментарий, добавляемый к записи
            public DateTime date;                          //дата и время проведения сеанса
            public int length;                             //продолжительность
            public int hit;                                //количество попаданий
            public int miss;                               //количество промахов
            public double balls;                           //количество баллов
            //отсутствуют формулы для рассчета, передавать
            public double horizontalDiviation;             //горизонтальное отклонение (нерассч.)
            public double horizontalDiviationDinamic;      //горизонтальное отклонения для динамических объектов (нерассч.)
            public double verticalDiviation;               //вертикальное отклонение (нерассч.)
            public double verticalDeviationDinamic;        //вертикальное отклонение для динамических объектов (нерассч.)
            //
            //методы
            //конструктор по умолчанию
            public Result()
            {
                name = "";
                comment = "";
                date = new DateTime();
                horizontalDiviation = 0;
                horizontalDiviationDinamic = 0;
                verticalDiviation = 0;
                verticalDeviationDinamic = 0;
                hit = 0;
                miss = 0;
                balls = 0;
            }
            //конструтор
            public Result(string _name, string _comment = "")
            {
                name = _name;
                comment = _comment;
                date = new DateTime();
                length = 0;
                horizontalDiviation = 0;
                horizontalDiviationDinamic = 0;
                verticalDiviation = 0;
                verticalDeviationDinamic = 0;
                hit = 0;
                miss = 0;
                balls = 0;
            }
            //конструтор
            public Result(string _name, string _comment, DateTime _date, int _len, int _hit, int _miss, double _balls, double _hd, double _hdd, double _vd, double _vdd)
            {
                name = _name;
                comment = _comment;
                date = _date;
                length = _len;
                horizontalDiviation = _hd;
                horizontalDiviationDinamic = _hdd;
                verticalDiviation = _vd;
                verticalDeviationDinamic = _vdd;
                hit = _hit;
                miss = _miss;
                balls = _balls;
            }
            //получение/изменение имени
            [XmlIgnore]
            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }
            //получение/изменение комментария
            [XmlIgnore]
            public string Comment
            {
                get
                {
                    return comment;
                }
                set
                {
                    comment = value;
                }
            }
            //получение/изменение продолжительности
            [XmlIgnore]
            public int Length
            {
                get
                {
                    return length;
                }
                set
                {
                    length = value;
                }
            }
            //получение/изменение количества попаданий
            [XmlIgnore]
            public int Hit
            {
                get
                {
                    return hit;
                }
                set
                {
                    hit = value;
                }
            }
            //получение/изменение количества промахов
            [XmlIgnore]
            public int Miss
            {
                get
                {
                    return miss;
                }
                set
                {
                    miss = value;
                }
            }
            //получение/изменение количества баллов
            [XmlIgnore]
            public double Balls
            {
                get
                {
                    return balls;
                }
                set
                {
                    balls = value;
                }
            }
            //получение/изменение горизонтального отклонения
            [XmlIgnore]
            public double HorDev
            {
                get
                {
                    return horizontalDiviation;
                }
                set
                {
                    horizontalDiviation = value;
                }
            }
            //получение/изменение горизонтального отклонения с динамикой
            [XmlIgnore]
            public double HorDevDin
            {
                get
                {
                    return horizontalDiviationDinamic;
                }
                set
                {
                    horizontalDiviationDinamic = value;
                }
            }
            //получение/изменение вертикального отклонения
            [XmlIgnore]
            public double VerDev
            {
                get
                {
                    return verticalDiviation;
                }
                set
                {
                    verticalDiviation = value;
                }
            }
            //получение/изменение вертикального отклонения с динамикой
            [XmlIgnore]
            public double VerDevDin
            {
                get
                {
                    return verticalDeviationDinamic;
                }
                set
                {
                    verticalDeviationDinamic = value;
                }
            }
            //возвращение/изменение времени и даты
            [XmlIgnore]
            public DateTime Date
            {
                get
                {
                    return date;
                }
                set
                {
                    date = value;
                }
            }
        }
        //структура входных данных графической части
        [Serializable()]
        public class InnerData
        {
            public string patientName;             //ФИО пациента
            public string sessionType;             //название сеанса
            public int fromMonitor;                //расстояние до монитора
            public int sessionLength;              //продолжительность сеанса (сек)
            public List<Task> tasks;               //список упражнений
            public List<Pattern> patterns;         //список паттернов (на 1 меньше количества упражнений)
            public int horDev;                     //% допустимого горизонтального отклонения
            public int vertDev;                    //% допустимого вертикального отклонения
            public int showTimes;               //количество показов объекта
            public int koef;                       //коэффициент изменения размера объекта
            public int balls;                      //баллы
            public int bonusAcc;                   //% бонус за точность
            public int bonusSize;                  //% бонус за размер 
            public int bonusDin;                   //% бонус за динамику
            [XmlIgnore]
            public int[]  red                      //красный цвет
            {
                get
                {
                    int[] mas = new int[3];
                    mas[0] = (Color.FromArgb(cRed)).R;
                    mas[1] = (Color.FromArgb(cRed)).G;
                    mas[2] = (Color.FromArgb(cRed)).B;
                    return mas;
                }
            }
            public int cRed;
            [XmlIgnore]
            public int[] blue                     //синий цвет
            {
                get
                {
                    int[] mas = new int[3];
                    mas[0] = (Color.FromArgb(cBlue)).R;
                    mas[1] = (Color.FromArgb(cBlue)).G;
                    mas[2] = (Color.FromArgb(cBlue)).B;
                    return mas;
                }
            }
            public int cBlue;
            //[XmlIgnore]
            public int[] bg                       //фон
            {
                get
                {
                    int[] mas = new int[3];
                    mas[0] = (Color.FromArgb(cBG)).R;
                    mas[1] = (Color.FromArgb(cBG)).G;
                    mas[2] = (Color.FromArgb(cBG)).B;
                    return mas;
                }
            }
            public int cBG;
            //конструктор
            public InnerData()
            {
                this.tasks = new List<Task>();
                this.patterns = new List<Pattern>();
            }
            //конструктор
            public InnerData(Patient patient)
            {
                patientName = patient.name;
                sessionType = patient.sessions[patient.currentSession].name;
                sessionLength = patient.sessions[patient.currentSession].length;
                tasks = new List<Task>(patient.sessions[patient.currentSession].tasks);
                patterns = new List<Pattern>(patient.sessions[patient.currentSession].patterns);
                horDev = patient.levels[patient.currentLevel].horizontalDeviation;
                vertDev = patient.levels[patient.currentLevel].verticalDeviation;
                showTimes = patient.levels[patient.currentLevel].showTimes;
                koef = patient.levels[patient.currentLevel].objectK;
                balls= patient.levels[patient.currentLevel].hitBalls;
                bonusAcc = patient.levels[patient.currentLevel].bonusAccuracy;
                bonusDin = patient.levels[patient.currentLevel].bonusDinamic;
                bonusSize = patient.levels[patient.currentLevel].bonusSize;
                cRed = patient.palitre.iRed;
                cBlue = patient.palitre.iBlue;
                cBG = patient.palitre.iBG;
                fromMonitor = patient.fromMonitor;
            }
            //запись в файл
            public static void Write(string fileName, InnerData data)
            {
                XmlSerializer writer = new XmlSerializer(typeof(InnerData));
                Stream file = File.Open(fileName, FileMode.Create);
                writer.Serialize(file, data);
                file.Close();
            }
            //чтение из файла
            public static InnerData Read(string fileName)
            {
                InnerData returnData = new InnerData();
                XmlSerializer writer = new XmlSerializer(typeof(InnerData));
                Stream file = File.OpenRead(fileName);
                returnData = (InnerData)writer.Deserialize(file);
                file.Close();
                return returnData;
            }
        }
        //структура выходных данных графической части
        [Serializable()]
        public class OuterData
        {
            public string patientName;         //ФИО пациента
            public DateTime sessionDate;       //дата и время проведения сеанса
            public int sessionLength;          //фактическая продолжительность
            public string sessionType;         //название сеанса
            public int fromMonitor;            //расстояние до монитора в сантиметрах
            public double horDev;              //горизонтальное отклонение (рассч.)
            public double horDevDin;           //горизонтальное отклонение при динамике (рассч.)
            public double verDev;              //вертикальное отклонение (рассч.)
            public double verDevDin;           //вертикальное отклонение при динамике  (рассч.)
            public int hits;                   //количество попаданий
            public int miss;                   //количество промахов
            public double balls;               //количество заработанных баллов
            //методы
            //конструктор
            public OuterData()
            {
                patientName = "";
                sessionDate = new DateTime();
                sessionLength = 0;
                sessionType = "";
                horDev = 0;
                horDevDin = 0;
                verDev = 0;
                verDevDin = 0;
                hits = 0;
                miss = 0;
                balls = 0;
                fromMonitor = 0;
            }
            //чтение из файла
            public static OuterData Read(string fileName)
            {
                OuterData data = new OuterData();
                XmlSerializer writer = new XmlSerializer(typeof(OuterData));
                Stream file = File.OpenRead(fileName);
                data = (OuterData)writer.Deserialize(file);
                file.Close();
                return data;
            }
            //запись в файл
            public static void Write(string fileName, OuterData data)
            {
                XmlSerializer writer = new XmlSerializer(typeof(OuterData));
                Stream file = File.Open(fileName, FileMode.Create);
                writer.Serialize(file, data);
                file.Close();
            }
        }
        //контейнер для OuterData
        [Serializable]
        public class SessionResults
        {
            public List<OuterData> sessionResults;  //список результатов сеансов
            //конструктор
            public SessionResults()
            {
                sessionResults = new List<OuterData>();
            }
            //чтение из файла
            public static SessionResults Read(string fileName)
            {
                SessionResults data = new SessionResults();
                XmlSerializer writer = new XmlSerializer(typeof(SessionResults));
                Stream file = File.OpenRead(fileName);
                data = (SessionResults)writer.Deserialize(file);
                file.Close();
                return data;
            }
            //запись в файл
            public static void Write(string fileName, SessionResults data)
            {
                XmlSerializer writer = new XmlSerializer(typeof(SessionResults));
                Stream file = File.Open(fileName, FileMode.Create);
                writer.Serialize(file, data);
                file.Close();
            }
        }
}
