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

    [SerializeField] private GameObject fishOnePrefab;
    public GameObject FishOnePrefab => fishOnePrefab;

    [SerializeField] private GameObject fishTwoPrefab;
    public GameObject FishTwoPrefab => fishTwoPrefab;

    [SerializeField] private GameObject fishThreePrefab;
    public GameObject FishThreePrefab => fishThreePrefab;

    [Header("Fish Settings")]
    [SerializeField] private float minWaitTime;
    public float MinWaitTime => minWaitTime;

    [SerializeField] private float maxWaitTime;
    public float MaxWaitTime => maxWaitTime;

    [SerializeField] private int buttonMashGoal;
    public int ButtonMashGoal => buttonMashGoal;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
