using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Tilemaps;

public class PlayerScript : MonoBehaviour {
    [SerializeField] GameObject orb;

    private Animator animator;
    private Vector2 movement;
    //private Rigidbody2D body;
    public float speed;
    public Vector3 lastDirection;

    void Start() {
        //body = GetComponent<Rigidbody2D>();
        lastDirection = -transform.up;
    
    }

    void Update() { //Processing Inputs
        move();
        attack();
        
    }

    void FixedUpdate() { //Physics Calculations

    }

    private void move() {
        movement = new Vector2(0,0);
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

        if(Input.GetKey("down")) {
          //animator.SetInteger("Motion", walk_down); //Play Walk Down Animation
            transform.Translate(movement * speed * Time.deltaTime);
            lastDirection = -transform.up;
        }

        else if(Input.GetKey("up")) {
          //animator.SetInteger("Motion", walk_up); //Play Walk Up Animation
            transform.Translate(movement * speed * Time.deltaTime);
            lastDirection = transform.up;
        }
        
        else if(Input.GetKey("right")) {
        //   if(facingRight == true) {
        //     facingRight = false;
        //     transform.Rotate(new Vector2(0, 180));
        //   }
        //   animator.SetInteger("Motion", walk_side); //Play Walk Side Animation
            transform.Translate(movement * speed * Time.deltaTime);
            lastDirection = transform.right;
        }

        else if(Input.GetKey("left")) {
        //   if(facingRight == false) {
        //     facingRight = true;
        //     transform.Rotate(new Vector2(0, 180));
        //   }
        //   animator.SetInteger("Motion", walk_side); //Play Walk Side Animation Flipped
            transform.Translate(movement * speed * Time.deltaTime);
            lastDirection = -transform.right;
        }

        // else {
        //   animator.SetInteger("Motion", idle); //Play Idle Animation
        // }
    }

    private void attack() {
         if (Input.GetKeyDown("space")) {
            float spawnDis = 1.0f;
            Vector2 spawnPos = transform.position + (lastDirection * spawnDis);
            if(OrbTracker.Tracker.check_amount() == true) {
                OrbTracker.Tracker.deleteOldest();
                Instantiate(orb, spawnPos, Quaternion.identity);
            }
            else Instantiate(orb, spawnPos, Quaternion.identity);
           
        }
    }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Orb") {
            if(Input.GetKey("z")) Orb.Spawn.setKick();
        }
    }
}
