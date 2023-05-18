using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dark : MonoBehaviour
{
    Light lt;
    // Start is called before the first frame update
    void Start()
    {
        lt = GetComponent<Light>();
        lt.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        lt.intensity *= 0.992f;
    }
}
