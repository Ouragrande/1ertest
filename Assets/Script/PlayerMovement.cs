using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private CharacterController characterController;
    private float movementSpeed = 5f;
    Transform right;

    Rigidbody rb;
    float force = 10f;
    float speed = 10f;
    [SerializeField] bool canJump = false;
    
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (canJump && rb.velocity.y == 0)
        {
            
            rb.AddForce(new Vector3(0, force, 0), ForceMode.Impulse);
            canJump = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            canJump = true;
        }
        
        float horizontalInput = Input.GetAxis("Horizontal");
        //Vector3 movement = new Vector3(horizontalInput * Time.deltaTime * movementSpeed, gameObject.transform.position.y* Time.deltaTime, 1 * Time.deltaTime * movementSpeed); ;
        //characterController.Move(movement);
Debug.Log(horizontalInput);
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector3(gameObject.transform.position.x + (horizontalInput * Time.deltaTime * movementSpeed), gameObject.transform.position.y, gameObject.transform.position.z); 
        }

    }
}
