using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// BA3 Sound Design controllers namespace
/// </summary>
namespace BA3SoundDesign.Controllers
{
    /// <summary>
    /// FMOD event UI controller script class
    /// </summary>
    public class FMODEventUIControllerScript : MonoBehaviour, IFMODEventUIController
    {
        /// <summary>
        /// Default colour
        /// </summary>
        [SerializeField]
        private Color defaultColour = Color.white;

        /// <summary>
        /// Muted colour
        /// </summary>
        [SerializeField]
        private Color mutedColour = Color.red;

        /// <summary>
        /// Solo colour
        /// </summary>
        [SerializeField]
        private Color soloColour = Color.cyan;

        /// <summary>
        /// Muted through solo colour
        /// </summary>
        [SerializeField]
        private Color soloMutedColour = Color.yellow;

        /// <summary>
        /// Muted volume sprite
        /// </summary>
        [SerializeField]
        private Sprite mutedVolumeSprite = default;

        /// <summary>
        /// Quiet volume sprite
        /// </summary>
        [SerializeField]
        private Sprite quietVolumeSprite = default;

        /// <summary>
        /// Normal volume sprite
        /// </summary>
        [SerializeField]
        private Sprite normalVolumeSprite = default;

        /// <summary>
        /// Loud volume sprite
        /// </summary>
        [SerializeField]
        private Sprite loudVolumeSprite = default;

        /// <summary>
        /// Information text
        /// </summary>
        [SerializeField]
        private TextMeshPro informationText = default;

        /// <summary>
        /// Volume sprite renderer
        /// </summary>
        [SerializeField]
        private SpriteRenderer volumeSpriteRenderer = default;

        /// <summary>
        /// Volume text
        /// </summary>
        [SerializeField]
        private TextMeshPro volumeText = default;

        /// <summary>
        /// Colourise text meshes
        /// </summary>
        [SerializeField]
        private TextMeshPro[] colouriseTextMeshes = Array.Empty<TextMeshPro>();

        /// <summary>
        /// Colourise sprite renderer
        /// </summary>
        [SerializeField]
        private SpriteRenderer[] colouriseSpriteRenderer = Array.Empty<SpriteRenderer>();

        /// <summary>
        /// On shown
        /// </summary>
        [SerializeField]
        private UnityEvent onShown = default;

        /// <summary>
        /// On hidden
        /// </summary>
        [SerializeField]
        private UnityEvent onHidden = default;

        /// <summary>
        /// Last is showing
        /// </summary>
        private bool lastIsShowing;

        /// <summary>
        /// Last volume
        /// </summary>
        private float lastVolume = 0.0f;

        /// <summary>
        /// Default colour
        /// </summary>
        public Color DefaultColour
        {
            get => defaultColour;
            set => defaultColour = value;
        }

        /// <summary>
        /// Muted colour
        /// </summary>
        public Color MutedColour
        {
            get => mutedColour;
            set => mutedColour = value;
        }

        /// <summary>
        /// Solo colour
        /// </summary>
        public Color SoloColour
        {
            get => soloColour;
            set => soloColour = value;
        }

        /// <summary>
        /// Muted through solo colour
        /// </summary>
        public Color SoloMutedColour
        {
            get => soloMutedColour;
            set => soloMutedColour = value;
        }

        /// <summary>
        /// Muted volume sprite
        /// </summary>
        public Sprite MutedVolumeSprite
        {
            get => mutedVolumeSprite;
            set => mutedVolumeSprite = value;
        }

        /// <summary>
        /// Quiet volume sprite
        /// </summary>
        public Sprite QuietVolumeSprite
        {
            get => quietVolumeSprite;
            set => quietVolumeSprite = value;
        }

        /// <summary>
        /// Normal volume sprite
        /// </summary>
        public Sprite NormalVolumeSprite
        {
            get => normalVolumeSprite;
            set => normalVolumeSprite = value;
        }

        /// <summary>
        /// Loud volume sprite
        /// </summary>
        public Sprite LoudVolumeSprite
        {
            get => loudVolumeSprite;
            set => loudVolumeSprite = value;
        }

        /// <summary>
        /// Information text
        /// </summary>
        public TextMeshPro InformationText
        {
            get => informationText;
            set => informationText = value;
        }

        /// <summary>
        /// Volume sprite renderer
        /// </summary>
        public SpriteRenderer VolumeSpriteRenderer
        {
            get => volumeSpriteRenderer;
            set => volumeSpriteRenderer = value;
        }

        /// <summary>
        /// Volume text
        /// </summary>
        public TextMeshPro VolumeText
        {
            get => volumeText;
            set => volumeText = value;
        }

        /// <summary>
        /// Colourise text meshes
        /// </summary>
        public TextMeshPro[] ColouriseTextMeshes
        {
            get => colouriseTextMeshes ?? Array.Empty<TextMeshPro>();
            set => colouriseTextMeshes = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Colourise sprite renderers
        /// </summary>
        public SpriteRenderer[] ColouriseSpriteRenderers
        {
            get => colouriseSpriteRenderer ?? Array.Empty<SpriteRenderer>();
            set => colouriseSpriteRenderer = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Player controller
        /// </summary>
        public PlayerControllerScript PlayerController { get; private set; }

        /// <summary>
        /// On shown
        /// </summary>
        public event ShownDelegate OnShown;

        /// <summary>
        /// On hidden
        /// </summary>
        public event HiddenDelegate OnHidden;

        /// <summary>
        /// Start
        /// </summary>
        private void Start() => PlayerController = FindObjectOfType<PlayerControllerScript>();

        /// <summary>
        /// Update
        /// </summary>
        private void Update()
        {
            if (PlayerController && PlayerController.CharacterController && PlayerController.CharacterController.CharacterVirtualCameraTransform)
            {
                CharacterControllerScript character_controller = PlayerController.CharacterController;
                Transform character_virtual_camera_transform = character_controller.CharacterVirtualCameraTransform;
                FMODEventControllerScript looking_at_fmod_event_controller = character_controller.LookingAtFMODEventController;
                bool is_fmod_event_controller_available = looking_at_fmod_event_controller;
                if (is_fmod_event_controller_available)
                {
                    transform.position = looking_at_fmod_event_controller.transform.position;
                    transform.rotation = Quaternion.LookRotation(character_virtual_camera_transform.forward, character_virtual_camera_transform.up);
                    if (informationText && (informationText.text != looking_at_fmod_event_controller.EventName))
                    {
                        informationText.text = looking_at_fmod_event_controller.EventName;
                    }
                    if (volumeSpriteRenderer)
                    {
                        if (looking_at_fmod_event_controller.IsMuted || looking_at_fmod_event_controller.IsSoloMuted)
                        {
                            volumeSpriteRenderer.sprite = mutedVolumeSprite;
                        }
                        else if (looking_at_fmod_event_controller.Volume >= 0.75f)
                        {
                            volumeSpriteRenderer.sprite = loudVolumeSprite;
                        }
                        else if (looking_at_fmod_event_controller.Volume >= 0.25f)
                        {
                            volumeSpriteRenderer.sprite = normalVolumeSprite;
                        }
                        else if (looking_at_fmod_event_controller.Volume > float.Epsilon)
                        {
                            volumeSpriteRenderer.sprite = quietVolumeSprite;
                        }
                        else
                        {
                            volumeSpriteRenderer.sprite = mutedVolumeSprite;
                        }
                    }
                    if (volumeText && (lastVolume != looking_at_fmod_event_controller.Volume))
                    {
                        lastVolume = looking_at_fmod_event_controller.Volume;
                        volumeText.text = $"{ Mathf.RoundToInt(lastVolume * 100.0f) }%";
                    }
                    Color color = defaultColour;
                    if (looking_at_fmod_event_controller.IsMuted)
                    {
                        color = mutedColour;
                    }
                    else if (looking_at_fmod_event_controller.IsSoloMuted)
                    {
                        color = soloMutedColour;
                    }
                    else if (looking_at_fmod_event_controller.IsSolo)
                    {
                        color = soloColour;
                    }
                    foreach (TextMeshPro colourise_text_mesh in ColouriseTextMeshes)
                    {
                        if (colourise_text_mesh)
                        {
                            colourise_text_mesh.color = color;
                        }
                    }
                    foreach (SpriteRenderer colourise_sprite_renderer in colouriseSpriteRenderer)
                    {
                        if (colourise_sprite_renderer)
                        {
                            colourise_sprite_renderer.color = color;
                        }
                    }
                }
                if (lastIsShowing != is_fmod_event_controller_available)
                {
                    lastIsShowing = is_fmod_event_controller_available;
                    if (is_fmod_event_controller_available)
                    {
                        if (onShown != null)
                        {
                            onShown.Invoke();
                        }
                        OnShown?.Invoke();
                    }
                    else
                    {
                        if (onHidden != null)
                        {
                            onHidden.Invoke();
                        }
                        OnHidden?.Invoke();
                    }
                }
            }
        }
    }
}
