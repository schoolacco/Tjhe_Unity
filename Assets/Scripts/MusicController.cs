using UnityEngine;

public class MusicController : MonoBehaviour
{
    public static MusicController Instance;  // Singleton instance
    private AudioSource audioSource;

    void Awake()
    {
        // Ensure only one instance of MusicController exists
        if (Instance == null)
        {
            Instance = this;
            audioSource = GetComponent<AudioSource>();
            DontDestroyOnLoad(gameObject); // Keep it between scenes
        }
        else
        {
            Destroy(gameObject);  // Destroy duplicate instances
        }
    }

    public void ChangeMusic(string clipName)
    {
        // Find the clip in Resources by its name
        AudioClip clip = Resources.Load<AudioClip>(clipName);

        if (clip != null)
        {
            audioSource.clip = clip;  // Set the new music
            audioSource.Play();       // Play the new music
        }
        else
        {
            Debug.LogWarning("AudioClip with name " + clipName + " not found!");
        }
    }
}
