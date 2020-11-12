using Fungus;
using System;
using UnityEngine;

[Serializable]
[RequireComponent(typeof(AudioSource))]
public class UnityAudioSource : FungusAudioSource
{
    protected AudioSource audioSource;
    protected UnityAudioClip unityAudioClip;

    protected AudioSource AudioSource
    {
        get
        {
            if (audioSource == null)
            {
                audioSource = GetComponent<AudioSource>();
            }
            return audioSource;
        }
    }

    public override FungusAudioClip clip 
    {
        get
        {
            if (unityAudioClip == null || unityAudioClip.unityAudioClip != AudioSource.clip)
            {
                unityAudioClip = new UnityAudioClip(AudioSource.clip);
            }
            return unityAudioClip;
        }
        set 
        { 
            unityAudioClip = (UnityAudioClip)value; 
            AudioSource.clip = unityAudioClip?.unityAudioClip; 
        } 
    }
    public override bool loop { get => AudioSource.loop; set => AudioSource.loop = value; }
    public override float time { get => AudioSource.time; set => AudioSource.time = value; }
    public override float volume { get => AudioSource.volume; set => AudioSource.volume = value; }
    public override bool playOnAwake { get => AudioSource.playOnAwake; set => AudioSource.playOnAwake = value; }
    public override float pitch { get => AudioSource.pitch; set => AudioSource.pitch = value; }

    public override bool isPlaying => AudioSource.isPlaying;

    public override float minDistance { get => AudioSource.minDistance; set => AudioSource.minDistance = value; }
    public override int priority { get => AudioSource.priority; set => AudioSource.priority = value; }

    public override void Pause()
    {
        AudioSource.Pause();
    }

    public override void Play()
    {
        AudioSource.Play();
    }

    public override void PlayClipAtPoint(FungusAudioClip clip, Vector3 position, float volume = 1)
    {
        var clipToPlay = (UnityAudioClip)clip;
        AudioSource.PlayClipAtPoint(clipToPlay.unityAudioClip, position, volume);
    }

    public override void PlayOneShot(FungusAudioClip clip, float volume = 1)
    {
        var clipToPlay = (UnityAudioClip)clip;
        AudioSource.PlayOneShot(clipToPlay.unityAudioClip, volume);
    }

    public override void Stop()
    {
        AudioSource.Stop();
    }
}