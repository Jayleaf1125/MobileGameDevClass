using TMPro;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _scoreText;
    [SerializeField] int _killCounter;
    [SerializeField] int _sceneIndex;
    int _currCounter;

    private void OnEnable()
    {
        PlayerController.OnEnemyKilled += IncreaseCounter;
    }

    private void OnDisable()
    {
        PlayerController.OnEnemyKilled -= IncreaseCounter;
    }

    private void OnValidate()
    {
        if (_scoreText == null) Debug.LogError("Score Text is an empty field");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _currCounter = _killCounter;
        _scoreText.text = _currCounter.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (_currCounter <= 0)
        {
            MainMenuManager.Instance.ChangeScene(sceneIndex: _sceneIndex);
        }
    }

    public void IncreaseCounter()
    {
        _currCounter -= 1;
        _scoreText.text = _currCounter.ToString();
    }
}
