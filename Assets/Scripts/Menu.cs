using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject CanvasNormal, Canvasdemon, CanvasExtreme;
    [SerializeField] private CalculPP calculPP;

    public void OpenCanvasNormal()
    {
        CanvasNormal.SetActive(true);
        gameObject.SetActive(false);
        calculPP.Reset();
    }

    public void OpenCanvasDemon()
    {
        Canvasdemon.SetActive(true);
        gameObject.SetActive(false);
        calculPP.Reset();
    }

    public void OpenCanvasExtreme()
    {
        CanvasExtreme.SetActive(true);
        gameObject.SetActive(false);
        calculPP.Reset();
    }
}
