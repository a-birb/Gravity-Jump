using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wrapBehaviour : MonoBehaviour
{
    public Transform o;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(o.position.x >= 26.75f) {
            o.Translate(-53.5f,0,0, Space.World);
        }
        if(o.position.x <= -26.75f) {
            o.Translate(53.5f,0,0, Space.World);
        }

        if(o.position.y >= 15) {
            o.Translate(0,-28.5f,0, Space.World);
        }
        if(o.position.y <= -15) {
            o.Translate(0,28.5f,0, Space.World);
        }
    }
}
