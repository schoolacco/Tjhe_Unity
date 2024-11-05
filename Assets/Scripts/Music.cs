using UnityEngine;

public class MusicClass : MonoBehaviour
{
    public static MusicClass Instance; // Singleton instance
    private AudioSource _audioSource;

    private void Awake()
    {
        if (Instance == null)  // Check if instance already exists
        {
            Instance = this;  // Set the instance to this object
            _audioSource = GetComponent<AudioSource>();
            
            if (_audioSource == null)
            {
                Debug.LogError("Missing");
            }
            
            DontDestroyOnLoad(gameObject);  // Persist across scenes
        }
        else
        {
            Destroy(gameObject);  // Destroy duplicate instance
        }
        
        PlayMusic(); // Start playing music
    }

    public void PlayMusic()
    {
        if (_audioSource != null && !_audioSource.isPlaying)
        {
            Debug.Log("Playing music...");
            _audioSource.Play();
        }
        else
        {
            Debug.Log("YOU'RE NOT REPLAYING MUSIC");
        }
    }

    public void StopMusic()
    {
        if (_audioSource != null)
        {
            Debug.Log("Stopping music...");
            _audioSource.Stop(); // Stop music without muting
        }
        else
        {
            Debug.LogError("Where?");
        }
    }
}
