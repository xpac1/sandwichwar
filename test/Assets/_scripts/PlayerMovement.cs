using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float speed;

    private Rigidbody playerRigidbody;

    
    void Awake()
    {
        playerRigidbody = GetComponent <Rigidbody> ();
    }


    //this is the controls for rotation and movement

    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;    
    
    void Update() {
        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded) {
            
            moveDirection = new Vector3(0, 0, Input.GetAxis("Vertical"));
            
            moveDirection = transform.TransformDirection(moveDirection);
            
            moveDirection *= speed;
            if (Input.GetButton("Jump")){
                moveDirection.y = jumpSpeed;
            }
        }
        
        float multiplier = 6.0F;
        moveDirection.y -= gravity * multiplier * Time.deltaTime;

        controller.Move(moveDirection * Time.deltaTime);
        transform.Rotate(0,Input.GetAxis("Rotate")*60f*Time.deltaTime,0);
    }
    
    void FixedUpdate()
    {        
        Move();
        Jump();
    }
    
    void Move()
    {
        playerRigidbody.AddForce(transform.forward * speed * Time.deltaTime);
    }
    
    
    void Jump()
    {
        playerRigidbody.AddForce(Vector3.up *jumpSpeed);
    }

    
}
