using UnityEngine;
using UnityEngine.UI;

public class StruggleBar : MonoBehaviour
{
    public Image fillImage;

    private PlayerPawn player;
    private float barValue = 0f;
    private float failTimer = 0f;
    private bool miniGameActive = false;

    public void Initialize(PlayerPawn pawn)
    {
        player = pawn;
        miniGameActive = true;
        barValue = 0f;
        failTimer = 0f;

        if (fillImage != null)
            fillImage.fillAmount = 0f;
    }

    void Update()
    {
        if (!miniGameActive) return;

        // Bar falls constantly
        barValue -= GameManager.Instance.BarFallRate * Time.deltaTime;

        // Clamp bar
        barValue = Mathf.Clamp(barValue, 0f, GameManager.Instance.BarMax);

        // Update UI
        if (fillImage != null)
            fillImage.fillAmount = barValue / GameManager.Instance.BarMax;

        // Fail logic
        if (barValue <= 0f)
        {
            failTimer += Time.deltaTime;
            if (failTimer >= GameManager.Instance.FailThreshold)
                EndMiniGame(false);
        }
        else
        {
            failTimer = 0f;
        }

        // Win logic
        if (barValue >= GameManager.Instance.BarMax)
            EndMiniGame(true);
    }

    // Called by PlayerController when player taps
    public void OnPlayerTap()
    {
        if (!miniGameActive) return;

        barValue += GameManager.Instance.TapAmount;
    }

    private void EndMiniGame(bool success)
    {
        miniGameActive = false;
        player.OnMiniGameComplete(success);
        Destroy(gameObject);
    }
}
