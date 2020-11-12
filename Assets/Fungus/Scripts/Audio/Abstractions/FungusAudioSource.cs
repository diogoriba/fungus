using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Fungus
{
    [Serializable]
    public abstract class FungusAudioSource : MonoBehaviour
    {
        public abstract FungusAudioClip clip { get; set; }
        public abstract bool loop { get; set; }
        public abstract float time { get; set; }
        public abstract float volume { get; set; }
        public abstract bool playOnAwake { get; set; }
        public abstract float pitch { get; set; }
        public abstract bool isPlaying { get; }
        public abstract float minDistance { get; set; }
        public abstract int priority { get; set; }
        public abstract void Play();
        public abstract void PlayOneShot(FungusAudioClip clip, float volume = 1f);
        public abstract void Stop();
        public abstract void Pause();
        public abstract void PlayClipAtPoint(FungusAudioClip clip, Vector3 position, float volume = 1f);
    }
}
