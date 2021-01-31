using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character2dController : MonoBehaviour
{
    
    public float MovementSpeed = 1;
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement,0,0) * Time.deltaTime * MovementSpeed;
    // flip the character
        Vector3 characterScale = transform.localScale;
        if(Input.GetAxis("Horizontal") < 0){
            characterScale.x = -10;
        }
        if(Input.GetAxis("Horizontal") < 0){
            characterScale.x = 10;
        }
        transform.localScale = characterScale;
    
    
    }
}
