using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// BA3 Sound Design
/// </summary>
namespace BA3SoundDesign.Controllers
{
    /// <summary>
    /// Character trigger controller script class
    /// </summary>
    public class CharacterTriggerControllerScript : MonoBehaviour, ICharacterTriggerController
    {
        /// <summary>
        /// On trigger entered
        /// </summary>
        [SerializeField]
        private UnityEvent onTriggerEntered = default;

        /// <summary>
        /// On trigger entered
        /// </summary>
        public event TriggerEnteredDelegate OnTriggerEntered;

        /// <summary>
        /// On trigger enter
        /// </summary>
        /// <param name="other">Other</param>
        private void OnTriggerEnter(Collider other)
        {
            if (other.GetComponentInParent<CharacterControllerScript>() != null)
            {
                if (onTriggerEntered != null)
                {
                    onTriggerEntered.Invoke();
                }
                OnTriggerEntered?.Invoke();
            }
        }
    }
}
