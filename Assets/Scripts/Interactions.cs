using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;




public class Interactions : MonoBehaviour
{
    public bool isInRange;
    public KeyCode interactKey;
    public UnityEvent interactAction;
    


    // Update is called once per frame
    void Update()
    {
        if(isInRange){ // if in Range
            if(Input.GetKeyDown(interactKey)){  // And Player presses key
                interactAction.Invoke(); //Fire Event
      
            }

        }

    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.CompareTag("Player")){
            isInRange = true;
          //  Debug.Log("Player now in range");
        }
       
    }

    private void OnTriggerExit2D(Collider2D collision){
        if(collision.gameObject.CompareTag("Player")){
            isInRange = false;
            //Debug.Log("Player not in range");
        }
    }


}

 