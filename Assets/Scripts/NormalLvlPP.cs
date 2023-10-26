using UnityEngine;

public class NormalLvlPP : MonoBehaviour
{
    private int _normalLvlpp = 0;
    public int _NormalLvlpp { get { return _normalLvlpp; } set { _normalLvlpp = Mathf.Clamp(value, 0, int.MaxValue); } }
}
