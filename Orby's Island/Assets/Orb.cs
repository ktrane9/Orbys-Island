using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orb : MonoBehaviour {
    public static Orb Spawn;

    void Awake() {
        Spawn = this;
    }

    void Start() {
       gameObject.name = OrbTracker.Tracker.getName();
       Debug.Log("This object is called " + gameObject.name);
    }

    void Update() {
        
        
    }
}
