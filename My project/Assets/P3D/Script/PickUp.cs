using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PickUp : MonoBehaviour
{
    [SerializeField] private Transform handTrasform;
    private PlayerInput playerInput;

    private void Start() 
    {
        playerInput = GetComponent<PlayerInput>();
    }

    public void checkPickup(GameObject pickUpObject)
    {
        if (playerInput.actions["Grab"].triggered)
        {
            pickUpObject.GetComponent<Rigidbody>().useGravity = false;
            pickUpObject.GetComponent<Rigidbody>().isKinematic = true;
            pickUpObject.transform.position = handTrasform.position; 
            pickUpObject.transform.SetParent(handTrasform);
            
        }
    }
}
