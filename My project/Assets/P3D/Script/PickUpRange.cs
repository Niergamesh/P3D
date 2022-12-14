using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpRange : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PickUp>().checkPickup(transform.parent.gameObject);
        }
    }
}
