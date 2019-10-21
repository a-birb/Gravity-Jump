﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abilityScript : MonoBehaviour {

    Rigidbody2D r;
    float jumpcd;
    float firecd;
    public int jumpKey = 1;
    public int fireKey = 0;

    void Start() {
        jumpcd = Time.time;
        firecd = Time.time;
        r = GetComponent<Rigidbody2D>();

    }
    
    void Update() {

        Jump();
        Fire();

    }

    void Jump() {
        if(Input.GetMouseButtonDown(jumpKey) == true && jumpcd <= Time.time) {
            jumpcd = Time.time + 1f;
            r.AddRelativeForce(new Vector2(8000f,0));
        }
    }

    void Fire() {
        if(Input.GetMouseButton(fireKey) == true && firecd <= Time.time) {
            firecd = Time.time + 0.08f;
            GameObject.Instantiate();
        }
    }
}

 
