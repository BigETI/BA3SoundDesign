using BA3SoundDesign.InputActions;

/// <summary>
/// BA3 Sound Design namespace
/// </summary>
namespace BA3SoundDesign
{
    /// <summary>
    /// Intro controller
    /// </summary>
    public interface IIntroController : IBehaviour
    {
        /// <summary>
        /// On continued
        /// </summary>
        event ContinuedDelegate OnContinued;

        /// <summary>
        /// Game input actions
        /// </summary>
        GameInputActions GameInputActions { get; }

        /// <summary>
        /// Continue
        /// </summary>
        void Continue();
    }
}
