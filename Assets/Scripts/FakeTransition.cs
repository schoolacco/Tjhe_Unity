using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
public class FakeTransition : MonoBehaviour
{
   void OnTriggerEnter2D(Collider2D target){
           if(target.gameObject.tag == "Player"){ //If the end of level collectible collides with the player
               Destroy(gameObject); //Remove player from screen
               SceneManager.LoadScene("Neverend"); //Reloads scene
           }
       }
}
