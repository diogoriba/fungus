using Fungus;
using System;
using UnityEngine;

[Serializable]
public class UnityAudioClip : FungusAudioClip
{
    [SerializeField] internal AudioClip unityAudioClip;

    public UnityAudioClip(AudioClip audioClip)
    {
        this.unityAudioClip = audioClip;
    }

    public override float length => this.unityAudioClip.length;

    public override int samples => this.unityAudioClip.samples;

    public override int channels => this.unityAudioClip.channels;

    public override bool GetData(float[] data, int offsetSamples)
    {
        return this.unityAudioClip.GetData(data, offsetSamples);
    }

    public override bool SetData(float[] data, int offsetSamples)
    {
        return this.unityAudioClip.SetData(data, offsetSamples);
    }
}