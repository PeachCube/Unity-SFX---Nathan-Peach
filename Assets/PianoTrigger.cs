using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.VisualScripting.Member;

public class PianoTrigger : MonoBehaviour
{
    public AudioSource source;
    private void OnTriggerEnter(Collider other)
    {
        source.Play();
    }
}
