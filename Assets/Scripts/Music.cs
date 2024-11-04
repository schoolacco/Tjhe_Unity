using UnityEngine;
public class MusicClass : MonoBehaviour
{
    private static MusicClass instance; // Singleton instance
    private AudioSource _audioSource;

    private void Awake()
    {
        if (instance == null)  // Check if instance already exists
        {
            instance = this;  // Set the instance to this object
            DontDestroyOnLoad(gameObject);  // Persist across scenes
            _audioSource = GetComponent<AudioSource>();
        }
        else
        {
            Destroy(gameObject);  // Destroy duplicate instance
        }
    }

    public void PlayMusic()
    {
        if (_audioSource && !_audioSource.isPlaying)
        {
            _audioSource.Play();
        }
    }

    public void StopMusic()
    {
        if (_audioSource)
        {
            _audioSource.Stop();
        }
    }
}
