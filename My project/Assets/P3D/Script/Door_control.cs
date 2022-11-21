
using UnityEngine;

public class Door_control : MonoBehaviour
{
    private Animator Door_Animator;

    private void Start()
    {
        Door_Animator = gameObject.GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triger");
        if (other.CompareTag("Player"))
        {
            OpenDoor();
        }
    }

    private void OpenDoor()
    {
        Door_Animator.SetBool("open",true);
    }
}
