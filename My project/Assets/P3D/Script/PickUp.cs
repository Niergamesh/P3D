using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PickUp : MonoBehaviour
{
    [SerializeField] private Transform handTrasform;
    [SerializeField] private Transform levelTransform;
    private PlayerInput playerInput;
    private GameObject PickedUpObject;


    private void Update()
    {
        if (playerInput.actions["Throw"].triggered)
        {
            ThrowBall();
        }
    }

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
            PickedUpObject = pickUpObject;
            
        }
    }
    private void ThrowBall()
    {
        PickedUpObject.GetComponent<Rigidbody>().useGravity = true;
        PickedUpObject.GetComponent<Rigidbody>().isKinematic = false;
        PickedUpObject.transform.SetParent(levelTransform);
        PickedUpObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * 300);
    }

}
