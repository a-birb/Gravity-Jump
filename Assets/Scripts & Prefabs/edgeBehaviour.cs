using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class edgeBehaviour : MonoBehaviour
{
    public Transform o;
    public GameObject self;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(o.position.x >= 30) {
            Destroy(self);
        }
        if(o.position.x <= -30) {
            Destroy(self);
        }

        if(o.position.y >= 15) {
            Destroy(self);
        }
        if(o.position.y <= -15) {
            Destroy(self);
        }
    }
}
