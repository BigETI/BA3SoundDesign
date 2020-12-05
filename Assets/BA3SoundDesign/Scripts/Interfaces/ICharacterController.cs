using BA3SoundDesign.Controllers;
using UnityEngine;

/// <summary>
/// BA3 Sound Design namespace
/// </summary>
namespace BA3SoundDesign
{
    /// <summary>
    /// Character controller interface
    /// </summary>
    public interface ICharacterController : IBehaviour
    {
        /// <summary>
        /// Movement speed
        /// </summary>
        float MovementSpeed { get; set; }

        /// <summary>
        /// Sprint multiplier
        /// </summary>
        float SprintMultiplier { get; set; }

        /// <summary>
        /// Jump height
        /// </summary>
        float JumpHeight { get; set; }

        /// <summary>
        /// Minimal pitch angle
        /// </summary>
        float MinimalPitchAngle { get; set; }

        /// <summary>
        /// Maximal pitch angle
        /// </summary>
        float MaximalPitchAngle { get; set; }

        /// <summary>
        /// Maximal look ray distance
        /// </summary>
        float MaximalLookRayDistance { get; set; }

        /// <summary>
        /// Character virtual ccamera transform
        /// </summary>
        Transform CharacterVirtualCameraTransform { get; set; }

        /// <summary>
        /// Movement
        /// </summary>
        Vector2 Movement { get; set; }

        /// <summary>
        /// Look direction
        /// </summary>
        Vector2 LookDirection { get; set; }

        /// <summary>
        /// Look direction delta
        /// </summary>
        Vector2 LookDirectionDelta { get; set; }

        /// <summary>
        /// Is sprinting
        /// </summary>
        bool IsSprinting { get; set; }

        /// <summary>
        /// Gravitational velocity
        /// </summary>
        Vector3 GravitationalVelocity { get; }

        /// <summary>
        /// Is on ground
        /// </summary>
        bool IsOnGround { get; }

        /// <summary>
        /// Looking at interactable controller
        /// </summary>
        InteractableControllerScript LookingAtInteractableController { get; }

        /// <summary>
        /// Looking at interactable controller point
        /// </summary>
        Vector3 LookingAtInteractableControllerPoint { get; }

        /// <summary>
        /// Looking at FMOD event controller
        /// </summary>
        FMODEventControllerScript LookingAtFMODEventController { get; }

        /// <summary>
        /// Looking at FMOD event controller point
        /// </summary>
        Vector3 LookingAtFMODEventControllerPoint { get; }

        /// <summary>
        /// CHaracter controller
        /// </summary>
        CharacterController CharacterController { get; }

        /// <summary>
        /// Jump
        /// </summary>
        void Jump();

        /// <summary>
        /// Interact
        /// </summary>
        void Interact();
    }
}
