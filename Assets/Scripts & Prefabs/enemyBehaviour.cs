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
    Rigidbody2D r;
    void Start()
    {
        r = GetComponent<Rigidbody2D>();
        if(enemyType == "basic") {
            hp = 25;
            dist = 20;
        }
    }

    // Update is called once per frame
    void Update()
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
                        Vector3 dir = Quaternion.AngleAxis(angle, Vector3.forward) * Vector3.right;
                        r.AddForce(-dir * (750 / Vector2.Distance(self.position, target.position)));
                    } else {
                        Vector3 dir = Quaternion.AngleAxis(angle, Vector3.forward) * Vector3.right;
                        r.AddForce(dir * (Vector2.Distance(self.position, target.position) / 4000));
                    }
                }
                
                angle = (Mathf.Atan2(player.transform.position.y - transform.position.y, player.transform.position.x - transform.position.x) * Mathf.Rad2Deg);
                transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, angle),8f * Time.deltaTime);
            } else {
                Destroy(self_object);
            }
        }
    }

    void OnCollisionEnter(Collision col) {
        if(col.gameObject.tag=="bullet") {
            hp -= 1;
        }
        if(col.gameObject.tag=="Planet") {
            hp -= 999;
        }
    }
}
