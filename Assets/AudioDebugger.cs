using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioDebugger : MonoBehaviour
{
    void Start()
    {
        DebugAllAudioSources();
    }

    void DebugAllAudioSources()
    {
        AudioSource[] allSources = Resources.FindObjectsOfTypeAll<AudioSource>();

        foreach (var source in allSources)
        {
            string clipName = (source.clip != null) ? source.clip.name : "None";
            Debug.Log("AudioSource found on: " + source.gameObject.name + ", Clip: " + clipName);
        }
    }
}
