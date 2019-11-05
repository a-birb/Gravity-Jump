using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBehaviour : MonoBehaviour
{
    public string enemyType;
    public int hp;
    float basecd = 1f;
    public Transform self;
    public GameObject self_object;
    float angle;
    float dist;
    Transform target;
    GameObject[] planets;
    public GameObject player;
    public GameObject hitfx;
    Vector2 player_pos;
    Rigidbody2D r;
    void Start()
    {
        r = GetComponent<Rigidbody2D>();
        if(enemyType == "basic") {
            hp = 25;
            dist = 15;
        }
    }

    // Update is called at 50hz
    void FixedUpdate()
    {   
        // Basic enemy type; Float around planets and shoot at player
        if(enemyType == "basic") {
            // Find Planets
            planets = GameObject.FindGameObjectsWithTag("Planet");
            
            if(hp > 0) {
                // For each gameobject labelled as "Planet", find distance/angle between yourself and it and apply a force if too close
                foreach(GameObject g in planets) {
                    target = g.GetComponent<Transform>();
                    angle = (Mathf.Atan2(target.position.y - transform.position.y, target.position.x - transform.position.x) * Mathf.Rad2Deg);
                
                    if(Vector2.Distance(self.position, target.position) < dist) {
                        Vector2 dir = Quaternion.AngleAxis(angle, Vector2.up) * Vector2.right;
                        r.AddForce(-dir * (2000 / Vector2.Distance(self.position, target.position)));
                    } else {
                        Vector2 dir = Quaternion.AngleAxis(angle, Vector2.up) * Vector2.right;
                        transform.position = Vector2.MoveTowards(transform.position,dir,0.1f);
                    }
                }
                // Rotate towards object designated 'Player'
                angle = (Mathf.Atan2(player_pos.y - transform.position.y, player_pos.x - transform.position.x) * Mathf.Rad2Deg);
                transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, angle),8f * Time.deltaTime);
            } else {
                Destroy(self_object);
                Destroy(GetComponent<enemyBehaviour>());
            }
        }
    }

    void Update() {
        player_pos = new Vector2(player.transform.position.x, player.transform.position.y);
        //Debug.LogWarning(player_pos);
    }

    void OnCollisionEnter2D(Collision2D col) {
        if(col.gameObject.tag=="bullet") {
            hp -= 1;
            Instantiate(hitfx,transform.position,Random.rotation);
        }
        if(col.gameObject.tag=="Planet") {
            hp -= 999;
        }
    }
}