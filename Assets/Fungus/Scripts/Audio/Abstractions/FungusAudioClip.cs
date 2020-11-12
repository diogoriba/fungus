using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fungus
{
    public abstract class FungusAudioClip : UnityEngine.Object
    {
        public abstract float length { get; }
        public abstract int samples { get; }
        public abstract int channels { get; }
        public abstract bool GetData(float[] data, int offsetSamples);
        public abstract bool SetData(float[] data, int offsetSamples);

        public static FungusAudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream, UnityEngine.AudioClip.PCMReaderCallback pcmreadercallback, UnityEngine.AudioClip.PCMSetPositionCallback pcmsetpositioncallback)
        {
            throw new FungusAbstractionNotImplementedException();
        }
        public static FungusAudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, UnityEngine.AudioClip.PCMReaderCallback pcmreadercallback, UnityEngine.AudioClip.PCMSetPositionCallback pcmsetpositioncallback)
        {
            throw new FungusAbstractionNotImplementedException();
        }
        public static FungusAudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream, UnityEngine.AudioClip.PCMReaderCallback pcmreadercallback)
        {
            throw new FungusAbstractionNotImplementedException();
        }
        public static FungusAudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream)
        {
            throw new FungusAbstractionNotImplementedException();
        }
        public static FungusAudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream)
        {
            throw new FungusAbstractionNotImplementedException();
        }
    }
}
