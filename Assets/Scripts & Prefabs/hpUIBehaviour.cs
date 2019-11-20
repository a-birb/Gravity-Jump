using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hpUIBehaviour : MonoBehaviour
{
    abilityScript a;
    public GameObject target;
    UnityEngine.UI.Text t;
    // Start is called before the first frame update
    void Start()
    {
        t = GetComponent<UnityEngine.UI.Text>();
        a = target.GetComponent<abilityScript>();
    }

    // Update is called once per frame
    void Update()
    {
        t.text = System.Convert.ToString(a.hp);
    }
}
