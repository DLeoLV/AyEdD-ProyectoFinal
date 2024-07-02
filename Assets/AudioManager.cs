using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip musicaFondo;
    public AudioSource reproducirMusicaFondo;

    void Start()
    {
        reproducirMusicaFondo.clip = musicaFondo;
        reproducirMusicaFondo.Play();
        DontDestroyOnLoad(this.gameObject);
    }
}