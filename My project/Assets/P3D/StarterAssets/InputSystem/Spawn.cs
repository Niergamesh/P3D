using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Spawn : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    private PlayerInput player_input;
    private void Start()
    {
        player_input = GetComponent<PlayerInput>();
    }


    private void Update()
    {
        if (player_input.actions["Spawn"].triggered)
        {
            Instantiate(prefab, transform.position + transform.forward * 5+transform.up*2, Quaternion.identity);
        }
    }
}
 