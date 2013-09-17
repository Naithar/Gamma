using UnityEngine;
using System.Collections;

public class mixingGO : bInteractiveGO
{
    public backGO backObject;

    public float backOffset = 30;

    public void ConnectObject()
    {
        backObject.objectEnabled = this.objectEnabled;

        backObject.baseTexture = this.baseTexture;
        backObject.texturePath = this.texturePath;
        backObject.externalPath = this.externalPath;

        backObject.textureColor = Color.black;
        backObject.colorAlpha = 1;

        backObject.scale = this.scale;

        backObject.SetTexture();
        backObject.SetColor();
    }

    public void MoveObject()
    {
        backObject.gameObject.transform.position =
            new Vector3(this.transform.position.x,
                this.transform.position.y,
                this.transform.position.z + this.backOffset);
    }

    protected void Awake()
    { }

    new void Start()
    {
        this.colorName = "_TintColor";
        ConnectObject();
        base.Start();
        
    }

	new void LateUpdate ()
    {
        base.LateUpdate();
        ConnectObject();
        backObject.SetRotation(this.gameObject.transform.rotation);
        backObject.SetBlink(this.GetComponentInChildren<MeshRenderer>().enabled);
        MoveObject();
	}
}
