using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAssets : MonoBehaviour
{
    private static GameAssets instance;
    
    public static GameAssets Getinstance()
    {
        return instance;
    }

    private void Awake()
    {
        instance = this;
    }
    
    public SoundAudioClip[] soundAudioClipArray;
    
    [Serializable]
    public class SoundAudioClip
    {
        public SoundManager.Sound sound;
        public AudioClip audioClip;
    }
}
