using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public AudioClip Musics;
    public float maxTime;

    private float currentTime;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = Audio.instance.PlayAudioOnLoop(Musics);
    }

    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime >= maxTime || GameManager.Instance.muerto == true)

        {
            Destroy(Audio.instance.gameObject);
            Audio.instance.ClearAudioList();
            Destroy(audioSource.gameObject);
            currentTime = 0;
            audioSource.Stop();
            audioSource = Audio.instance.PlayAudioOnLoop(Musics);
        }
    }

    public void PauseMusic()
    {
        audioSource.Pause();
    }

    public void ResumeMusic()
    {
        audioSource.UnPause();
    }
}