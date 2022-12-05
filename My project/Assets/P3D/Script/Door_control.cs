
using UnityEngine;

public class Door_control : MonoBehaviour
{
    private Animator Door_Animator;
    [SerializeField] private AudioSource a1;
    [SerializeField] private AudioSource a2;
    private void Start()
    {
        Door_Animator = gameObject.GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OpenDoor();
            a1.Play();
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CloseDoor();
            a2.Play();
        }

    }

    private void OpenDoor()
    {
        Door_Animator.SetBool("open",true);
    }

    private void CloseDoor()
    {
        Door_Animator.SetBool("open", false);
    }
}
