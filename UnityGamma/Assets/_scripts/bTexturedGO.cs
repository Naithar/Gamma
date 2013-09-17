using UnityEngine;
using System.Collections;

public class bTexturedGO : MonoBehaviour
{
    public bool objectEnabled = true;
    public bool hasChildren;

    public Texture2D baseTexture;
    public string texturePath;
    public bool externalPath;

    public Material[] materials;

    public Color textureColor;
    public string colorName = "_Color";
    public float colorAlpha;

    protected void SetBaseTexture()
    {
        if (this.materials.Length != 0)
        {
            foreach (Material material in this.materials)
            {
                material.mainTexture = this.baseTexture;
            }
        }
    }

    public void SetTexture()
    {
        if (this.texturePath != string.Empty)
        {
            try
            {
                WWW loader;
            
                if (!this.externalPath)
                {
                    loader = new WWW("file://" + Application.dataPath + "/" + this.texturePath);
                }
                else
                {
                    loader = new WWW("file://" + this.texturePath);
                }

                loader.texture.anisoLevel = 7;

                if (this.materials.Length != 0)
                {
                    foreach (Material material in this.materials)
                    {
                        material.mainTexture = loader.texture;
                    }
                }
            }
            catch
            {
                SetBaseTexture();
            }
        }
        else
        {
            SetBaseTexture();
        }
    }

    public void SetColor()
    {
        this.textureColor.a = this.colorAlpha;

        if (this.materials.Length != 0)
        {
            foreach (Material material in this.materials)
            {
                material.SetColor(this.colorName, this.textureColor);
            }
        }
    }

    public void Enable(bool value)
    {
        this.objectEnabled = value;
        if (hasChildren)
        {
            foreach (Renderer renderer in this.GetComponentsInChildren<MeshRenderer>())
            {
                renderer.enabled = value;
            }
        }
        else
        {
            if (this.renderer != null)
            {
                this.renderer.enabled = value;
            }
        }
    }

    protected void Start()
    {
        SetTexture();
        SetColor();
        Enable(this.objectEnabled);
    }

    protected void LateUpdate()
    {
        SetTexture();
        SetColor();
    }
}
