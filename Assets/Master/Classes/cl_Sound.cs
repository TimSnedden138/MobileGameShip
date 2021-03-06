﻿using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class cl_Sound
{
    public string name;

    public AudioClip clip;

    [Range(0f, 1f)]
    public float volume;
    [Range(-3f, 3f)]
    public float pitch;

    public bool loop;
    public bool playOnAwake;
    public bool mute;

    [HideInInspector]
    public AudioSource source;
}