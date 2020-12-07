using BA3SoundDesign.InputActions;
using System;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// BA3 Sound Design controllers namespace
/// </summary>
namespace BA3SoundDesign.Controllers
{
    /// <summary>
    /// Intro controller script class
    /// </summary>
    public class IntroControllerScript : MonoBehaviour, IIntroController
    {
        /// <summary>
        /// On continued
        /// </summary>
        [SerializeField]
        private UnityEvent onContinued;

        //private (string, AudioClip, int)[] microphoneAudioClips = Array.Empty<(string, AudioClip, int)>();

        /// <summary>
        /// On continued
        /// </summary>
        public event ContinuedDelegate OnContinued;

        /// <summary>
        /// Game input actions
        /// </summary>
        public GameInputActions GameInputActions { get; private set; }

        /// <summary>
        /// Continue
        /// </summary>
        public void Continue()
        {
            if (onContinued != null)
            {
                onContinued.Invoke();
            }
            OnContinued?.Invoke();
        }

        /// <summary>
        /// Awake
        /// </summary>
        private void Awake()
        {
            GameInputActions = new GameInputActions();
            GameInputActions.GameActionMap.Any.performed += (context) => Continue();
        }

        /// <summary>
        /// On enable
        /// </summary>
        private void OnEnable() => GameInputActions.Enable();

        /// <summary>
        /// On disable
        /// </summary>
        private void OnDisable() => GameInputActions.Disable();

        //private void Start()
        //{
        //    string[] microphone_devices = Microphone.devices;
        //    microphoneAudioClips = new (string, AudioClip, int)[microphone_devices.Length];
        //    for (int index = 0; index < microphone_devices.Length; index++)
        //    {
        //        string microphone_device = microphone_devices[index];
        //        microphoneAudioClips[index] = (microphone_device, Microphone.Start(microphone_device, false, 1000, 44100), 0);
        //    }
        //}

        //private void Update()
        //{
        //    for (int index = 0; index < microphoneAudioClips.Length; index++)
        //    {
        //        ref (string, AudioClip, int) microphone_audio_clip = ref microphoneAudioClips[index];
        //        int position = Microphone.GetPosition(microphone_audio_clip.Item1);
        //        float[] samples = new float[position - microphone_audio_clip.Item3];
        //        microphone_audio_clip.Item2.GetData(samples, microphone_audio_clip.Item3);
        //        float local_sum_samples = 0.0f;
        //        foreach (float sample in samples)
        //        {
        //            local_sum_samples += sample;
        //        }
        //        if (samples.Length > 0)
        //        {
        //            local_sum_samples /= samples.Length;
        //        }
        //        if (local_sum_samples >= (0.03125f * 0.25f))
        //        {
        //            Continue();
        //        }
        //        microphone_audio_clip = (microphone_audio_clip.Item1, microphone_audio_clip.Item2, position);
        //    }
        //}
    }
}
