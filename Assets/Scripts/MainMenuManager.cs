using UnityEngine;
using UnityEngine.SceneManagement;

public enum SceneType
{
    MainMenu = 0,
    LevelOne = 1,
    WinOneScene = 2,
    LevelTwo = 3,
    WinTwoScene = 4,
    LevelThree = 5,
    GameOver = 6
}

public class MainMenuManager : MonoBehaviour
{
    public static MainMenuManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeScene(int sceneIndex)
    {
        SceneType scene = (SceneType)sceneIndex;
        SceneManager.LoadScene(scene.ToString());
    }

    public void Quit()
    {
        Application.Quit();
    }
}
