using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManage : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip BackgroundMusic;
    public AudioClip GhostNromalState;


    // Start is called before the first frame update
    void Start()
    {
        audioSource.Play();
    }



    // Update is called once per frame
    void Update()
    {
        if (!audioSource.isPlaying)
        {

            audioSource.clip = GhostNromalState;
            audioSource.Play();

        }
    }
}
