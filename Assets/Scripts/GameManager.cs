using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance => instance;

    [Header("Game Screens")]
    [SerializeField] private GameObject splashScreen;
    public GameObject SplashScreen => splashScreen;

    [SerializeField] private GameObject mainMenuScreen;
    public GameObject MainMenuScreen => mainMenuScreen;

    [SerializeField] private GameObject gameplayScreen;
    public GameObject GameplayScreen => gameplayScreen;

    [SerializeField] private GameObject settingsScreen;
    public GameObject SettingsScreen => settingsScreen;

    [SerializeField] private GameObject creditsScreen;
    public GameObject CreditsScreen => creditsScreen;

    [Header("Prefabs")]
    [SerializeField] private GameObject playerPawnPrefab;
    public GameObject PlayerPawnPrefab => playerPawnPrefab;

    [SerializeField] private GameObject bobberPrefab;
    public GameObject BobberPrefab => bobberPrefab;

    [SerializeField] private StruggleBar struggleBarPrefab;
    public StruggleBar StruggleBarPrefab => struggleBarPrefab;

    [Header("Fish Settings")]
    [SerializeField] private float minWaitTime;
    public float MinWaitTime => minWaitTime;

    [SerializeField] private float maxWaitTime;
    public float MaxWaitTime => maxWaitTime;

    [SerializeField] private int buttonMashGoal;
    public int ButtonMashGoal => buttonMashGoal;

    [SerializeField] private float barFallRate;
    public float BarFallRate => barFallRate;

    [SerializeField] private float tapAmount;
    public float TapAmount => tapAmount;

    [SerializeField] private float failThreshold;
    public float FailThreshold => failThreshold;

    [SerializeField] private float barMax;
    public float BarMax => barMax;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    void Start()
    {
        // Nothing needed yet
    }

    void Update()
    {
        // Nothing needed yet
    }
}
