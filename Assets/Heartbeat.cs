using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heartbeat : MonoBehaviour {

    public Texture2D fadeOutTexture;
    public float fadeSpeed = 0.8f;

    private int drawDepth = -100;
    private float alpha = 1.0f;
    private int fadeDir = -1;

    public bool fading = true;

    IEnumerator FadingBack()
    {
        yield return new WaitForSeconds(1);
        fading = true;
    }

    void OnGUI()
    {
        if(fading)
        {
            alpha += fadeDir * fadeSpeed * Time.deltaTime;
            alpha = Mathf.Clamp01(alpha);

            GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, alpha);
            GUI.depth = drawDepth;
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), fadeOutTexture);
        }
        
    }

    public float BeginFade(int direction)
    {
        fadeDir = direction;
        return (fadeSpeed);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //BeginFade(1);
            //fading = false;
            //if(!fading)
            //{
            //    StartCoroutine(FadingBack());
            //}
        }
        //BeginFade(-1);
    }

}

