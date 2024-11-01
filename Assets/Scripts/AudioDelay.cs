using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioDelay : MonoBehaviour
{
    [SerializeField]
    private int delaytime;

    private void OnEnable()
    {
        Invoke("delay", delaytime);
    }

    private void OnDisable()
    {
        GetComponent<AudioSource>().enabled = false;
    }

    //To play audio with given delay time
    void delay()
    {
        GetComponent<AudioSource>().enabled = true;
    }
}
