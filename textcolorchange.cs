using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textcolorchange : MonoBehaviour
{
    float duration = 1.0f;
    Color c1 = Color.red;
    Color c2 = Color.blue;
    Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        float t = Mathf.PingPong(Time.time, duration)/duration;
        text.color = Color.Lerp(c1, c2, t);
    }
}
