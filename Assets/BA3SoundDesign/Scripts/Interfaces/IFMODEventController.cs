using FMOD.Studio;
using UnityEngine;

/// <summary>
/// BA3 Sound Design namespace
/// </summary>
namespace BA3SoundDesign
{
    /// <summary>
    /// FMOD event controller interface
    /// </summary>
    public interface IFMODEventController : IBehaviour
    {
        /// <summary>
        /// Event name
        /// </summary>
        string EventName { get; set; }

        /// <summary>
        /// FMOD event path
        /// </summary>
        string FMODEventPath { get; set; }

        /// <summary>
        /// Is interactable
        /// </summary>
        bool IsInteractable { get; set; }

        /// <summary>
        /// Is playing on start
        /// </summary>
        bool IsPlayingOnStart { get; set; }

        /// <summary>
        /// Is looping
        /// </summary>
        bool IsLooping { get; set; }

        /// <summary>
        /// Volume
        /// </summary>
        float Volume { get; set; }

        /// <summary>
        /// Is muted
        /// </summary>
        bool IsMuted { get; set; }

        /// <summary>
        /// Is solo
        /// </summary>
        bool IsSolo { get; set; }

        /// <summary>
        /// Is muted through solo
        /// </summary>
        bool IsSoloMuted { get; }

        /// <summary>
        /// Is playing
        /// </summary>
        bool IsPlaying { get; set; }

        /// <summary>
        /// FMOD event instance
        /// </summary>
        EventInstance FMODEventInstance { get; }

        /// <summary>
        /// FMOD event rigid body
        /// </summary>
        Rigidbody FMODEventRigidBody { get; }

        /// <summary>
        /// Play
        /// </summary>
        /// <returns>"true" if successful, otherwise "false"</returns>
        bool Play();

        /// <summary>
        /// Replay
        /// </summary>
        /// <returns>"true" if successful, otherwise "false"</returns>
        bool Replay();

        /// <summary>
        /// Pause
        /// </summary>
        /// <returns>"true" if successful, otherwise "false"</returns>
        bool Pause();

        /// <summary>
        /// Resume
        /// </summary>
        /// <returns>"true" if successful, otherwise "false"</returns>
        bool Resume();

        /// <summary>
        /// Stop
        /// </summary>
        /// <returns>"true" if successful, otherwise "false"</returns>
        bool Stop();

        /// <summary>
        /// Play one shot
        /// </summary>
        void PlayOneShot();
    }
}
