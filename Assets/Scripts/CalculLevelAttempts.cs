using TMPro;
using UnityEngine;
using DG.Tweening;

public class CalculLevelAttempts : MonoBehaviour
{
    [SerializeField] private TMP_InputField refLevelPoints, refLevelAttempts, goalLevelPoints;
    [SerializeField] private TextMeshProUGUI goalLevelAttemptsCountText;
    private int goalLevelAttemptsCount;
    [SerializeField] private Ease ease;
    [SerializeField] private float timeAfficheAttempts = 5f;
    private bool isTweening;

    public void CalculAttempts()
    {
        goalLevelAttemptsCount = 0;
        DOTween.Kill("tweenCalculAttempts");
        float resultGoalLevelAttemptsCount = float.Parse(goalLevelPoints.text) / float.Parse(refLevelPoints.text) * float.Parse(refLevelAttempts.text);
        isTweening = true;
        DOTween.To(() => goalLevelAttemptsCount, x => goalLevelAttemptsCount = x, (int)resultGoalLevelAttemptsCount, timeAfficheAttempts)
        .SetEase(ease)
        .OnComplete(() => isTweening = false)
        .OnKill(() => isTweening = false)
        .SetId("tweenCalculAttempts");
    }

    private void Update()
    {
        if (!isTweening) return;
        goalLevelAttemptsCountText.text = goalLevelAttemptsCount.ToString();
    }

    public void Reset()
    {
        DOTween.Kill("tweenCalculAttempts");
        goalLevelPoints.text = "";
        refLevelPoints.text = "";
        refLevelAttempts.text = "";
        goalLevelAttemptsCount = 0;
        goalLevelAttemptsCountText.text = "";
    }
}
