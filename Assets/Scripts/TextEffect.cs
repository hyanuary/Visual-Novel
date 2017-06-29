using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextEffect : MonoBehaviour
{
    DialogueParser parser;
    public float letterSpeed = 0.2f;
    public int lineNum;

    string dialogue;
    public Text dialogueBox;

    // Use this for initialization
    void Start()
    {
        dialogue = dialogueBox.text;
        StartCoroutine(TypeText());

    }

    IEnumerator TypeText()
    {
        foreach (char letter in dialogue.ToCharArray())
        {
            dialogueBox.text += letter;

            yield return new WaitForSeconds(letterSpeed);
        }
    }

    void Update()
    {
        
    }

}
