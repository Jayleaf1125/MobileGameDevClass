using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region ENEMY_KILLED
    public static event Action OnEnemyKilled = delegate { };
    #endregion

    Vector3 _origin;
    Vector3 _rightDirection = Vector3.right;
    Vector3 _leftDirection = -Vector3.right;

    RaycastHit _leftHitInfo;
    RaycastHit _rightHitInfo;

    bool _isLeftSideValid = false;
    bool _isRightSideValid = false;
    float _rayDist = 10f;

    [SerializeField] LayerMask _enemyLayer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _origin = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Left
        if (Physics.Raycast(_origin, _leftDirection, out _leftHitInfo, maxDistance: _rayDist, layerMask: _enemyLayer))
        {
            DetectionSignalController.Instance.TurnOnLeft();
            _isLeftSideValid = true;
        }
        else
        {
            DetectionSignalController.Instance.TurnOffLeft();
            _isLeftSideValid = false;
        }

        // Right
        if (Physics.Raycast(_origin, _rightDirection, out _rightHitInfo, maxDistance: _rayDist, layerMask: _enemyLayer))
        {
            DetectionSignalController.Instance.TurnOnRight();
            _isRightSideValid = true;
        }
        else
        {
            DetectionSignalController.Instance.TurnOffRight();
            _isRightSideValid = false;
        }
    }

    public void Right_Hitbox_Detection(GameObject camera)
    {
        // If right side is valid, attack the enenmy
        if (!_isRightSideValid)
        {
            Debug.Log("Invalid Hit");
            return;
        }

        Vector3 enemyPos = _rightHitInfo.point;
        Vector3 enemyPosOnX = new Vector3(enemyPos.x, camera.transform.position.y, camera.transform.position.z);

        this.transform.position = enemyPos;
        camera.transform.position = enemyPosOnX;

        SoundManager.Instance.PlayUnquieSound(Sound.Player_Hit);
        Destroy(_rightHitInfo.collider.gameObject);
        OnEnemyKilled.Invoke();
    }

    public void Left_Hitbox_Detection(GameObject camera)
    {
        // If left side is valid, attack the enenmy
        if (!_isLeftSideValid)
        {
            Debug.Log("Invalid Hit");
            return;
        }

        Vector3 enemyPos = _leftHitInfo.point;
        Vector3 enemyPosOnX = new Vector3(enemyPos.x, camera.transform.position.y, camera.transform.position.z);

        this.transform.position = enemyPos;
        camera.transform.position = enemyPosOnX;

        SoundManager.Instance.PlayUnquieSound(Sound.Player_Hit);
        Destroy(_leftHitInfo.collider.gameObject);
        OnEnemyKilled.Invoke();
    }
}
