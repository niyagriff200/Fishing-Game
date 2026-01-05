using UnityEngine;

public class PlayerPawn : Pawn
{
    [Header("References")]
    public Transform dockPoint;

    private GameObject bobberInstance;
    public StruggleBar CurrentStruggleBar { get; private set; } // controller reads this
    public bool IsCasting { get; private set; } = false;

    private bool waitingForNibble = false;
    private float biteTimer = 0f;
    private float biteTime = 0f;

    void Update()
    {
        // Bite timer (fish nibble)
        if (waitingForNibble)
        {
            biteTimer += Time.deltaTime;
            if (biteTimer >= biteTime)
            {
                waitingForNibble = false;
                StartMiniGame();
            }
        }
    }

    public void CastRod()
    {
        if (IsCasting) return;

        IsCasting = true;

        bobberInstance = Instantiate(GameManager.Instance.BobberPrefab, dockPoint.position, Quaternion.identity);

        biteTime = Random.Range(GameManager.Instance.MinWaitTime, GameManager.Instance.MaxWaitTime);
        biteTimer = 0f;
        waitingForNibble = true;
    }

    private void StartMiniGame()
    {
        if (bobberInstance == null) return;

        CurrentStruggleBar = Instantiate(GameManager.Instance.StruggleBarPrefab);
        CurrentStruggleBar.Initialize(this);
    }

    public void OnMiniGameComplete(bool success)
    {
        if (success)
            Debug.Log("Fish Caught!");
        else
            Debug.Log("Fish Escaped!");

        IsCasting = false;
        waitingForNibble = false;

        if (bobberInstance != null) Destroy(bobberInstance);
        if (CurrentStruggleBar != null) Destroy(CurrentStruggleBar.gameObject);

        CurrentStruggleBar = null;
    }
}
