/// <summary>
/// BA3 SOund DDesign namespace
/// </summary>
namespace BA3SoundDesign
{
    /// <summary>
    /// Character trigger controller interface
    /// </summary>
    public interface ICharacterTriggerController : IBehaviour
    {
        /// <summary>
        /// On trigger entered
        /// </summary>
        event TriggerEnteredDelegate OnTriggerEntered;
    }
}
