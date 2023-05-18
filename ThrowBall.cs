using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowBall : MonoBehaviour
{
    public GameObject ballPrefab;
    public float duration = 10f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            GameObject b = Instantiate(ballPrefab, new Vector3(0, 5, 0), Quaternion.identity);
            Destroy(b, 3f);
        }
    }
}
