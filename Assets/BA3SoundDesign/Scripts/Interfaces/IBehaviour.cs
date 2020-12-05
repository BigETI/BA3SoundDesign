using UnityEngine;

/// <summary>
/// BA3 Sound Design namespace
/// </summary>
namespace BA3SoundDesign
{
    public interface IBehaviour
    {
        string name { get; set; }

        Transform transform { get; }
    }
}
