using UnityEngine;

public class DetectionSignalController : MonoBehaviour
{
    [SerializeField] GameObject _rightImageDetectionSignal;
    [SerializeField] GameObject _leftImageDetectionSignal;

    public static DetectionSignalController Instance { get; private set; }

    private void OnEnable()
    {

    }

    private void OnDisable()
    {

    }

    private void Awake()
    {
        Instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TurnOffRight();
        TurnOffLeft();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TurnOnLeft() =>  _leftImageDetectionSignal.SetActive(true);
    public void TurnOffLeft() => _leftImageDetectionSignal.SetActive(false);

    public void TurnOnRight() => _rightImageDetectionSignal.SetActive(true);
    public void TurnOffRight() => _rightImageDetectionSignal.SetActive(false);
}
