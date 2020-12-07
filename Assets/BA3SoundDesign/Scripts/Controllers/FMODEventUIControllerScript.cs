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
        /// Distance to scale factor
        /// </summary>
        [SerializeField]
        [Range(0.0f, 10.0f)]
        private float distanceToScaleFactor = 0.1875f;

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
        /// Muted volume outline sprite
        /// </summary>
        [SerializeField]
        private Sprite mutedVolumeOutlineSprite = default;

        /// <summary>
        /// Quiet volume outline sprite
        /// </summary>
        [SerializeField]
        private Sprite quietVolumeOutlineSprite = default;

        /// <summary>
        /// Normal volume outline sprite
        /// </summary>
        [SerializeField]
        private Sprite normalVolumeOutlineSprite = default;

        /// <summary>
        /// Loud volume outline sprite
        /// </summary>
        [SerializeField]
        private Sprite loudVolumeOutlineSprite = default;

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
        /// Volume outline sprite renderer
        /// </summary>
        [SerializeField]
        private SpriteRenderer volumeOutlineSpriteRenderer = default;

        /// <summary>
        /// Volume text
        /// </summary>
        [SerializeField]
        private TextMeshPro volumeText = default;

        /// <summary>
        /// Scale transforms
        /// </summary>
        [SerializeField]
        private Transform[] scaleTransforms = Array.Empty<Transform>();

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
        /// Distance to scale factor
        /// </summary>
        public float DistanceToScaleFactor
        {
            get => Mathf.Max(distanceToScaleFactor, 0.0f);
            set => distanceToScaleFactor = Mathf.Max(value, 0.0f);
        }

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
        /// Muted volume outline sprite
        /// </summary>
        public Sprite MutedVolumeOutlineSprite
        {
            get => mutedVolumeOutlineSprite;
            set => mutedVolumeOutlineSprite = value;
        }

        /// <summary>
        /// Quiet volume outline sprite
        /// </summary>
        public Sprite QuietVolumeOutlineSprite
        {
            get => quietVolumeOutlineSprite;
            set => quietVolumeOutlineSprite = value;
        }

        /// <summary>
        /// Normal volume outline sprite
        /// </summary>
        public Sprite NormalVolumeOutlineSprite
        {
            get => normalVolumeOutlineSprite;
            set => normalVolumeOutlineSprite = value;
        }

        /// <summary>
        /// Loud volume outline sprite
        /// </summary>
        public Sprite LoudVolumeOutlineSprite
        {
            get => loudVolumeOutlineSprite;
            set => loudVolumeOutlineSprite = value;
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
        /// Volume outline sprite renderer
        /// </summary>
        public SpriteRenderer VolumeOutlineSpriteRenderer
        {
            get => volumeOutlineSpriteRenderer;
            set => volumeOutlineSpriteRenderer = value;
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
        /// Scale transforms
        /// </summary>
        public Transform[] ScaleTransforms
        {
            get => scaleTransforms ?? Array.Empty<Transform>();
            set => scaleTransforms = value ?? throw new ArgumentNullException(nameof(value));
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
            if (!PlayerController)
            {
                PlayerController = FindObjectOfType<PlayerControllerScript>();
            }
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
                    if (volumeSpriteRenderer && volumeOutlineSpriteRenderer)
                    {
                        if (looking_at_fmod_event_controller.IsMuted || looking_at_fmod_event_controller.IsSoloMuted)
                        {
                            volumeSpriteRenderer.sprite = mutedVolumeSprite;
                            volumeOutlineSpriteRenderer.sprite = mutedVolumeOutlineSprite;
                        }
                        else if (looking_at_fmod_event_controller.Volume >= 0.75f)
                        {
                            volumeSpriteRenderer.sprite = loudVolumeSprite;
                            volumeOutlineSpriteRenderer.sprite = loudVolumeOutlineSprite;
                        }
                        else if (looking_at_fmod_event_controller.Volume >= 0.25f)
                        {
                            volumeSpriteRenderer.sprite = normalVolumeSprite;
                            volumeOutlineSpriteRenderer.sprite = normalVolumeOutlineSprite;
                        }
                        else if (looking_at_fmod_event_controller.Volume > float.Epsilon)
                        {
                            volumeSpriteRenderer.sprite = quietVolumeSprite;
                            volumeOutlineSpriteRenderer.sprite = quietVolumeOutlineSprite;
                        }
                        else
                        {
                            volumeSpriteRenderer.sprite = mutedVolumeSprite;
                            volumeOutlineSpriteRenderer.sprite = mutedVolumeOutlineSprite;
                        }
                    }
                    if (volumeText && (lastVolume != looking_at_fmod_event_controller.Volume))
                    {
                        lastVolume = looking_at_fmod_event_controller.Volume;
                        volumeText.text = $"{ Mathf.RoundToInt(lastVolume * 100.0f) }%";
                    }
                    float distance_to_scale_factor = DistanceToScaleFactor;
                    //float distance = (character_controller.LookingAtFMODEventControllerPoint - character_virtual_camera_transform.position).magnitude;
                    float distance = (transform.position - character_virtual_camera_transform.position).magnitude;
                    Vector3 scale = Vector3.one * (distance * distance_to_scale_factor);
                    foreach (Transform scale_transform in ScaleTransforms)
                    {
                        if (scale_transform)
                        {
                            scale_transform.localScale = scale;
                        }
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
