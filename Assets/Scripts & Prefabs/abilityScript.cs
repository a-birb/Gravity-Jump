using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abilityScript : MonoBehaviour {

    Rigidbody2D r;
    float jumpcd;

    void Start() {
        jumpcd = Time.time;
        r = GetComponent<Rigidbody2D>();

    }
    
    void Update() {

        if(Input.GetMouseButton(0) == true || jumpcd <= Time.time); {
            jumpcd = Time.time + 0.75f;
            r.AddRelativeForce(new Vector2(800f,0));
        }

    }
}

 
