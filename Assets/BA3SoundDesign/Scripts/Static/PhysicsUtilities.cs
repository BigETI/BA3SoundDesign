using UnityEngine;

/// <summary>
/// BA3 Sound Design namespace
/// </summary>
namespace BA3SoundDesign
{
    /// <summary>
    /// Physics utilities class
    /// </summary>
    public static class PhysicsUtilities
    {
        /// <summary>
        /// Minimal raycast hit allocation size
        /// </summary>
        private static readonly uint minimalRaycastHitAllocationSize = 128;

        /// <summary>
        /// Raycast all object
        /// </summary>
        /// <param name="origin">Ray origin</param>
        /// <param name="direction">Ray direction</param>
        /// <param name="maximalDistance">Maximal distance</param>
        /// <param name="results">Raycast hit results</param>
        /// <returns>Number of raycast hits</returns>
        public static int RaycastAll(Vector3 origin, Vector3 direction, float maximalDistance, ref RaycastHit[] results)
        {
            if ((results == null) || results.Length < minimalRaycastHitAllocationSize)
            {
                results = new RaycastHit[minimalRaycastHitAllocationSize];
            }
            int ret;
            while ((ret = Physics.RaycastNonAlloc(origin, direction, results, maximalDistance)) >= results.Length)
            {
                results = new RaycastHit[results.Length * 2];
            }
            return ret;
        }
    }
}
