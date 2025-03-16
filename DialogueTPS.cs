using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Dialogue : MonoBehaviour
{

    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float TypingSpeed;


    void Start()
    {
        StartCoroutine(type());
    }


    IEnumerator type()
    {
        foreach(char letter  in sentences[index].ToCharArray()){
            textDisplay.text += letter;
            yield return new WaitForSeconds(0.02f);


        }
    }

    public void NextSentence()
    {

        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text == "";
            StartCoroutine(type());
        }
        else
        {
            textDisplay.text == "";
        }
    }
}
