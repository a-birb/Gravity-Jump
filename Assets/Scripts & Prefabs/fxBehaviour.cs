using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fxBehaviour : MonoBehaviour
{
    public GameObject obj;
    float timeToFade = 1f;
    float deathtimer;
    Color alphaColor;
    // Start is called before the first frame update
    void Start()
    {
        alphaColor = obj.GetComponent<SpriteRenderer>().color;
        alphaColor.a = 0;
        deathtimer = Time.time + 2f;

    }

    // Update is called once per frame
    void Update()
    {
        obj.GetComponent<SpriteRenderer>().color = Color.Lerp(obj.GetComponent<SpriteRenderer>().color, alphaColor, timeToFade * Time.deltaTime);
        if(Time.time > deathtimer) {
            Destroy(obj);
        }
    }
}
