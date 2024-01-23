using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMan : MonoBehaviour
{
    private Rigidbody rigidbody;
    private float playerSpeed = 23.0f;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }


    private void Update()
    {
        Vector3 moveInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized;
        
        transform.position += moveInput * playerSpeed * Time.deltaTime;
    }

   
}
