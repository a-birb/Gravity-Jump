using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abilityScript : MonoBehaviour {

    Rigidbody2D r;
    float t;
    float jumpcd;
    float firecd;
    float railguncd;
    float fxcd;
    public float hp;
    public float jumpspd;
    public int jumpKey = 1;
    public int fireKey = 0;
    public int railgunKey = 2;
    public GameObject bullet;
    public GameObject bulletfx;
    public GameObject jumpfx;
    public GameObject railbolt;
    public float player_pos_x;
    public float player_pos_y;

    void Start() {
        hp = 5;
        jumpcd = Time.time;
        firecd = Time.time;
        r = GetComponent<Rigidbody2D>();

    }
    
    void Update() {

        Jump();
        Fire();
        Railgun();
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
        }
    }

    void Fire() {
        if(Input.GetMouseButton(fireKey) == true && firecd <= Time.time) {
            firecd = Time.time + 0.08f;
            GameObject.Instantiate(bullet, transform.position, transform.rotation);
            Instantiate(bulletfx,transform.position,transform.rotation);
        }
    }

    void Railgun() {
        if(Input.GetMouseButton(railgunKey) == true && railguncd <= Time.time) {
            railguncd = Time.time + 1.5f;
            GameObject.Instantiate(railbolt, transform.position, transform.rotation);
        }
    }

    void Death() {
        Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D col) {
        if(col.gameObject.tag == "enemybullet") {
            hp -= 1;
        }
    }
}

 
