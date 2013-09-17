using UnityEngine;
using System.Collections;

public class bInteractiveGO : bTexturedGO
{
    public bool enableBlink;
    public float blinkStartTime;
    public float blinkTime;
    float currentBlinkTime;

    public Vector2 scale = Vector2.one;

    public Vector3 rotation = Vector4.zero;

    public void SetScale()
    {
        this.gameObject.transform.localScale = this.scale;
    }

    public void Rotate()
    {
        this.gameObject.transform.Rotate(this.rotation);
    }

    public void Blink(float time)
    {
        if (this.enableBlink)
        {
            if (this.blinkStartTime > 0)
            {
                this.blinkStartTime -= time;
            }
            else
            {
                this.currentBlinkTime += time;

                if (this.currentBlinkTime >= this.blinkTime)
                {
                    this.Enable(!this.objectEnabled);

                    this.currentBlinkTime = 0;
                }
            }
        }
    }

    new protected void Start()
    {
        base.Start();
        
        SetScale();
    }

    new protected void LateUpdate()
    {
        base.LateUpdate();
        Rotate();
        Blink(Time.deltaTime);
    }
}
