using UnityEngine;
using UnityEngine.SceneManagement;

public enum SceneType
{
    MainMenu,
    GameplayOne,
    GameplayTwo
}

public class MainMenuManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeToGameplayOne() => SceneManager.LoadScene(SceneType.GameplayOne.ToString()); 
    public void ChangeToGameplayTwo() => SceneManager.LoadScene(SceneType.GameplayTwo.ToString());
    public void ChangeToMainMenu() => SceneManager.LoadScene(SceneType.MainMenu.ToString());

    public void ChangeScene(SceneType scene)
    {
        Debug.Log(scene.ToString());
    }
}
