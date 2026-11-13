using UnityEngine;

public enum Direction
{ 
    Left, 
    Right
};


public class EnemyController : MonoBehaviour
{

    Direction _chosenDirection = Direction.Left;
    [SerializeField, Range(0f, 1f)] float _speed;
    Vector3 _movementPos;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _movementPos = new Vector3(_speed, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        IntialMovement();
    }

    void IntialMovement()
    {
        switch (_chosenDirection)
        {
            case Direction.Left:
                this.transform.position -= _movementPos;
                break;
            case Direction.Right:
                this.transform.position += _movementPos;
                break;
        }
    }

    public void Intialize(Direction direction)
    {
        SetDirection(direction);
    }

    void SetDirection(Direction direction) => _chosenDirection = direction;

    private void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.CompareTag("Player"))
        //{
        //    MainMenuManager.Instance.ChangeScene(sceneIndex: 6);
        //}
        Debug.Log("Touch");
    }
}
