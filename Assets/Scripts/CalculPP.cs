using UnityEngine;
using TMPro;

public class CalculPP : MonoBehaviour
{
    [SerializeField] private NormalLvlPP normalLvlPP, demonLvlPP;
    [SerializeField] private GameObject panelCalcul;
    private float tlerp = 0;
    [SerializeField] private AnimationCurve curve;
    private int PP = 0;
    [SerializeField] private TextMeshProUGUI PPUI;
    private bool calcul = false;

    public void CalculPoints()
    {   
        calcul = true;
        panelCalcul.SetActive(true);
    }

    public void ClosePanelCalcul()
    {
        panelCalcul.SetActive(false);
    }

    void Update()
    {
        if (!calcul) return;
        tlerp += 0.1f * Time.deltaTime;
        PP = Mathf.RoundToInt(Mathf.Lerp(0, normalLvlPP._NormalLvlpp + demonLvlPP._NormalLvlpp, curve.Evaluate(tlerp)));
        PPUI.text = PP.ToString();
        if (tlerp >= 1)
        {
            calcul = false;
            tlerp = 0;
        }
    }
    public void Reset()
    {
        tlerp = 0;
        calcul = false;
        PPUI.text = "0";
    }
}
