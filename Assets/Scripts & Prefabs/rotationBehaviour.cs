using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationBehaviour : MonoBehaviour
{
    Rigidbody2D r;
 
 void Update() {

        /*r = GetComponent<Rigidbody2D>();
        Vector2 positionOnScreen = Camera.main.WorldToViewportPoint (transform.position);
        Vector2 mouseOnScreen = (Vector2)Camera.main.ScreenToViewportPoint(Input.mousePosition);
        float angle = AngleBetweenTwoPoints(positionOnScreen, mouseOnScreen);
        float relativeAngle = transform.rotation.z - angle;

        if(relativeAngle > transform.rotation.z) {
            transform.Rotate(new Vector3(0,0,10),Space.Self);
        }
        if(relativeAngle < transform.rotation.z) {
            transform.Rotate(new Vector3(0,0,-10),Space.Self);
        }

     }
 
        float AngleBetweenTwoPoints(Vector3 a, Vector3 b) {
        return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;*/

        Vector2 angleVector = Input.mousePosition - transform.position;
    }
}
