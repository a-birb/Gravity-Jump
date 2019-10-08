using UnityEngine;
using System.Collections.Generic;
using System.Collections;
 
[RequireComponent(typeof(Rigidbody2D))]
public class gravityBehaviour : MonoBehaviour {
 
    public float maxDistance;
    public float startingMass;
    public Vector2 initialVelocity;
    Rigidbody2D r;
 
    //I use a static list of bodies so that we don't need to Find them every frame
    static List<Rigidbody2D> attractableBodies = new List<Rigidbody2D>();
 
    void Start() {
        r = GetComponent<Rigidbody2D>();
        SetupRigidbody2D();
        //Add this gravitational body to the list, so that all other gravitational bodies can be effected by it
        attractableBodies.Add (r);
 
    }
 
    void SetupRigidbody2D() {
 
        r.gravityScale = 0f;
        r.drag = 0f;
        r.angularDrag = 0f;
        r.mass = startingMass;
        r.velocity = initialVelocity;
 
    }
 
    void FixedUpdate() {
 
        foreach (Rigidbody2D otherBody in attractableBodies) {
 
            if (otherBody == null)
                continue;
 
            //We arn't going to add a gravitational pull to our own body
            if (otherBody == r)
                continue;
 
            otherBody.AddForce(DetermineGravitationalForce(otherBody));
 
        }
 
    }
 
    Vector2 DetermineGravitationalForce(Rigidbody2D otherBody) {
 
        Vector2 relativePosition = r.position - otherBody.position;
   
        float distance = Mathf.Clamp (relativePosition.magnitude, 0, maxDistance);
 
        //the force of gravity will reduce by the distance squared
        float gravityFactor = 1f - (Mathf.Sqrt(distance) / Mathf.Sqrt(maxDistance));
 
        //creates a vector that will force the otherbody toward this body, using the gravity factor times the mass of this body as the magnitude
        Vector2 gravitationalForce = relativePosition.normalized * (gravityFactor * r.mass);
 
        return gravitationalForce;
       
    }
   
}
 
