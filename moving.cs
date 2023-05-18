using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{
    public float speed = 10f;
    public float angspeed = 15f;

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal")*angspeed*Time.deltaTime;
        float v = Input.GetAxis("Vertical")*speed*Time.deltaTime;
        transform.position += transform.forward.normalized*v;
        transform.Rotate(0, h, 0);

    }
}
