using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance => instance;

    [Header("Game Screens")]
    [SeralizedField] private GameObject splashScreen;
    public GameObject SplashScreen => splashScreen;

    [SeralizedField] private GameObject mainMenuScreen;
    public GameObject MainMenuScreen => mainMenuScreen;

    [SeralizedField] private GameObject gameplayScreen;
    public GameObject GameplayScreen => gameplayScreen;

    [SeralizedField] private GameObject 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
