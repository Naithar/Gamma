using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using ClassesLib;
using System;
using System.IO;
using System.Linq;

public class Data : MonoBehaviour
{
    public enum SceneType
    {
        Pattern, Task
    }

    void Awake()
    {
        DontDestroyOnLoad(this);
    }

    public SceneType sceneType = SceneType.Task;
    public int sceneSubtype = 0;
        
    public int sceneNumber = 0;
    public float sceneTime = 5;
    
    public Color mixColor;
    public Color moveColor;
    public Color backColor;

    public float userScore;
    public int userHits;
    //public int userMisses;
    public float userTime;
    public int sUserHits;
    public int sUserMisses;

    public float objectScale;
    public float scoreAddition;
    public float accuracyBonus;
    public float sizeBonus;
    public float dynamicsBonus;

    public float horizontalTreshold;
    public float verticalTreshold;

    public bool rotation;
    public int blinkType;
    public float blinkTime;

    public float horizontalDiff;
    public float verticalDiff;

    public float horizontalDiffDin;
    public float verticalDiffDin;

    public bool hitObject;

    public int patternDirection;
    public int patternColor;
    //other info form inner data

    public List<string> redTextures = new List<string>();
    public List<string> blueTextures = new List<string>();
    public List<string> patternTextures = new List<string>();

    InnerData innerData = null;
    public InnerData iData
    {
        get
        {
            return innerData;
        }
    }

    public float GetScore(_main owner)
    {
        float hitsScoring = owner.currentHits * this.scoreAddition;
        float accuracyScoring = owner.currentHits * this.scoreAddition * this.accuracyBonus;
        float dynamicsScoring = (this.rotation || this.blinkType != 0) ? owner.currentHits * this.scoreAddition * this.dynamicsBonus : 0;
        float sizeScoring = (this.objectScale < 1.0f) ? owner.currentHits * this.scoreAddition * this.sizeBonus : 0;

        return (hitsScoring + accuracyScoring + dynamicsScoring + sizeScoring);
    }

    void changeScene(_main owner)
    {
        this.userScore += GetScore(owner);
        this.userTime += owner.currentSceneTime;
        if (this.sceneType == SceneType.Task && this.sceneSubtype != 3)
        {
            this.sUserHits += owner.currentHits;
            this.sUserMisses += owner.currentMisses;
        }

        if (owner.horizontalDiff != 0)
        {
            this.horizontalDiff += (owner.horizontalDiff / (owner.currentHits + owner.currentMisses));
        }
        if (owner.verticalDiff != 0)
        {
            this.verticalDiff += (owner.verticalDiff / (owner.currentHits + owner.currentMisses));
        }

        if (owner.horizontalDiffDin != 0)
        {
            this.horizontalDiffDin += (owner.horizontalDiffDin / (owner.currentHits + owner.currentMisses));
        }
        if (owner.verticalDiffDin != 0)
        {
            this.verticalDiffDin += (owner.verticalDiffDin / (owner.currentHits + owner.currentMisses));
        }

        this.sceneNumber++;
    }

    public bool JumpScene(_main owner, int count)
    {
        changeScene(owner);
        this.sceneNumber--;
        this.sceneNumber += count;

        if (this.sceneNumber < 0)
        {
            this.sceneNumber = 0;
        }

        if (this.sceneNumber > this.innerData.tasks.Count + this.innerData.patterns.Count)
        {
            return false;
        }

        return true;
    }

    public bool ChangeScene(_main owner, bool forceChange)
    {
        if (owner.currentSceneTime >= this.sceneTime || forceChange)
        {
            switch(this.sceneType)
            {
                case SceneType.Task:
                    {
                        switch (this.sceneSubtype)
                        {
                            case 1:
                            case 2:
                                {
                                    if (owner.currentMisses + owner.currentHits >= this.userHits)
                                    {
                                        changeScene(owner);
                                        return true;
                                    }
                                }
                                break;
                            case 3:
                                {
                                    if (owner.isFollowing)
                                    {
                                        changeScene(owner);
                                        return true;
                                    }
                                }
                                break;
                        }
                    }
                    break;
                case SceneType.Pattern:
                    {
                        changeScene(owner);
                        return true;
                    }
            }
        }

        return false;
    }

    public bool LoadLevel()
    {
        try
        {
            if (this.sceneNumber % 2 == 0)
            {
                int index = this.sceneNumber / 2;

                if (index >= innerData.tasks.Count)
                {
                    return false;
                }

                this.sceneType = SceneType.Task;
                this.sceneSubtype = innerData.tasks[index].type;
                this.sceneTime = innerData.tasks[index].length;

                this.rotation = innerData.tasks[index].rotation;
                this.blinkType = innerData.tasks[index].blinkType;
                this.blinkTime = innerData.tasks[index].blinkPeriod;
                this.hitObject = innerData.tasks[index].hitObject;

                LoadTextures();
            }
            else
            {
                int index = (this.sceneNumber - 1) / 2;

                if (index >= innerData.patterns.Count)
                {
                    return false;
                }
                
                this.sceneType = SceneType.Pattern;
                this.sceneSubtype = innerData.patterns[index].type;
                this.sceneTime = innerData.patterns[index].length;
                this.patternDirection = innerData.patterns[index].direction;
                this.patternColor = innerData.patterns[index].color;
                LoadTextures();
            }
        }
        catch (Exception)
        {
            return false;
        }

        return true;
    }

    public void LoadTextures()
    {
        if (redTextures.Count == 0)
        {
            redTextures.Clear();
            blueTextures.Clear();

            var ListFiles = Directory
                                .GetFiles(string.Format("textures\\tasks\\{0}\\r", this.sceneSubtype), "*.bmp", SearchOption.AllDirectories);
            redTextures.AddRange(ListFiles);
            ListFiles = Directory
                                .GetFiles(string.Format("textures\\tasks\\{0}\\r", this.sceneSubtype), "*.jpg", SearchOption.AllDirectories);
            redTextures.AddRange(ListFiles);
            ListFiles = Directory
                                .GetFiles(string.Format("textures\\tasks\\{0}\\r", this.sceneSubtype), "*.png", SearchOption.AllDirectories);
            redTextures.AddRange(ListFiles);

            ListFiles = Directory
                                .GetFiles(string.Format("textures\\tasks\\{0}\\b", this.sceneSubtype), "*.bmp", SearchOption.AllDirectories);
            blueTextures.AddRange(ListFiles);
            ListFiles = Directory
                                .GetFiles(string.Format("textures\\tasks\\{0}\\b", this.sceneSubtype), "*.jpg", SearchOption.AllDirectories);
            blueTextures.AddRange(ListFiles);
            ListFiles = Directory
                                .GetFiles(string.Format("textures\\tasks\\{0}\\b", this.sceneSubtype), "*.png", SearchOption.AllDirectories);
            blueTextures.AddRange(ListFiles);
        }

        if (patternTextures.Count == 0)
        {
            patternTextures.Clear();
            var ListFiles = Directory
                            .GetFiles(string.Format("textures\\patterns\\{0}", this.sceneSubtype), "*.bmp", SearchOption.AllDirectories);
            patternTextures.AddRange(ListFiles);
            ListFiles = Directory
                                .GetFiles(string.Format("textures\\patterns\\{0}", this.sceneSubtype), "*.jpg", SearchOption.AllDirectories);
            patternTextures.AddRange(ListFiles);
            ListFiles = Directory
                                .GetFiles(string.Format("textures\\patterns\\{0}", this.sceneSubtype), "*.png", SearchOption.AllDirectories);
            patternTextures.AddRange(ListFiles);
        }
        redTextures.Sort();
        blueTextures.Sort();
    }

    public void LoadFile(string fileName)
    {
        if (innerData != null)
        {
            return;
        }

        try
        {
            innerData = InnerData.Read(fileName);

            this.sceneNumber = 0;

            this.backColor = new Color(innerData.bg[0] / 255.0f, innerData.bg[1] / 255.0f, innerData.bg[2] / 255.0f);
            this.mixColor = new Color(innerData.red[0] / 255.0f, innerData.red[1] / 255.0f, innerData.red[2] / 255.0f);
            this.moveColor = new Color(innerData.blue[0] / 255.0f, innerData.blue[1] / 255.0f, innerData.blue[2] / 255.0f);

            this.userScore = 0;

            this.userHits = innerData.showTimes;
            //this.userMisses = innerData.missChange;
            this.userTime = 0;

            this.objectScale = innerData.koef / 100.0f;

            this.scoreAddition = innerData.balls;

            this.accuracyBonus = innerData.bonusAcc / 100;
            this.sizeBonus = innerData.bonusSize / 100;
            this.dynamicsBonus = innerData.bonusDin / 100;

            this.horizontalTreshold = innerData.horDev / 100.0f;
            this.verticalTreshold = innerData.vertDev / 100.0f;
        }
        catch (Exception e)
        {
            Debug.Log(e.Message);
            return;
        }
    }

    public OuterData GetOuterData()
    {
        OuterData outerData = new OuterData();
        
        outerData.patientName = innerData.patientName;
        
        outerData.sessionDate = DateTime.Today;
        outerData.sessionLength = (int)this.userTime;
        outerData.sessionType = innerData.sessionType;

        outerData.hits = this.sUserHits;
        outerData.miss = this.sUserMisses;

        outerData.fromMonitor = innerData.fromMonitor;

        outerData.balls = this.userScore;

        outerData.horDev = this.horizontalDiff;
        outerData.horDevDin = this.horizontalDiffDin;

        outerData.verDev = this.verticalDiff;
        outerData.verDevDin = this.verticalDiffDin;

        return outerData;
    }
}
