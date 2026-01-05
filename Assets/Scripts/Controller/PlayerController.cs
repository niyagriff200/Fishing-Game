using UnityEngine;

public class PlayerController : Controller
{
    [Header("References")]
    [SerializeField] private PlayerPawn playerPawn;

    public PlayerPawn Pawn
    {
        get { return playerPawn; }
        set
        {
            playerPawn = value;
            if (playerPawn == null)
                Debug.LogWarning("PlayerController.Pawn is being set to null!");
            else
                Debug.Log("PlayerController.Pawn assigned: " + playerPawn.name);
        }
    }

    void Update()
    {
        if (playerPawn == null) return;

        // Cast rod input
        if (!playerPawn.IsCasting && Input.GetKeyDown(KeyCode.C))
        {
            playerPawn.CastRod();
        }

        // Button mash for struggle bar
        if (playerPawn.CurrentStruggleBar != null)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                playerPawn.CurrentStruggleBar.OnPlayerTap();
            }
        }
    }
}
