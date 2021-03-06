﻿using BA3SoundDesign.Controllers;
using TMPro;
using UnityEngine;

/// <summary>
/// BA3 Sound Design namespace
/// </summary>
namespace BA3SoundDesign
{
    /// <summary>
    /// FMOD event UI controller interface
    /// </summary>
    public interface IFMODEventUIController : IBehaviour
    {
        /// <summary>
        /// Distance to scale factor
        /// </summary>
        float DistanceToScaleFactor { get; set; }

        /// <summary>
        /// Default colour
        /// </summary>
        Color DefaultColour { get; set; }

        /// <summary>
        /// Muted colour
        /// </summary>
        Color MutedColour { get; set; }

        /// <summary>
        /// Solo colour
        /// </summary>
        Color SoloColour { get; set; }

        /// <summary>
        /// Muted through solo colour
        /// </summary>
        Color SoloMutedColour { get; set; }

        /// <summary>
        /// Muted volume sprite
        /// </summary>
        Sprite MutedVolumeSprite { get; set; }

        /// <summary>
        /// Quiet volume sprite
        /// </summary>
        Sprite QuietVolumeSprite { get; set; }

        /// <summary>
        /// Normal volume sprite
        /// </summary>
        Sprite NormalVolumeSprite { get; set; }

        /// <summary>
        /// Loud volume sprite
        /// </summary>
        Sprite LoudVolumeSprite { get; set; }

        /// <summary>
        /// Muted volume outline sprite
        /// </summary>
        Sprite MutedVolumeOutlineSprite { get; set; }

        /// <summary>
        /// Quiet volume outline sprite
        /// </summary>
        Sprite QuietVolumeOutlineSprite { get; set; }

        /// <summary>
        /// Normal volume outline sprite
        /// </summary>
        Sprite NormalVolumeOutlineSprite { get; set; }

        /// <summary>
        /// Loud volume outline sprite
        /// </summary>
        Sprite LoudVolumeOutlineSprite { get; set; }

        /// <summary>
        /// Information text
        /// </summary>
        TextMeshPro InformationText { get; set; }

        /// <summary>
        /// Volume sprite renderer
        /// </summary>
        SpriteRenderer VolumeSpriteRenderer { get; set; }

        /// <summary>
        /// Volume outline sprite renderer
        /// </summary>
        SpriteRenderer VolumeOutlineSpriteRenderer { get; set; }

        /// <summary>
        /// Volume text
        /// </summary>
        TextMeshPro VolumeText { get; set; }

        /// <summary>
        /// Scale transforms
        /// </summary>
        Transform[] ScaleTransforms { get; set; }

        /// <summary>
        /// Colourise text meshes
        /// </summary>
        TextMeshPro[] ColouriseTextMeshes { get; set; }

        /// <summary>
        /// Colourise sprite renderers
        /// </summary>
        SpriteRenderer[] ColouriseSpriteRenderers { get; set; }

        /// <summary>
        /// Player controller
        /// </summary>
        PlayerControllerScript PlayerController { get; }

        /// <summary>
        /// On shown
        /// </summary>
        event ShownDelegate OnShown;

        /// <summary>
        /// On hidden
        /// </summary>
        event HiddenDelegate OnHidden;
    }
}
