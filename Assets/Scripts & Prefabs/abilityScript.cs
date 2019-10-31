using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abilityScript : MonoBehaviour {

    Rigidbody2D r;
    float jumpcd;
    float firecd;
    public float jumpspd;
    public int jumpKey = 1;
    public int fireKey = 0;
    public GameObject bullet;
    public GameObject bulletfx;
    public GameObject jumpfx;

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
            r.AddRelativeForce(new Vector2(jumpspd,0));
            Instantiate(jumpfx,transform.position,new Quaternion(transform.rotation.x,transform.rotation.y,transform.rotation.z,1));
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

 
