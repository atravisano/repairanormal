using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayRandomSound : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] audioClips;
    public float deleteGameObjectAfterTime = 120;
    private float timeBeforeDestroy = 0;

    // Start is called before the first frame update
    void Start()
    {
        timeBeforeDestroy = deleteGameObjectAfterTime;
        PlayRandomAudioClip();
    }

    // Update is called once per frame
    void Update()
    {
        timeBeforeDestroy -= Time.deltaTime;
        if(timeBeforeDestroy <= 0)
        {
            // Destroy game object after specified time
            Destroy(this.gameObject);
            timeBeforeDestroy = deleteGameObjectAfterTime;
        }
    }

    void PlayRandomAudioClip()
    {
        audioSource.clip = audioClips[Random.Range(0, audioClips.Length)];
        audioSource.Play();
    }
}
