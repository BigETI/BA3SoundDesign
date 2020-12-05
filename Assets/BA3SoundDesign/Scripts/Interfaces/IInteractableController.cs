/// <summary>
/// BA3 Sound Design namespace
/// </summary>
namespace BA3SoundDesign
{
    /// <summary>
    /// Interactable controller interface
    /// </summary>
    public interface IInteractableController : IBehaviour
    {
        /// <summary>
        /// On interacted
        /// </summary>
        event InteractedDelegate OnInteracted;

        /// <summary>
        /// Interact
        /// </summary>
        void Interact();
    }
}
