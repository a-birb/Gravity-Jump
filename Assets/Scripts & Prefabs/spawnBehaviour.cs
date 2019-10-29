using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBehaviour : MonoBehaviour
{
    float enemies;
    public GameObject enemy;
    public float spawncd;

    void Update()
    {
        if(enemies < 10) {
            if(spawncd <= Time.time) {
                Instantiate(enemy,gameObject.transform.position,gameObject.transform.rotation);
                spawncd = Time.time + 3f;
            }
        }
    }

    void Spawn() {
        enemies += 1;
        Instantiate(enemy,gameObject.transform.position,gameObject.transform.rotation);
        return;
    }
}
