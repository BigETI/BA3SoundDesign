using BA3SoundDesign.Controllers;
using BA3SoundDesign.InputActions;

/// <summary>
/// BA3 Sound Design namespace
/// </summary>
namespace BA3SoundDesign
{
    /// <summary>
    /// Player controller interface
    /// </summary>
    public interface IPlayerController
    {
        /// <summary>
        /// Character controller
        /// </summary>
        CharacterControllerScript CharacterController { get; }

        /// <summary>
        /// Game input actions
        /// </summary>
        GameInputActions GameInputActions { get; }
    }
}
