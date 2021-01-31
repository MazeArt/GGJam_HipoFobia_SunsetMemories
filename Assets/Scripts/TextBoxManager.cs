using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextBoxManager : MonoBehaviour
{
    public GameObject textBox;

    public Text theText;

    public TextAsset textFile;
    public string[] textLines;

    public int currentLine;
    public int endAtLine;
    
    public Character2dController player;

    public bool isActive;

    // Start is called before the first frame update
    void Start()
    {
       // player = FindeObjectOfType<Character2dController>();

        if(textFile != null)
        {
            textLines = (textFile.text.Split('\n'));

        }

        if(endAtLine == 0)
        {
            endAtLine = textLines.Length - 1;
        }

        
        if(isActive)
        {
            EnableTextBox();
        } else {
            DisableTextBox();
        }
    
    }

    void Update()
    {
        if(!isActive)
        {
            return;
        }


        theText.text = textLines[currentLine];
        if(Input.GetKeyDown(KeyCode.Return))
        {
            currentLine +=1;
        }

        if(currentLine > endAtLine)
        {
            DisableTextBox();
        }
    }
    
    public void EnableTextBox()
    {
        textBox.SetActive(true);
        isActive = true;
    }
    
    public void DisableTextBox()
    {
        textBox.SetActive(false);
        isActive = false;
    }

    public void ReloadScript(TextAsset theText)
    {
        if(theText != null)
        {
            textLines = new string[1];
            textLines = (theText.text.Split('\n'));
        }
    }

}

