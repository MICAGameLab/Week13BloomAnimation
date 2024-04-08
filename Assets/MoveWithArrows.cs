using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;


public class MoveWithArrows : MonoBehaviour
{
    public bool ActiveObject;
    public GameObject myParent;
    public Rigidbody2D myRb2D;
    public float Speed = 10;
    public Animator myAnimator;
    public SpriteRenderer mySR;
    public bool FacingLeftDirection;

    public void Start()
    {
        myRb2D = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
        mySR = GetComponent<SpriteRenderer>();
    }


    // When clicked on, toggles whether bool is t/f
    public void OnMouseDown() 
    {
        ActiveObject = !ActiveObject; 
    }


    // Update is called once per frame
    void Update()
    {
        if(ActiveObject)
        {
           HandleMovement();
        }

    }

    // Move Triangles using physics and start animation
    public void HandleMovement()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // push left
            myRb2D.AddForce(Vector2.left * Speed);
            // Set bools for animator
            myAnimator.SetBool("MovingLeft", true);
            // if moving left, we should face left
            if(FacingLeftDirection == false)
            {
                FacingLeftDirection = true;
                mySR.flipX = true;
            }
    
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            // push right 
            myRb2D.AddForce(Vector2.right * Speed);
            // Set bools for animator transitions
            myAnimator.SetBool("MovingLeft", false);
            // if moving right, we should face left
            if(FacingLeftDirection == true)
            {
                FacingLeftDirection = false;
                mySR.flipX = false;
            }
            
        }

        else
        {
            print("Neither arrow key pressed");
        }


    }

    // Turn Red when we start animating
    public void AnimateMovement()
    {


        if(GetComponent<SpriteRenderer>().color == Color.white)
        {
            GetComponent<SpriteRenderer>().color =Color.red;
        }

        
    }
}


