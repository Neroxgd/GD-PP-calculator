using UnityEngine;
using TMPro;

public class NormalLvl : MonoBehaviour
{
    [SerializeField] private NormalLvlPP normalLvlPP;
    [SerializeField] private TextMeshProUGUI demonCountUI;
    [SerializeField] private DemonLvl demonLvl;
    private int _demonCount = 0;
    public int PPad { get; private set; } = 0;

    public void Plus(int PP)
    {
        normalLvlPP._NormalLvlpp += PP;
        PPad += PP;
        if (demonLvl != null)
            demonLvl.SetSpecify();
    }

    public void PlusUI(int nbUI)
    {
        _demonCount = Mathf.Clamp(_demonCount += nbUI, 0, int.MaxValue);
        demonCountUI.text = _demonCount.ToString();
    }

    public void ResetNB()
    {
        normalLvlPP._NormalLvlpp -= PPad;
        PPad = 0;
        _demonCount = 0;
        demonCountUI.text = "0";
    }
}
