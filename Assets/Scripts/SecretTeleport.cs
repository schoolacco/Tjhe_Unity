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
        musiccontroller = FindObjectOfType<MusicClass>(); // possibly obselete
        Collider2D = GetComponent<BoxCollider2D>();
        if (musiccontroller == null)
        {
            Debug.LogWarning("Where is it");
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Interacted");            
            MusicClass.Instance.StopMusic();
            SceneManager.LoadScene("Level_O1");
        }
    }
}    