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
        PlayRandomAudioClip();
        Destroy(this.gameObject, deleteGameObjectAfterTime);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void PlayRandomAudioClip()
    {
        audioSource.clip = audioClips[Random.Range(0, audioClips.Length)];
        audioSource.Play();
    }
}
