using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;


public class MoveBall : MonoBehaviour
{
   

   Rigidbody rb;
   public int ballSpeed;
   public int jumpSpeed;

   private bool istouching = true;
   
   
   
    void Start()
    {
        rb = GetComponent<Rigidbody>();
      
    }

    
    void Update()
    {


        float Hmove = Input.GetAxis("Horizontal");
        float Vmove = Input.GetAxis("Vertical");

        Vector3 ballmove = new Vector3 (Hmove,0.0f,Vmove);
 
         rb.AddForce(ballmove * ballSpeed);

         if (istouching == true  && (Input.GetKey(KeyCode.Space)))
         {
            
            Vector3 balljump = new Vector3(0.0f,6.0f,0.0f);
            
            rb.AddForce(balljump * jumpSpeed);
         }
         istouching = false;
        }

         private void OnCollisionStay() 
        {
            istouching = true;
        }

        private void OnTriggerEnter(Collider other) 
        {
            if (other.gameObject.CompareTag("Coinstag"))
            {
                other.gameObject.SetActive(false);
            
            }
        }
}
