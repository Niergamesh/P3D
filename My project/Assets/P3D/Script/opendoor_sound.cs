using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opendoor_sound : MonoBehaviour
{
    [SerializeField] private AudioSource Opendoor;
    [SerializeField] private float volume = 1.0f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Opendoor.Play();
        }
    }

}
