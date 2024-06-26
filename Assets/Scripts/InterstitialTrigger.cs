using UnityEngine;
using UnityEngine.UI;

public class InterstitialTrigger : MonoBehaviour
{
    [SerializeField] private Button showInterstitialButton;
    [SerializeField] private Text interstitialTimerTextField;
    [SerializeField] private float delayBetweenInterstitials = 10f;

    private float interstitialDisplayTime = 0;

    private void Update()
    {
        if (Time.time - interstitialDisplayTime > delayBetweenInterstitials)
        {
            interstitialDisplayTime = Time.time;
            showInterstitialButton.onClick.Invoke();
        }

        interstitialTimerTextField.text = $"Interstitial cooldown: {delayBetweenInterstitials - (Time.time - interstitialDisplayTime):0.0}";
    }
}