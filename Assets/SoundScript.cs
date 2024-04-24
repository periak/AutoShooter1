using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    public static AudioClip shoot;
    static AudioSource audio_source;
    private void Start()
    {
        shoot = Resources.Load<AudioClip> ("fire");

        audio_source = GetComponent<AudioSource>();
    }
    public static void ShootSound()
    {
        audio_source.PlayOneShot(shoot);
    }
}
