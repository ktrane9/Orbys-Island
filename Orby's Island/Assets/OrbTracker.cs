using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbTracker : MonoBehaviour {
    public int limit = 1;
    public int num = 0;
    public int exist = 0;
    public int pointer = 0;
    public string[] names;

    public static OrbTracker Tracker;
    void Awake() {
        Tracker = this;
    }

    void Start() {
        names = new string[limit];
        
    }

    void Update() {
        
    }

    public bool check_amount() {
        bool max;

        if(exist >= limit) {
            max = true;
        }

        else max = false;

        return max;
    }

    public string getName() {
        string name = "Orb " + num;
        names[num] = name;
        num++;
        exist++;
        return name;
    }

    public void deleteOldest() {
        GameObject orb;
        if(pointer >= limit) pointer = 0;

        orb = GameObject.Find(names[pointer]);
        Destroy(orb.gameObject);
        exist--;
        num = pointer;
        pointer++;
    }
}
