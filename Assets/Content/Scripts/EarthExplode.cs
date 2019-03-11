using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthExplode : MonoBehaviour
{
    public AudioClip explosionClip;
    AudioSource explosionSource;

    void Start ()
    {
        explosionSource = GetComponent<AudioSource>();
    }

    void ExplodeSound()
    {
        explosionSource.PlayOneShot(explosionClip, 0.0f);
    }
}
