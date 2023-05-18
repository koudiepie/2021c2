using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioPlay : MonoBehaviour
{
    private AudioSource audiosource;
    float adjfactor = 1.1f;
    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        audiosource.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
            audiosource.volume *= adjfactor;
        if (Input.GetKeyDown(KeyCode.DownArrow))
            audiosource.volume /= adjfactor;
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            audiosource.pitch /= adjfactor;
        if (Input.GetKeyDown(KeyCode.RightArrow))
            audiosource.pitch *= adjfactor;
    }

    private void OnMouseDown(){
        if (audiosource.isPlaying)
            audiosource.Pause();
        else
            audiosource.Play();
    }
}
