using UnityEngine;
using System.Collections;

public class backGO : bTexturedGO
{
    public Vector2 scale = Vector2.one;

    public void SetScale()
    {
        this.gameObject.transform.localScale = this.scale;
    }

	new void Start ()
    {
        base.Start();

        SetScale();
	}

    public void SetRotation(Quaternion angle)
    {
        this.gameObject.transform.rotation = angle;
    }

    public void SetBlink(bool blink)
    {
        foreach (Renderer renderer in this.GetComponentsInChildren<MeshRenderer>())
        {
            renderer.enabled = blink;
        }
    }
}
