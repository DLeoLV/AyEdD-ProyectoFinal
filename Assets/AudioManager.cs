using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instancia;
    public AudioClip musicaFondo;
    public AudioSource reproducirMusicaFondo;

    void Start()
    {
        if(instancia == null)
        {
            instancia = this;
            reproducirMusicaFondo.clip = musicaFondo;
            reproducirMusicaFondo.Play();
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}