using UnityEngine;
using System.Collections;

public class backgroundGO : bTexturedGO
{
    public Color backgroundColor;

    public Vector2 textureScale;
    public Vector2 textureOffset;

    public bTexturedGO staticDot;

    public void SetBackgroundColor()
    {
        Camera.mainCamera.backgroundColor = this.backgroundColor;
    }

    public void SetScale()
    {
        if (this.materials.Length != 0)
        {
            foreach (Material material in this.materials)
            {
                material.mainTextureScale = this.textureScale;
            }
        }
    }

    public void Offset(float deltaTime)
    {
        //if (this.enablePattern)
        {
            if (this.materials.Length != 0)
            {
                foreach (Material material in this.materials)
                {
                    Vector2 currentOffset = material.mainTextureOffset;

                    material.mainTextureOffset = 
                       new Vector2((currentOffset.x + this.textureOffset.x * deltaTime * 50) % 1.0f,
                            (currentOffset.y + this.textureOffset.y * deltaTime * 50) % 1.0f);
                }
            }
        }
    }

	new void Start ()
    {
        base.Start();

        foreach (Material material in this.materials)
        {
            material.mainTextureOffset = new Vector2(0, 0);
        }

        SetScale();
        SetBackgroundColor();

        this.staticDot.Enable(this.objectEnabled);

        this.staticDot.transform.position = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 85));
	}
	
	new protected void LateUpdate()
    {
       // this.gameObject.renderer.enabled = this.enablePattern;
    //    Offset(Time.deltaTime);

        //this.staticDot.textureColor = this.textureColor;
	}
}

