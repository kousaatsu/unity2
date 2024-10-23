using UnityEngine;

namespace Hotdogs
{
    [CreateAssetMenu(fileName = "HotdogSO", menuName = "SO/HotdogSO", order = 1)]
    public class HotdogSO : ScriptableObject
    {
        [field: SerializeField] public string Name { get; private set; }
        [field: SerializeField] public int Weight { get; private set; }
    }
}