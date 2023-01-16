using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // reference to the Rigidbody component
    public Rigidbody rb;

    public float forwardForce = 8000f;
    public float sidewaysForce = 120f;

    Vector3 movement;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        Debug.Log("Hello, World!");
    }
    
    // Update is called once per frame
    void Update(){
 
         movement = new Vector3(Input.GetAxis("Horizontal") * sidewaysForce, 0, 0);

    }

    // FixedUpdate for Physics Stuff
    void FixedUpdate()
    {
        // Add a forward Force (z-Axis)
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);   

        // Movement with Force --> with inertia 
        // Movment
        rb.AddForce(movement * Time.fixedDeltaTime, ForceMode.VelocityChange);

        // Movement with MovePosition --> more precise 
        // Movment 
        //rb.MovePosition(rb.position + movement * Time.fixedDeltaTime);
       
        // fall down stops level
        if(rb.position.y < -1f){
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
