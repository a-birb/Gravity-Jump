using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementBehaviour : MonoBehaviour {
    public bool isPlayer;
    float forceCharge;
    Rigidbody2D r;

    void Start() { //Function is called before first frame
        r = GetComponent<Rigidbody2D>();
        forceCharge = 0;
    }

    void Update() {
        if(isPlayer == true) {
            if(Input.GetMouseButtonDown(0) == true) {
                forceCharge += 1000f;
                forceCharge *=0.95f;
            }else {
                r.AddRelativeForce(new Vector2(forceCharge,0) * 5);
                forceCharge = 0f;
            }
        }
    }

    void Jump() {

    }
}
