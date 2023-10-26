using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] private CalculPP calculPP;

    public void OpenCanvasNormal()
    {
        calculPP.Reset();
    }

    public void OpenCanvasDemon()
    {
        calculPP.Reset();
    }

    public void OpenCanvasExtreme()
    {
        calculPP.Reset();
    }
}
