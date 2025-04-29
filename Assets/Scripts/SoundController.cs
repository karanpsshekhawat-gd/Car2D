using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioSource takeOff, acceleration;

    void Start()
    {
        Invoke("TurnOnAcceleration", 7f);
    }

    void TurnOnAcceleration()
    {
        takeOff.Stop();
        acceleration.Play();
    }

    public void StopAllSounds()
    {
        takeOff.Stop();
        acceleration.Stop();
    }
}
