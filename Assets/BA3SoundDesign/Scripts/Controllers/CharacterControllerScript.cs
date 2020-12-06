using System;
using UnityEngine;

/// <summary>
/// BA3 Sound Design controllers namespace
/// </summary>
namespace BA3SoundDesign.Controllers
{
    /// <summary>
    /// Character controller script class
    /// </summary>
    [RequireComponent(typeof(CharacterController))]
    public class CharacterControllerScript : MonoBehaviour, ICharacterController
    {
        /// <summary>
        /// Movement speed
        /// </summary>
        [SerializeField]
        [Range(0.0f, 10.0f)]
        private float movementSpeed = 2.0f;

        /// <summary>
        /// Sprint multiplier
        /// </summary>
        [SerializeField]
        [Range(1.0f, 10.0f)]
        private float sprintMultiplier = 2.0f;

        /// <summary>
        /// Jump height
        /// </summary>
        [SerializeField]
        [Range(0.0f, 10.0f)]
        private float jumpHeight = 1.25f;

        /// <summary>
        /// Minimal pitch angle
        /// </summary>
        [SerializeField]
        [Range(-90.0f, 0.0f)]
        private float minimalPitchAngle = -90.0f;

        /// <summary>
        /// Maximal pitch angle
        /// </summary>
        [SerializeField]
        [Range(0.0f, 90.0f)]
        private float maximalPitchAngle = 90.0f;

        /// <summary>
        /// Maximal look ray distance
        /// </summary>
        [SerializeField]
        [Range(0.0f, 1000.0f)]
        private float maximalLookRayDistance = 20.0f;

        /// <summary>
        /// Character virtual camera transform
        /// </summary>
        [SerializeField]
        private Transform characterVirtualCameraTransform;

        /// <summary>
        /// Movement
        /// </summary>
        private Vector2 movement;

        /// <summary>
        /// Look direction
        /// </summary>
        private Vector2 lookDirection;

        /// <summary>
        /// Look direction delta
        /// </summary>
        private Vector2 lookDirectionDelta;

        /// <summary>
        /// Raycast hits
        /// </summary>
        private RaycastHit[] raycastHits = Array.Empty<RaycastHit>();

        /// <summary>
        /// Movement speed
        /// </summary>
        public float MovementSpeed
        {
            get => Mathf.Max(movementSpeed, 0.0f);
            set => movementSpeed = Mathf.Max(value, 0.0f);
        }

        /// <summary>
        /// Sprint multiplier
        /// </summary>
        public float SprintMultiplier
        {
            get => Mathf.Max(sprintMultiplier, 0.0f);
            set => sprintMultiplier = Mathf.Max(value, 0.0f);
        }

        /// <summary>
        /// Jump height
        /// </summary>
        public float JumpHeight
        {
            get => Mathf.Max(jumpHeight, 0.0f);
            set => jumpHeight = Mathf.Max(value, 0.0f);
        }

        /// <summary>
        /// Minimal pitch angle
        /// </summary>
        public float MinimalPitchAngle
        {
            get => Mathf.Clamp(minimalPitchAngle, -90.0f, 0.0f);
            set => minimalPitchAngle = Mathf.Clamp(value, -90.0f, 0.0f);
        }

        /// <summary>
        /// Maximal pitch angle
        /// </summary>
        public float MaximalPitchAngle
        {
            get => Mathf.Clamp(maximalPitchAngle, 0.0f, 90.0f);
            set => maximalPitchAngle = Mathf.Clamp(value, 0.0f, 90.0f);
        }

        /// <summary>
        /// Maximal look ray distance
        /// </summary>
        public float MaximalLookRayDistance
        {
            get => Mathf.Max(maximalLookRayDistance, 0.0f);
            set => maximalLookRayDistance = Mathf.Max(value, 0.0f);
        }

        /// <summary>
        /// Character virtual ccamera transform
        /// </summary>
        public Transform CharacterVirtualCameraTransform
        {
            get => characterVirtualCameraTransform;
            set => characterVirtualCameraTransform = value;
        }

        /// <summary>
        /// Movement
        /// </summary>
        public Vector2 Movement
        {
            get => movement;
            set => movement = (value.sqrMagnitude > 1.0f) ? value.normalized : value;
        }

        /// <summary>
        /// Look direction
        /// </summary>
        public Vector2 LookDirection
        {
            get => lookDirection;
            set => lookDirection = new Vector2(Mathf.Repeat(value.x, 360.0f - float.Epsilon), Mathf.Clamp(value.y, MinimalPitchAngle, MaximalPitchAngle));
        }

        /// <summary>
        /// Look direction delta
        /// </summary>
        public Vector2 LookDirectionDelta
        {
            get => lookDirectionDelta;
            set => lookDirectionDelta = value;
        }

        /// <summary>
        /// Is sprinting
        /// </summary>
        public bool IsSprinting { get; set; }

        /// <summary>
        /// Gravitational velocity
        /// </summary>
        public Vector3 GravitationalVelocity { get; private set; }

        /// <summary>
        /// Is on ground
        /// </summary>
        public bool IsOnGround { get; private set; }

        /// <summary>
        /// Looking at interactable controller
        /// </summary>
        public InteractableControllerScript LookingAtInteractableController { get; private set; }

        /// <summary>
        /// Looking at interactable controller point
        /// </summary>
        public Vector3 LookingAtInteractableControllerPoint { get; private set; }

        /// <summary>
        /// Looking at FMOD event controller
        /// </summary>
        public FMODEventControllerScript LookingAtFMODEventController { get; private set; }

        /// <summary>
        /// Looking at FMOD event controller point
        /// </summary>
        public Vector3 LookingAtFMODEventControllerPoint { get; private set; }

        /// <summary>
        /// CHaracter controller
        /// </summary>
        public CharacterController CharacterController { get; private set; }

        /// <summary>
        /// Jump
        /// </summary>
        public void Jump()
        {
            if (IsOnGround)
            {
                GravitationalVelocity = new Vector3(GravitationalVelocity.x, Mathf.Sqrt(-2.0f * JumpHeight * Physics.gravity.y), GravitationalVelocity.z);
                IsOnGround = false;
            }
        }

        /// <summary>
        /// Interact
        /// </summary>
        public void Interact()
        {
            if (LookingAtInteractableController)
            {
                LookingAtInteractableController.Interact();
            }
        }

        /// <summary>
        /// Start
        /// </summary>
        private void Start() => CharacterController = GetComponent<CharacterController>();

        /// <summary>
        /// Fixed update
        /// </summary>
        private void FixedUpdate()
        {
            GravitationalVelocity += Physics.gravity * Time.fixedDeltaTime;
            if (CharacterController)
            {
                Vector3 forward = transform.forward;
                forward.y = 0.0f;
                forward.Normalize();
                Vector3 right = transform.right;
                right.y = 0.0f;
                right.Normalize();
                Vector3 world_movement = (right * movement.x) + (forward * movement.y);
                if (world_movement.sqrMagnitude > 1.0f)
                {
                    world_movement.Normalize();
                }
                CollisionFlags collision_flags = CharacterController.Move(((world_movement * MovementSpeed * (IsSprinting ? SprintMultiplier : 1.0f)) + GravitationalVelocity) * Time.fixedDeltaTime);
                IsOnGround = ((collision_flags & CollisionFlags.Below) == CollisionFlags.Below);
                if (IsOnGround && (GravitationalVelocity.y < 0.0f))
                {
                    GravitationalVelocity = new Vector3(GravitationalVelocity.x, 0.0f, GravitationalVelocity.z);
                }
            }
            LookDirection += lookDirectionDelta * Time.fixedDeltaTime;
            transform.localRotation = Quaternion.AngleAxis(lookDirection.x, Vector3.up);
            if (characterVirtualCameraTransform)
            {
                characterVirtualCameraTransform.localRotation = Quaternion.AngleAxis(lookDirection.y, Vector3.right);
                int raycast_hit_count = PhysicsUtilities.RaycastAll(characterVirtualCameraTransform.position, characterVirtualCameraTransform.forward, MaximalLookRayDistance, ref raycastHits);
                LookingAtFMODEventController = null;
                LookingAtInteractableController = null;
                for (int raycast_hit_index = 0; raycast_hit_index < raycast_hit_count; raycast_hit_index++)
                {
                    RaycastHit raycast_hit = raycastHits[raycast_hit_index];
                    if (LookingAtFMODEventController && LookingAtInteractableController)
                    {
                        break;
                    }
                    if (!LookingAtFMODEventController)
                    {
                        FMODEventControllerScript fmod_event_controller = raycast_hit.collider.GetComponentInParent<FMODEventControllerScript>();
                        if (fmod_event_controller)
                        {
                            LookingAtFMODEventController = fmod_event_controller;
                            LookingAtFMODEventControllerPoint = raycast_hit.point;
                        }
                    }
                    if (!LookingAtInteractableController)
                    {
                        InteractableControllerScript interactable_controller = raycast_hit.collider.GetComponentInParent<InteractableControllerScript>();
                        if (interactable_controller)
                        {
                            LookingAtInteractableController = interactable_controller;
                            LookingAtInteractableControllerPoint = raycast_hit.point;
                        }
                    }
                }
            }
        }
    }
}
