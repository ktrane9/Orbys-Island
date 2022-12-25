using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orb : MonoBehaviour {
    public static Orb Spawn;
    private Vector2 movement;
    public float speed;
    public bool isFire, isIce, isZap;
    public bool kicked = false;

    void Awake() {
        Spawn = this;
    }

    void Start() {
       gameObject.name = OrbTracker.Tracker.getName();
       Debug.Log("This object is called " + gameObject.name);
    }

    void Update() {
        if(kicked == true) kick();
        
    }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Player") push();
    }

    private void push() {
        if(Input.GetKey("right") || Input.GetKey("left")) {
            movement = new Vector2(0,0);
            movement.x = Input.GetAxis("Horizontal");
            transform.Translate(movement * speed * Time.deltaTime);
        }

        if(Input.GetKey("up") || Input.GetKey("down")) {
            movement = new Vector2(0,0);
            movement.y = Input.GetAxis("Vertical");
            transform.Translate(movement * speed * Time.deltaTime);
        }
    }

    public void kick() {
        transform.Translate(movement * speed * Time.deltaTime);
    }

    public void setKick() {
        if(kicked == false) kicked = true;
    }
}
