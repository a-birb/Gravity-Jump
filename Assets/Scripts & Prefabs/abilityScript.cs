using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abilityScript : MonoBehaviour {

    Rigidbody2D r;
    float t;
    float jumpcd;
    float firecd;
    float fxcd;
    float hp;
    public float jumpspd;
    public int jumpKey = 1;
    public int fireKey = 0;
    public GameObject bullet;
    public GameObject bulletfx;
    public GameObject jumpfx;
    public float player_pos_x;
    public float player_pos_y;

    void Start() {
        jumpcd = Time.time;
        firecd = Time.time;
        r = GetComponent<Rigidbody2D>();

    }
    
    void Update() {

        Jump();
        Fire();
        player_pos_x = transform.position.x;
        player_pos_y = transform.position.y;
        if(hp < 1) {
            Death();
        }

    }

    void Jump() {
        if(Input.GetMouseButtonDown(jumpKey) == true && jumpcd <= Time.time) {
            jumpcd = Time.time + 1f;
            r.AddRelativeForce(new Vector2(jumpspd,0));
            //Create 15 instances of FX one after the other
            //JumpFX();
        }
    }

    void Fire() {
        if(Input.GetMouseButton(fireKey) == true && firecd <= Time.time) {
            firecd = Time.time + 0.08f;
            GameObject.Instantiate(bullet, transform.position, transform.rotation);
            Instantiate(bulletfx,transform.position,Random.rotation);
        }
    }

    void Death() {
        
    }
}

 
