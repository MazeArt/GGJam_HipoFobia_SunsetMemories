using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateTextAtLine : MonoBehaviour
{
    public TextAsset theText;
    
    public int startLine;
    public int endLine;
    
    public TextBoxManager theTextBox;
    public bool destroyWhenActivated;

    public KeyCode interactKey;
    public bool isInRangeDialog;

    // Start is called before the first frame update
    void Start()
    {
        theTextBox = FindObjectOfType<TextBoxManager>();
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(interactKey)){ 
            if(isInRangeDialog){
                load_dialog();
            }
         //   Debug.Log("Tecla Presionada"); // And Player presses key
         //   Debug.Log("isInRangeDialog");
        }
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "MC")
        {
            isInRangeDialog = true;
        } 
        
        //    if (destroyWhenActivated)
        //    {
               // Destroy(gameObject);
        //    }
        

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.name == "MC"){
            isInRangeDialog = false;
            //Debug.Log("Player not in range");
        }
    }

    void load_dialog(){

                theTextBox.ReloadScript(theText);
                theTextBox.currentLine = startLine;
                theTextBox.endAtLine = endLine;
                theTextBox.EnableTextBox(); 

    }
}


