using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletBehaviour : MonoBehaviour
{
    Rigidbody2D r;
    void Start()
    {
        transform.Translate(new Vector2(0.75f,0), Space.Self);
        r = GetComponent<Rigidbody2D>();
        r.AddRelativeForce(new Vector2(2000,0));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col) {
        if(col.gameObject.tag=="Planet") {
            Destroy(gameObject);
        }
        if(col.gameObject.GetComponent<enemyBehaviour>() != null) {
            Destroy(gameObject);
        }
    }
}
