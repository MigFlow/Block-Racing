using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement; // reference to PlayerMovement script

    // runs when we hit an object
    // get information about the collision and call it "collisonInfo"
    void OnCollisionEnter(Collision collisionInfo)
    {
        // check if the object we collide with has a tag "Obstacle"
        if (collisionInfo.collider.tag == "Obstacle")
        {
            
            FindObjectOfType<Player>().TakeDamage(1);
            if(FindObjectOfType<Player>().currentHealth <0.01f){

                // disable the player movement
                movement.enabled = false;

                // End game
                FindObjectOfType<GameManager>().EndGame();
                Debug.Log(collisionInfo.collider.name);
          }
        }

    }
}
