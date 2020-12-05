using BA3SoundDesign.InputActions;
using UnityEngine;

/// <summary>
/// BA3 Sound Design controllers namespace
/// </summary>
namespace BA3SoundDesign.Controllers
{
    /// <summary>
    /// Player controller script class
    /// </summary>
    [RequireComponent(typeof(CharacterControllerScript))]
    public class PlayerControllerScript : MonoBehaviour, IPlayerController
    {
        /// <summary>
        /// Character controller
        /// </summary>
        public CharacterControllerScript CharacterController { get; private set; }

        /// <summary>
        /// Game input actions
        /// </summary>
        public GameInputActions GameInputActions { get; private set; }

        /// <summary>
        /// Awake
        /// </summary>
        private void Awake()
        {
            GameInputActions = new GameInputActions();
            GameInputActions.GameActionMap.Interact.performed += (context) =>
            {
                if (CharacterController)
                {
                    CharacterController.Interact();
                }
            };
            GameInputActions.GameActionMap.Jump.performed += (context) =>
            {
                if (CharacterController)
                {
                    CharacterController.Jump();
                }
            };
            GameInputActions.GameActionMap.Look.performed += (context) =>
            {
                if (CharacterController)
                {
                    CharacterController.LookDirection += context.ReadValue<Vector2>();
                }
            };
            GameInputActions.GameActionMap.LookAnalogue.performed += (context) =>
            {
                if (CharacterController)
                {
                    CharacterController.LookDirectionDelta = context.ReadValue<Vector2>();
                }
            };
            GameInputActions.GameActionMap.Louder.performed += (context) =>
            {
                if (CharacterController && CharacterController.LookingAtFMODEventController)
                {
                    CharacterController.LookingAtFMODEventController.Volume += 0.1f;
                }
            };
            GameInputActions.GameActionMap.Move.performed += (context) =>
            {
                if (CharacterController)
                {
                    CharacterController.Movement = context.ReadValue<Vector2>();
                }
            };
            GameInputActions.GameActionMap.Mute.performed += (context) =>
            {
                if (CharacterController && CharacterController.LookingAtFMODEventController)
                {
                    CharacterController.LookingAtFMODEventController.IsMuted = !CharacterController.LookingAtFMODEventController.IsMuted;
                }
            };
            GameInputActions.GameActionMap.Quieter.performed += (context) =>
            {
                if (CharacterController && CharacterController.LookingAtFMODEventController)
                {
                    CharacterController.LookingAtFMODEventController.Volume -= 0.1f;
                }
            };
            GameInputActions.GameActionMap.Solo.performed += (context) =>
            {
                if (CharacterController && CharacterController.LookingAtFMODEventController)
                {
                    CharacterController.LookingAtFMODEventController.IsSolo = !CharacterController.LookingAtFMODEventController.IsSolo;
                }
            };
            GameInputActions.GameActionMap.Sprint.performed += (context) =>
            {
                if (CharacterController)
                {
                    CharacterController.IsSprinting = context.ReadValueAsButton();
                }
            };
        }

        /// <summary>
        /// On enable
        /// </summary>
        private void OnEnable() => GameInputActions.Enable();

        /// <summary>
        /// On disable
        /// </summary>
        private void OnDisable() => GameInputActions.Disable();

        /// <summary>
        /// Start
        /// </summary>
        private void Start() => CharacterController = GetComponent<CharacterControllerScript>();
    }
}
