using Fungus;
using UnityEngine;

public class UnityAudioSource : FungusAudioSource
{
    [SerializeField] internal AudioSource unityAudioSource;
    
    private UnityAudioClip unityAudioClip;

    private UnityAudioClip GetClip()
    {
        if ((unityAudioClip != null && unityAudioSource.clip) || (unityAudioClip.unityAudioClip != unityAudioSource.clip))
        {
            unityAudioClip = new UnityAudioClip(unityAudioSource.clip);
        }
        return unityAudioClip;
    }

    public override FungusAudioClip clip { get => GetClip(); set { unityAudioClip = (UnityAudioClip)value; unityAudioSource.clip = unityAudioClip.unityAudioClip; } }
    public override bool loop { get => unityAudioSource.loop; set => unityAudioSource.loop = value; }
    public override float time { get => unityAudioSource.time; set => unityAudioSource.time = value; }
    public override float volume { get => unityAudioSource.volume; set => unityAudioSource.volume = value; }
    public override bool playOnAwake { get => unityAudioSource.playOnAwake; set => unityAudioSource.playOnAwake = value; }
    public override float pitch { get => unityAudioSource.pitch; set => unityAudioSource.pitch = value; }

    public override bool isPlaying => unityAudioSource.isPlaying;

    public override float minDistance { get => unityAudioSource.minDistance; set => unityAudioSource.minDistance = value; }
    public override int priority { get => unityAudioSource.priority; set => unityAudioSource.priority = value; }

    public override void Pause()
    {
        unityAudioSource.Pause();
    }

    public override void Play()
    {
        unityAudioSource.Play();
    }

    public override void PlayClipAtPoint(FungusAudioClip clip, Vector3 position, float volume = 1)
    {
        var clipToPlay = (UnityAudioClip)clip;
        AudioSource.PlayClipAtPoint(clipToPlay.unityAudioClip, position, volume);
    }

    public override void PlayOneShot(FungusAudioClip clip, float volume = 1)
    {
        var clipToPlay = (UnityAudioClip)clip;
        unityAudioSource.PlayOneShot(clipToPlay.unityAudioClip, volume);
    }

    public override void Stop()
    {
        unityAudioSource.Stop();
    }
}