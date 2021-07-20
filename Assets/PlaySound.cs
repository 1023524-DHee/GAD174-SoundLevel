using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        GetComponent<AudioSource>().Play();
    }
}
