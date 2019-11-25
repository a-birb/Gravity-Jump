using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletBehaviour : MonoBehaviour
{
    Rigidbody2D r;
    public float speed;
    public bool pierce;
    public bool fx;
    void Start()
    {
        transform.Translate(new Vector2(0.75f,0), Space.Self);
        r = GetComponent<Rigidbody2D>();
        r.AddRelativeForce(new Vector2(speed,0));
    }

    void OnCollisionEnter(Collision col) {
        if(col.gameObject.tag == "Planet") {
            Destroy(gameObject);
        }
        if(col.gameObject.GetComponent<enemyBehaviour>() == true && pierce == false) {
            Destroy(gameObject);
        }
    }
}
