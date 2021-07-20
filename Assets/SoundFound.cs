using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFound : MonoBehaviour
{
    public AudioClip foundClip;

    void OnTriggerEnter(Collider col)
    {
        AudioSource.PlayClipAtPoint(foundClip, transform.position);
        Destroy(this.gameObject);
    }
}
