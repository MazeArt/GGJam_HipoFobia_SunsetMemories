using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character2dController : MonoBehaviour
{
    
    public float MovementSpeed = 1;
    public string facing = "right";
    public string previousFacing;

    private void Awake()
    {
        previousFacing = facing;
    }

    private Animator animator;


    
    void Start(){

        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement,0,0) * Time.deltaTime * MovementSpeed;
        
        Vector2 move = Vector2.zero;
        move.x = Input.GetAxis("Horizontal");
        // call function
        DetermineFacing(move);

    }
    void DetermineFacing(Vector2 move)
    {
        if (move.x < -0.01f)
        {
            facing = "left";
            animator.SetBool("estaCaminando",true);

        }
        else if (move.x > 0.01f)
        {
            facing = "right";
            animator.SetBool("estaCaminando",true);
        }
        else {
            animator.SetBool("estaCaminando",false);

        }
        // if there is a change in direction
        if (previousFacing != facing)
        {
            // update direction
            previousFacing = facing;
            // change transform
            gameObject.transform.Rotate(0, 180, 0);
        }
}






}