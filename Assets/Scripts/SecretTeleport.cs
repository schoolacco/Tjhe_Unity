using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SecretTeleport : MonoBehaviour
{
    private MusicClass musiccontroller;
    public BoxCollider2D Collider2D;

    private void Start()
    {
        musiccontroller = FindObjectOfType<MusicClass>();
        Collider2D = GetComponent<BoxCollider2D>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Interacted");            
            musiccontroller.StopMusic();
            SceneManager.LoadScene("Level_O1");
        }
    }
}    