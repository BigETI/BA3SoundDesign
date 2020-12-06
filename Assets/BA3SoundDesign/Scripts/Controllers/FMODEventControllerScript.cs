using FMOD;
using FMOD.Studio;
using FMODUnity;
using System;
using UnityEngine;

/// <summary>
/// BA3 Sound Design controllers namespace
/// </summary>
namespace BA3SoundDesign.Controllers
{
    /// <summary>
    /// FMOD event controller script class
    /// </summary>
    public class FMODEventControllerScript : MonoBehaviour, IFMODEventController
    {
        /// <summary>
        /// Solo
        /// </summary>
        private static FMODEventControllerScript solo;

        /// <summary>
        /// Event name
        /// </summary>
        [SerializeField]
        private string eventName;

        /// <summary>
        /// FMOD event path
        /// </summary>
        [SerializeField]
        [EventRef]
        private string fmodEventPath;

        /// <summary>
        /// Is interactable
        /// </summary>
        [SerializeField]
        private bool isInteractable = true;

        /// <summary>
        /// Is playing on start
        /// </summary>
        [SerializeField]
        private bool isPlayingOnStart = true;

        /// <summary>
        /// Is looping
        /// </summary>
        [SerializeField]
        private bool isLooping;

        /// <summary>
        /// Volume
        /// </summary>
        [SerializeField]
        [Range(0.0f, 1.0f)]
        private float volume = 1.0f;

        /// <summary>
        /// Is muted
        /// </summary>
        [SerializeField]
        private bool isMuted;

        /// <summary>
        /// Last FMOD event path
        /// </summary>
        private string lastFMODEventPath = string.Empty;

        /// <summary>
        /// Event name
        /// </summary>
        public string EventName
        {
            get => eventName ?? string.Empty;
            set => eventName = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// FMOD event path
        /// </summary>
        public string FMODEventPath
        {
            get => fmodEventPath ?? string.Empty;
            set
            {
                fmodEventPath = value ?? throw new ArgumentNullException(nameof(value));
                if (IsPlaying)
                {
                    Replay();
                }
            }
        }

        /// <summary>
        /// Is interactable
        /// </summary>
        public bool IsInteractable
        {
            get => isInteractable;
            set => isInteractable = value;
        }

        /// <summary>
        /// Is playing on start
        /// </summary>
        public bool IsPlayingOnStart
        {
            get => isPlayingOnStart;
            set => isPlayingOnStart = value;
        }

        /// <summary>
        /// Is looping
        /// </summary>
        public bool IsLooping
        {
            get => isLooping;
            set => isLooping = value;
        }

        /// <summary>
        /// Volume
        /// </summary>
        public float Volume
        {
            get => Mathf.Clamp(volume, 0.0f, 1.0f);
            set => volume = Mathf.Clamp(value, 0.0f, 1.0f);
        }

        /// <summary>
        /// Is muted
        /// </summary>
        public bool IsMuted
        {
            get => isMuted;
            set => isMuted = value;
        }

        /// <summary>
        /// Is solo
        /// </summary>
        public bool IsSolo
        {
            get => (solo && (solo == this));
            set
            {
                if (value)
                {
                    solo = this;
                }
                else if (IsSolo)
                {
                    solo = null;
                }
            }
        }

        /// <summary>
        /// Is muted through solo
        /// </summary>
        public bool IsSoloMuted => solo && (solo != this);

        /// <summary>
        /// Is playing
        /// </summary>
        public bool IsPlaying
        {
            get
            {
                bool ret = false;
                if (FMODEventInstance.isValid())
                {
                    if (FMODEventInstance.getPlaybackState(out PLAYBACK_STATE playback_state) == RESULT.OK)
                    {
                        ret = (playback_state == PLAYBACK_STATE.PLAYING) || (playback_state == PLAYBACK_STATE.STARTING);
                    }
                }
                return ret;
            }
            set
            {
                if (value)
                {
                    Play();
                }
                else
                {
                    Stop();
                }
            }
        }

        /// <summary>
        /// FMOD event instance
        /// </summary>
        public EventInstance FMODEventInstance { get; private set; }

        /// <summary>
        /// FMOD event rigid body
        /// </summary>
        public Rigidbody FMODEventRigidBody { get; private set; }

        /// <summary>
        /// Play
        /// </summary>
        /// <returns>"true" if successful, otherwise "false"</returns>
        public bool Play()
        {
            bool ret = false;
            if (!IsPlaying)
            {
                if (lastFMODEventPath == FMODEventPath)
                {
                    FMODEventInstance.setVolume(Volume);
                    FMODEventInstance.start();
                }
                else
                {
                    FMODEventInstance = RuntimeManager.CreateInstance(FMODEventPath);
                    if (FMODEventInstance.isValid())
                    {
                        FMODEventInstance.setVolume(Volume);
                        ret = (FMODEventInstance.start() == RESULT.OK);
                    }
                }
            }
            return ret;
        }

        /// <summary>
        /// Replay
        /// </summary>
        /// <returns>"true" if successful, otherwise "false"</returns>
        public bool Replay()
        {
            Stop();
            return Play();
        }

        /// <summary>
        /// Pause
        /// </summary>
        /// <returns>"true" if successful, otherwise "false"</returns>
        public bool Pause() => IsPlaying && (FMODEventInstance.setPaused(true) == RESULT.OK);

        /// <summary>
        /// Resume
        /// </summary>
        /// <returns>"true" if successful, otherwise "false"</returns>
        public bool Resume() => !IsPlaying && (FMODEventInstance.setPaused(false) == RESULT.OK);

        /// <summary>
        /// Stop
        /// </summary>
        /// <returns>"true" if successful, otherwise "false"</returns>
        public bool Stop() => IsPlaying && (FMODEventInstance.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT) == RESULT.OK);

        /// <summary>
        /// Play one shot
        /// </summary>
        public void PlayOneShot() => RuntimeManager.PlayOneShot(fmodEventPath, transform.position);

        /// <summary>
        /// On enable
        /// </summary>
        private void OnEnable()
        {
            if (isPlayingOnStart)
            {
                Play();
            }
        }

        /// <summary>
        /// On disable
        /// </summary>
        private void OnDisable() => Stop();

        /// <summary>
        /// Start
        /// </summary>
        private void Start() => FMODEventRigidBody = GetComponentInParent<Rigidbody>();

        /// <summary>
        /// Update
        /// </summary>
        private void Update()
        {
            if (FMODEventInstance.isValid())
            {
                FMODEventInstance.setVolume((isMuted || IsSoloMuted) ? 0.0f : Volume);
                if (FMODEventInstance.get3DAttributes(out ATTRIBUTES_3D attributes) == RESULT.OK)
                {
                    Vector3 position = transform.position;
                    Vector3 up = transform.up;
                    Vector3 forward = transform.forward;
                    Vector3 velocity = FMODEventRigidBody ? FMODEventRigidBody.velocity : Vector3.zero;
                    attributes.position.x = position.x;
                    attributes.position.y = position.y;
                    attributes.position.z = position.z;
                    attributes.up.x = up.x;
                    attributes.up.y = up.y;
                    attributes.up.z = up.z;
                    attributes.forward.x = forward.x;
                    attributes.forward.y = forward.y;
                    attributes.forward.z = forward.z;
                    attributes.velocity.x = velocity.x;
                    attributes.velocity.y = velocity.y;
                    attributes.velocity.z = velocity.z;
                    FMODEventInstance.set3DAttributes(attributes);
                }
                if (IsLooping && (FMODEventInstance.getPlaybackState(out PLAYBACK_STATE playback_state) == RESULT.OK) && (playback_state == PLAYBACK_STATE.STOPPED))
                {
                    FMODEventInstance.start();
                }
            }
        }
    }
}
