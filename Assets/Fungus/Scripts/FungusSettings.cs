using System;
using UnityEngine;

namespace Fungus
{
    public class FungusSettings : ScriptableObject
    {
        [SerializeField] public string audioSourceTypeFQN;

        private Type defaultAudioSourceType;
        public Type DefaultAudioSourceType
        {
            get
            {
                if (defaultAudioSourceType == null || defaultAudioSourceType.AssemblyQualifiedName != audioSourceTypeFQN) 
                {
                    defaultAudioSourceType = Type.GetType(audioSourceTypeFQN);
                }
                return defaultAudioSourceType;
            }
        }
        private static FungusSettings instance;
        public static FungusSettings Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = Resources.Load<FungusSettings>("FungusSettings");
                }
                return instance;
            }
        }
    }
}