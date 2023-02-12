using UnityEngine;
using TMPro;

public class DemonLvl : MonoBehaviour
{
    [SerializeField] private NormalLvlPP normalLvlPP;
    [SerializeField] private TextMeshProUGUI demonCountUI;
    [SerializeField] private GameObject panelSpecify;
    [SerializeField] private NormalLvl low, mid, high;
    private int _demonCount = 0;
    private int PPad = 0;


    public void SetSpecify()
    {
        _demonCount = 0;
        demonCountUI.text = "Specified";
        normalLvlPP._NormalLvlpp -= PPad;
    }

    public void Plus(int PP)
    {
        if (low.PPad != 0 || mid.PPad != 0 || high.PPad != 0) return;
        normalLvlPP._NormalLvlpp += PP;
        PPad += PP;
    }

    public void PlusUI(int nbUI)
    {
        if (low.PPad != 0 || mid.PPad != 0 || high.PPad != 0) return;
        _demonCount = Mathf.Clamp(_demonCount += nbUI, 0, int.MaxValue);
        demonCountUI.text = _demonCount.ToString();
    }

    public void ResetNB()
    {
        normalLvlPP._NormalLvlpp -= PPad;
        PPad = 0;
        _demonCount = 0;
        demonCountUI.text = "0";
        low.ResetNB(); mid.ResetNB(); high.ResetNB();
    }

    public void OpenSpecify()
    {
        panelSpecify.SetActive(!panelSpecify.activeInHierarchy);
    }
}
