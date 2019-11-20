using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBehaviour : MonoBehaviour
{
    public float enemies;
    public GameObject enemy;
    float spawncd;
    public float cooldown;

    void Update()
    {
        if(enemies < 5) {
            if(spawncd <= Time.time) {
                Instantiate(enemy,gameObject.transform.position,gameObject.transform.rotation);
                spawncd = Time.time + cooldown;
                enemies += 1;
            }
        }
    }
}
