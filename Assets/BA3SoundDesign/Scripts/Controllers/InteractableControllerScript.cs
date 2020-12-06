using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// BA3 Sound Design controllers namespace
/// </summary>
namespace BA3SoundDesign.Controllers
{
    /// <summary>
    /// Interactable controller script class
    /// </summary>
    public class InteractableControllerScript : MonoBehaviour, IInteractableController
    {
        /// <summary>
        /// On interacted
        /// </summary>
        [SerializeField]
        private UnityEvent onInteracted = default;

        /// <summary>
        /// On interacted
        /// </summary>
        public event InteractedDelegate OnInteracted;

        /// <summary>
        /// Interact
        /// </summary>
        public void Interact()
        {
            if (onInteracted != null)
            {
                onInteracted.Invoke();
            }
            OnInteracted?.Invoke();
        }
    }
}
