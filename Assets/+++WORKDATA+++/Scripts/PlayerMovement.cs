using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
   public float speed;
   public float rotationSpeed;

   public float jumpSpeed;
   private float ySpeed;

   public float pushPower = 2f;
   
   private CharacterController controller;
   
   public bool isGrounded;
   
   //public bool canJump;
   //public bool canMoveonZ;
   
  // private Animator anim;

   private void Start()
   {
     controller = GetComponent<CharacterController>();
     // anim = GetComponent<Animator>();
   }
   
   void Update()
   {
      float horizontalMove = Input.GetAxis("Horizontal");
      float verticalMove = Input.GetAxis("Vertical");
      
      Vector3 moveDir = new Vector3(horizontalMove, 0, verticalMove);
      moveDir.Normalize();
      float magnitude = moveDir.magnitude;
      magnitude = Mathf.Clamp01(magnitude);
      
      controller.SimpleMove(moveDir * magnitude * speed);
      
      ySpeed += Physics.gravity.y * Time.deltaTime;
      
      if (Input.GetButtonDown("Jump"))
      {
         ySpeed = -0.5f;
         isGrounded = false;
      }

      Vector3 vel = moveDir * magnitude;
      vel.y = ySpeed;
     // transform.Translate(vel * Time.deltaTime);
     controller.Move(vel * Time.deltaTime);

     if (controller.isGrounded)
     {
         ySpeed = -0.5f;
         isGrounded = true;
         if (Input.GetButtonDown("Jump"))
         {
             ySpeed = jumpSpeed;
             isGrounded = false;
         }
     }
     
     if (moveDir != Vector3.zero)
     {
         Quaternion toRotate = Quaternion.LookRotation(moveDir, Vector3.up);
         transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotate, rotationSpeed * Time.deltaTime);
     }
   }

   private void OnControllerColliderHit(ControllerColliderHit hit)
   {
       Debug.Log(hit.collider.name);
       
       if (hit.transform.tag == "Movable")
       {
           Rigidbody box = hit.collider.GetComponent<Rigidbody>();
           if (box != null)
           {
               Vector3 pushdirection = hit.transform.position - transform.position;
               box.linearVelocity = pushdirection * pushPower;
           }
       }
   }
}
