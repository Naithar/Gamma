using UnityEngine;
using System.Collections;

using SceneType = Data.SceneType;
using CL = ClassesLib;
using System.IO;
using S = System;


public class _main : MonoBehaviour
{
    public Data data;
    public backgroundGO backgroundObject;
    public mixingGO mixingObject;
    public constantGO constantObject;
    
    public float currentSceneTime = 0;
    //public float currentScore = 0;
    public int currentHits = 0;
    public int currentMisses = 0;
    
    public float mouseSensitivity = 10;
    
    public Vector2 mousePosition;

    public Vector2 mixMoveVector;
    public float mixMoveSpeed = 100;
    public bool isFollowing = false;
    public float followingTime = 0;

    public bool paused = false;

    public GUISkin guiSkin;

    public float horizontalDiff;
    public float verticalDiff;

    public float horizontalDiffDin;
    public float verticalDiffDin;

    Data findDataObject()
    {
        Data[] array = (Data[])GameObject.FindObjectsOfType(typeof(Data));

        for (int i = 1; i < array.Length; i++)
        {
            Destroy((array[i]).gameObject as Object);
        }

        return array[0];
    }

    //string text;

    void Log(string text, bool clearTooMany = false)
    {
        StreamWriter logFile = null;

        if (clearTooMany)
        {
            int lineCount = 0;
            try
            {
                using (StreamReader reader = new StreamReader("log.txt"))
                {
                    while (reader.ReadLine() != null)
                    {
                        lineCount++;
                    }
                }
            }
            catch { }

            logFile = new StreamWriter("log.txt", lineCount < 100);
        }
        else
        {
            logFile = new StreamWriter("log.txt", true);
        }

        logFile.WriteLine(text);

        logFile.Close();
    }

    void Awake()
    {
        Log("Starting at " + S.DateTime.Now.ToShortDateString() + " " + S.DateTime.Now.ToShortTimeString(), true);
        Log("Screen width: " + Screen.width);
        Log("Screen height: " + Screen.height);

        try
        {
           
            string[] cmdArgs = System.Environment.GetCommandLineArgs();
            string fileName = string.Empty;
            for (int i = 0; i < cmdArgs.Length; i++)
            {
                if (cmdArgs[i] == "-file")
                {
                    fileName = cmdArgs[i + 1];
                }
            }

            Log("File to load: " + fileName);

            Screen.fullScreen = true;
            Screen.showCursor = false;

            //fileName = "C:\\Users\\Naithar\\Documents\\Unity Test Projects\\UnityGamma\\bin\\234.gsf";

            Application.targetFrameRate = 30;

            this.data = findDataObject();
            if (fileName != string.Empty)
            {
                fileName = fileName.Replace("^", " ");
                this.data.LoadFile(fileName);

                Log("Loaded File");
            }

            if(this.data.LoadLevel())
            {
                Log("Level loaded");

                ProcessAwake(this.data.sceneType, this.data.sceneSubtype);
            }
            else
            {
                Application.Quit();
            }
        }
        catch (System.Exception)
        {
            Application.Quit();
        }
    }

    void ProcessAwake(SceneType sceneType, int sceneSubtype)
    {
        switch (sceneType)
        {
            case SceneType.Task:
                {
                    this.backgroundObject.objectEnabled = false;

                    this.mixingObject.objectEnabled = true;
                    this.constantObject.objectEnabled = true;

                    this.currentHits = 0;
                    this.currentMisses = 0;
                    this.currentSceneTime = 0;

                    this.mixingObject.textureColor = this.data.mixColor;
                    this.constantObject.textureColor = this.data.moveColor;
                    this.backgroundObject.backgroundColor = this.data.backColor;

                    this.mixingObject.scale = new Vector2(this.data.objectScale, this.data.objectScale);
                    this.constantObject.scale = new Vector2(this.data.objectScale, this.data.objectScale);

                    this.mixingObject.enableBlink = (this.data.blinkType != 0);
                    this.mixingObject.blinkTime = this.data.blinkTime / 1000;

                    this.constantObject.enableBlink = (this.data.blinkType != 0);
                    this.constantObject.blinkTime = this.data.blinkTime / 1000;
                    this.constantObject.blinkStartTime = (this.data.blinkType == 2) ? this.data.blinkTime / 1000 : 0;

                    this.mixingObject.rotation.z = (this.data.rotation) ? 10 : 0;
                    this.constantObject.rotation.z = (this.data.rotation) ? 10 : 0;

                    this.isFollowing = false;
                    this.followingTime = 0;

                    this.horizontalDiff = 0;
                    this.verticalDiff = 0;

                    this.horizontalDiffDin = 0;
                    this.verticalDiffDin = 0;

                    this.mixingObject.externalPath = true;
                    this.constantObject.externalPath = true;
                    int index = Random.Range(0, this.data.redTextures.Count);
                    this.mixingObject.texturePath = this.data.redTextures[index];
                    this.constantObject.texturePath = this.data.blueTextures[index];

                    switch (sceneSubtype)
                    {
                        case 3:
                            {
                                this.mixMoveVector = new Vector2(Random.Range(-1, 1), Random.Range(-1, 1));
                                if (this.mixMoveVector.x == 0)
                                {
                                    this.mixMoveVector.x = 1;
                                }
                                if (this.mixMoveVector.y == 0)
                                {
                                    this.mixMoveVector.y = 1;
                                }
                            }
                            break;
                    }
                }
                break;
            case SceneType.Pattern:
                {
                    this.backgroundObject.objectEnabled = true;

                    //this.mixingObject.objectEnabled = false;
                    this.constantObject.objectEnabled = false;

                    this.backgroundObject.backgroundColor = Color.black;

                    this.backgroundObject.externalPath = true;
                    this.backgroundObject.texturePath = this.data.patternTextures[Random.Range(0, this.data.patternTextures.Count)];

                    this.mixingObject.objectEnabled = true;
                    this.backgroundObject.staticDot.textureColor = this.data.moveColor;
                    this.mixingObject.transform.position = new Vector3(this.backgroundObject.staticDot.transform.position.x, this.backgroundObject.staticDot.transform.position.y, this.mixingObject.transform.position.z);
                    this.mixingObject.scale = new Vector2(0.75f, 0.75f);
                    this.mixingObject.textureColor = this.data.mixColor;

                    switch(Random.Range(0, 3))
                    {
                        case 0:
                            {
                                this.backgroundObject.textureColor = (this.data.mixColor != Color.black) ? this.data.mixColor : Color.white;
                            }
                            break;
                        case 1:
                            {
                                this.backgroundObject.textureColor = (this.data.moveColor != Color.black) ? this.data.moveColor : Color.white;
                            }
                            break;
                        case 2:
                            {
                                this.backgroundObject.textureColor = (this.data.backColor != Color.black) ? this.data.backColor : Color.white;
                            }
                            break;
                    }

                    this.backgroundObject.textureScale.x = 10;
                    this.backgroundObject.textureScale.y = 5;

                    switch (sceneSubtype)
                    {
                        case 1:
                            {
                                this.backgroundObject.textureOffset.x = 0.1f;
                                this.backgroundObject.textureOffset.y = 0;
                            }
                            break;
                        case 2:
                            {
                                this.backgroundObject.textureOffset.x = 0;
                                this.backgroundObject.textureOffset.y = 0.1f;
                            }
                            break;
                    }
                }
                break;
        }
    }

    bool GetNextLevel(bool forceChange = false)
    {
        if (this.data.ChangeScene(this, forceChange))
        {
            Application.LoadLevel("_scene");
            return true;
        }

        return false;
    }

    void JumpNextLevel(int count)
    {
        if (this.data.JumpScene(this, count))
        {
            Application.LoadLevel("_scene");
        }
        else
        {
            Application.Quit();
        }
    }

    void UpdateSceneObjects()
    {
        this.constantObject.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(this.mousePosition.x, this.mousePosition.y, 65));
        
        switch (this.data.sceneSubtype)
        {
            case 1:
                {
                    this.mixingObject.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width - this.mousePosition.x, Screen.height - this.mousePosition.y, 50));
                }
                break;
            case 2:
                {
                    this.mixingObject.transform.position = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 50));
                }
                break;
            case 3:
                {
                    Vector3 mPos = Camera.main.WorldToScreenPoint(this.mixingObject.transform.position);

                    mPos.x = Mathf.Clamp(mPos.x + this.mixMoveVector.x * this.mixMoveSpeed * Time.deltaTime, 0, Screen.width);
                    mPos.y = Mathf.Clamp(mPos.y + this.mixMoveVector.y * this.mixMoveSpeed * Time.deltaTime, 0, Screen.height);
                    mPos.z = 50;
                    if (mPos.x == 0 || mPos.x == Screen.width)
                    {
                        this.mixMoveVector.x = -this.mixMoveVector.x;
                    }
                    if (mPos.y == 0 || mPos.y == Screen.height)
                    {
                        this.mixMoveVector.y = -this.mixMoveVector.y;
                    }
                    this.mixingObject.transform.position = Camera.main.ScreenToWorldPoint(mPos);

                    this.followingTime += Time.deltaTime;

                    if (isFollowing && this.followingTime >= 1)
                    {
                        this.followingTime = 0;
                        if (isHit())
                        {
                            this.currentHits++;
                        }
                        else
                        {
                            this.currentMisses++;
                        }
                    }
                }
                break;
        }
    }

    Rect GetHitRectangle()
    {
        int X = (int)this.mixingObject.transform.position.x;
        int Y = (int)this.mixingObject.transform.position.y;

        float left = X - (5 * this.data.objectScale * this.data.horizontalTreshold);
        float width = 2 * (5 * this.data.objectScale * this.data.horizontalTreshold);
        float bottom = Y - (5 * this.data.objectScale * this.data.verticalTreshold);
        float height = 2 * (5 * this.data.objectScale * this.data.verticalTreshold);

        Rect rectangle = new Rect(left, bottom, width, height);

        return rectangle;
    }

    bool isHit()
    {
        Rect hitRect = GetHitRectangle();

        Vector2 position = new Vector2(this.constantObject.transform.position.x, this.constantObject.transform.position.y);

        if(hitRect.Contains(position))
        {
            return true;
        }

        return false;
    }

    void ReloadObjects()
    {
        this.data.redTextures.Remove(this.mixingObject.texturePath);
        this.data.blueTextures.Remove(this.constantObject.texturePath);
        this.data.LoadTextures();
        this.mixingObject.externalPath = true;
        this.constantObject.externalPath = true;
        int index = Random.Range(0, this.data.redTextures.Count);
        this.mixingObject.texturePath = this.data.redTextures[index];
        this.constantObject.texturePath = this.data.blueTextures[index];

        this.mousePosition.x = Random.Range(0, Screen.width);
        this.mousePosition.y = Random.Range(0, Screen.height);
    }

    void ProcessAction()
    {
        switch(this.data.sceneType)
        {
        //change for scene subtype
            case SceneType.Task:
                {
                    Vector3 constPos = Camera.mainCamera.WorldToScreenPoint(this.constantObject.transform.position);
                    Vector3 mixPos = Camera.mainCamera.WorldToScreenPoint(this.mixingObject.transform.position);

                    if ( (!this.constantObject.enableBlink && this.constantObject.rotation == Vector3.zero)
                        && (!this.mixingObject.enableBlink && this.mixingObject.rotation == Vector3.zero))
                    {
                        this.horizontalDiff += Mathf.Abs(constPos.x - mixPos.x);
                        this.verticalDiff += Mathf.Abs(constPos.y - mixPos.y);
                    }
                    else
                    {
                        this.horizontalDiffDin += Mathf.Abs(constPos.x - mixPos.x);
                        this.verticalDiffDin += Mathf.Abs(constPos.y - mixPos.y);
                    }

                    switch (this.data.sceneSubtype)
                    {
                        case 1:
                        case 2:
                            {
                                if (isHit())
                                {
                                    this.currentHits++;
                                    if (this.currentHits % this.data.userHits == 0)
                                    {
                                        ReloadObjects();
                                    }
                                }
                                else
                                {
                                    this.currentMisses++;

                                    if (this.currentMisses % this.data.userMisses == 0)
                                    {
                                        ReloadObjects();
                                    }
                                }

                                GetNextLevel();
                            }
                            break;
                        case 3:
                            {
                                if (isFollowing)
                                {
                                    if (!GetNextLevel())
                                    {
                                        ReloadObjects();
                                        isFollowing = false;
                                    }
                                }

                                if (!isFollowing)
                                {
                                    isFollowing = true;
                                }
                            }
                            break;
                    }
                }
                break;
            case SceneType.Pattern:
                {
                    GetNextLevel(true);
                }
                break;
        }
    }

	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            paused = !paused;
            Screen.showCursor = paused;
            Screen.lockCursor = !paused;
        }

        if (paused)
        {
            return;
        }

        this.currentSceneTime += Time.deltaTime;

        if (Input.GetButtonDown("Fire"))
        {
            ProcessAction();
        }

        if (Input.GetButtonDown("NextScene"))
        {
            JumpNextLevel(2);
        }

        if (Input.GetButtonDown("PrevScene"))
        {
            JumpNextLevel(-2);
        }

        if (Input.GetButtonDown("ChangeObject"))
        {
            ReloadObjects();
        }

        if (this.data.sceneType == SceneType.Pattern)
        {
            backgroundObject.Offset(Time.deltaTime);
            GetNextLevel();
        }

        if (this.data.sceneType == SceneType.Task)
        {
            this.mousePosition.x = Mathf.Clamp(this.mousePosition.x + Input.GetAxis("MoveX") * this.mouseSensitivity, 0, Screen.width);
            this.mousePosition.y = Mathf.Clamp(this.mousePosition.y + Input.GetAxis("MoveY") * this.mouseSensitivity, 0, Screen.height);

            UpdateSceneObjects();
        }
    }

    void OnApplicationQuit()
    {
        try
        {
            Log("Quiting");

            CL.OuterData outerData = this.data.GetOuterData();
            
            outerData.balls += this.data.GetScore(this);

            outerData.hits += this.currentHits;
            outerData.miss += this.currentMisses;

            outerData.sessionLength += (int)this.currentSceneTime;

            if (this.horizontalDiff != 0)
            {
                outerData.horDev += (this.horizontalDiff / (this.currentHits + this.currentMisses));
            }
            if (this.horizontalDiffDin != 0)
            {
                outerData.horDevDin += (this.horizontalDiffDin / (this.currentHits + this.currentMisses));
            }

            if (this.verticalDiff != 0)
            {
                outerData.verDev += (this.verticalDiff / (this.currentHits + this.currentMisses));
            }
            if (this.verticalDiffDin != 0)
            {
                outerData.verDevDin += (this.verticalDiffDin / (this.currentHits + this.currentMisses));
            }

            CL.SessionResults sessionResult = new CL.SessionResults();

            try
            {
                sessionResult = CL.SessionResults.Read("settings//SessionResults.xml");
            }
            catch (System.Exception)
            { }

            sessionResult.sessionResults.Add(outerData);

            CL.SessionResults.Write("settings//SessionResults.xml", sessionResult);
        }
        catch (System.Exception)
        { }

    }

    
    void OnGUI()
    {
        //GUI.TextArea(new Rect(10, 10, 1000, 200), text);

        if (paused && this.data.iData != null)
        {
            Vector2 size = Camera.main.ViewportToScreenPoint(new Vector2(1, 1));

            Rect boxRect = new Rect(1, 1, size.x - 2, size.y - 2);
            GUI.skin = guiSkin;
            GUI.Window(0, boxRect,
                (id) => {

                    GUI.TextField(new Rect(0, 0, size.x, 90),
                        string.Format("Пользователь: {0}\r\nНазвание сеанса: {1}\r\nПродолжительность сеанса: {2} сек.",
                        this.data.iData.patientName, this.data.iData.sessionType, (int)(this.data.userTime + this.currentSceneTime)));

                    GUI.TextField(new Rect(0, size.y - 160, size.x, 160),
                        "Управление:\r\n" +
                        "Перемещение объектов: мышь, стрелки на клавиатуре, wasd\r\n" +
                        "\"Выстрел\", смена паттерна: левая кнопка мыши, Enter, пробел\r\n" + 
                        "Сменить объект: Tab\r\n" +
                        "Следующее задание: Ctrl\r\n" + 
                        "Предыдущее задание: Shift");

                    if (GUI.Button(new Rect((size.x - 2) / 2 - 125, size.y / 2 - 50, 250, 30), "Следующее упражнение"))
                    {
                        JumpNextLevel(2);
                    }
                    if (GUI.Button(new Rect((size.x - 2) / 2 - 125, size.y / 2 - 15, 250, 30), "Предыдущее упраждение"))
                    {
                        JumpNextLevel(-2);
                    }
                    if (GUI.Button(new Rect((size.x - 2) / 2 - 125, size.y / 2 + 20, 250, 30), "Выйти"))
                    {
                        Application.Quit();
                    }
                    if (GUI.Button(new Rect((size.x - 2) / 2 - 125, size.y / 2 + 55, 250, 30), "Сменить объект"))
                    {
                        ReloadObjects();
                    }

                    
                }, "Меню");
            GUI.FocusWindow(0);
        }
    }
    
}
