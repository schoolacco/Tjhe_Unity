using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
public class Explode : MonoBehaviour
{
    private BoxCollider2D playerCollider;
    private Rigidbody2D body2D;
    public CheckPoint checkpoint;
    private Vector3 checkpointPosition;
    bool debug = false;
    void Start()
    {
        // Get the CapsuleCollider2D component attached to the Player GameObject
        playerCollider = GetComponent<BoxCollider2D>();
        body2D = GetComponent<Rigidbody2D>();
        checkpointPosition = CheckPoint.GetActiveCheckPointPosition();
    }
    void Update()
    {
        checkpointPosition = CheckPoint.GetActiveCheckPointPosition();
        if (Input.GetKey("9")){
            // Set the x component of the movement vector to 1 (right direction)
            Debug.Log("Debug mode on");
            if (debug == false){
                debug = true;
            }
            else if (debug == true)
            {
                debug = false;
            }
        }
    }
    // This method is called when another Collider2D enters the trigger zone of this GameObject.
    void OnTriggerEnter2D(Collider2D target)
    {
        // Check if the entering GameObject has the "Deadly" tag

        if (target.gameObject.CompareTag("Deadly") && debug == false){
            
            // Skip the fall
          if (checkpointPosition != Vector3.zero)
                      {
                          body2D.transform.position = checkpointPosition;
                          body2D.velocity = Vector2.zero;
                          playerCollider = GetComponent<BoxCollider2D>();
                          playerCollider.enabled = true;
                      }
                      else
                      {
                        SceneManager.LoadScene("GameOver");
                      }
          
        }
    }

    // This method is called when a collision with another Collider2D occurs.
    void OnCollisionEnter2D(Collision2D target)
    {
        // Check if the colliding GameObject has the "Deadly" tag
        if (target.gameObject.CompareTag("Deadly")){

            // Disable the CapsuleCollider2D on the Player to prevent further collisions
            if (playerCollider != null){
                playerCollider.enabled = false;

            }
        }
    }
}
