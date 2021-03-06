﻿using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {

    public static AudioManager _instance;

    private AudioSource audio;
    public AudioClip colletibleAudioClip;

	
	void Awake () {
        _instance = this;
        audio = this.GetComponent<AudioSource>();
	}

    public void PlayCollectible() {
        audio.PlayOneShot(colletibleAudioClip);
    }
}
