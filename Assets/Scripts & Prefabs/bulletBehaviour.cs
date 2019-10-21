using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletBehaviour : MonoBehaviour
{
    Rigidbody2D r;
    void Start()
    {
        r = GetComponent<Rigidbody2D>();
        r.AddRelativeForce(new Vector2(3000,0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
