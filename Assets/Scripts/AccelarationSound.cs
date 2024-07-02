using UnityEngine;

public class PlaySoundOnKeyPress : MonoBehaviour
{
    public AudioClip soundClip; // Your sound file
    private AudioSource audioSource;

    void Start()
    {
        // Add and configure the AudioSource component
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = soundClip;
        audioSource.loop = true; // Enable looping to continuously play the sound
    }

    void Update()
    {
        // Play sound when 'W' key or up arrow key is pressed
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }

        // Stop sound when 'W' key or up arrow key is released
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.UpArrow))
        {
            if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }
        }
    }
}