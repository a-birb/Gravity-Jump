using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationBehaviour : MonoBehaviour
{
    Vector3 mousePositionInWorld;
    float angle;
    float speed = 8f;
 
    void Update() {
         mousePositionInWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
         angle = (Mathf.Atan2(mousePositionInWorld.y - transform.position.y, mousePositionInWorld.x - transform.position.x) * Mathf.Rad2Deg);
         transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, angle),speed * Time.deltaTime);
    }
}
