using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Tilemaps;

public class PlayerScript : MonoBehaviour {
    private Animator animator;
    private Vector2 movement;
    //private Rigidbody2D body;
    public float speed;

    void Start() {
        //body = GetComponent<Rigidbody2D>();
    
        
    }

    // Update is called once per frame
    void Update() {
        move();
        
    }

    private void move() {
        movement = new Vector2(0,0);
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

        if(Input.GetKey("down")) {
          //animator.SetInteger("Motion", walk_down); //Play Walk Down Animation
            transform.Translate(movement * speed * Time.deltaTime);
        }

        else if(Input.GetKey("up")) {
          //animator.SetInteger("Motion", walk_up); //Play Walk Up Animation
            transform.Translate(movement * speed * Time.deltaTime);
        }
        
        else if(Input.GetKey("right")) {
        //   if(facingRight == true) {
        //     facingRight = false;
        //     transform.Rotate(new Vector2(0, 180));
        //   }
        //   animator.SetInteger("Motion", walk_side); //Play Walk Side Animation
            transform.Translate(movement * speed * Time.deltaTime);
        }

        else if(Input.GetKey("left")) {
        //   if(facingRight == false) {
        //     facingRight = true;
        //     transform.Rotate(new Vector2(0, 180));
        //   }
        //   animator.SetInteger("Motion", walk_side); //Play Walk Side Animation Flipped
            transform.Translate(movement * speed * Time.deltaTime);
        }

        // else {
        //   animator.SetInteger("Motion", idle); //Play Idle Animation
        // }
    }
}
