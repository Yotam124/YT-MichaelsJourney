﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAudio : MonoBehaviour
{
    private AudioSource audioSource;

    [SerializeField]
    private AudioClip scream_Clip, die_Clip;

    [SerializeField]
    private AudioClip[] attack_Clips;


    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

   public void PlayScreamSound()
    {
        audioSource.clip = scream_Clip;
        audioSource.Play();
    }

    public void PlayAttackSound()
    {
        audioSource.clip = attack_Clips[Random.Range(0, attack_Clips.Length)];
        audioSource.Play();
    }

    public void PlayDeadSound()
    {
        audioSource.clip = die_Clip;
        audioSource.Play();
    }

}
