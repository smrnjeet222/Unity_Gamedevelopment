using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSound : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField]
    private List<AudioClip> soundClips = new List<AudioClip>();
    [SerializeField]
    private float soundTimerDelay = 5.0f;

    private float soundTimer; 

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        soundTimer = soundTimer +Time.deltaTime;
        if(soundTimer >= soundTimerDelay){
            soundTimer = 0;
            AudioClip randomSound = soundClips[Random.Range(0, soundClips.Count)] ;
            audioSource.PlayOneShot(randomSound);
        }   
    }
}
