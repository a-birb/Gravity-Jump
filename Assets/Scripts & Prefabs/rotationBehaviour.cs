using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationBehaviour : MonoBehaviour
{
 Vector2 mouse_pos;
 public Transform target; //Assign to the object you want to rotate
 Vector2 object_pos;
 float angle;
 
 void Update() {

     transform.Rotate(0,0,1);
     transform.Rotate(0,0,-1);
     mouse_pos = Input.mousePosition;
     object_pos = Camera.main.WorldToScreenPoint(target.position);
     mouse_pos.x = mouse_pos.x - object_pos.x;
     mouse_pos.y = mouse_pos.y - object_pos.y;
     angle = Mathf.Atan2(mouse_pos.y, mouse_pos.x) * Mathf.Rad2Deg;
     transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

    }
}
