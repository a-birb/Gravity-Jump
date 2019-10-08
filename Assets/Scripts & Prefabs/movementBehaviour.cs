using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementBehaviour : MonoBehaviour
{
    public bool isPlayer;
    float forceCharge;
    Rigidbody2D r;

    void Start() //Function is called before first frame
    {
        r = GetComponent<Rigidbody2D>();
        forceCharge = 0;
    }

    void Update()
    {
        if(isPlayer == true) {
            float force = Mathf.RoundToInt(Input.GetAxis("Vertical"));

            if(force == 1f) {

            }
        }
    }
}
