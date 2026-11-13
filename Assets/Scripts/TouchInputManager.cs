using UnityEngine;

public class TouchInputManager : MonoBehaviour
{
    [SerializeField] GameObject _mainCamera;
    [SerializeField] GameObject _playerObj;

    PlayerController _playerController;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _playerObj.transform.position = new Vector3(0f, 1.03f, -5.97f);
        _mainCamera.transform.position = new Vector3(0f, 2.25f, -13.02f);

        _playerController = _playerObj.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayerRightClick()
    {
        //_playerObj.transform.position += new Vector3(1f, 0f, 0f);
        //_mainCamera.transform.position += new Vector3(1f, 0f, 0f);
        _playerController.Right_Hitbox_Detection(camera: _mainCamera);
    }

    public void PlayerLeftClick()
    {
        //_playerObj.transform.position -= new Vector3(1f, 0f, 0f);
        //_mainCamera.transform.position -= new Vector3(1f, 0f, 0f);
        _playerController.Left_Hitbox_Detection(camera: _mainCamera);
    }
}
