using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flicker : MonoBehaviour
{
    float t;
    Light lt;

    // Start is called before the first frame update
    void Start()
    {
        lt = GetComponent<Light>();
        lt.color = Color.yellow;
        t = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t > 1f){
            lt.enabled = !lt.enabled;
            t = t - 1f;
        }
    }
}
