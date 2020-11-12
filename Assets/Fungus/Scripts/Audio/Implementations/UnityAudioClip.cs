using Fungus;
using System;
using UnityEngine;

[Serializable]
public class UnityAudioClip : FungusAudioClip
{
    [SerializeField] internal AudioClip unityAudioClip;

    public UnityAudioClip()
    {
    }

    public UnityAudioClip(AudioClip audioClip)
    {
        unityAudioClip = audioClip;
    }

    public override string name { get => this.unityAudioClip.name; set => this.unityAudioClip.name = value; }
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