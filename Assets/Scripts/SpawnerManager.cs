using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    // Spawner
    [SerializeField] Transform _leftSpawnerPos;
    [SerializeField] Transform _rightSpawnerPos;

    [SerializeField] GameObject _enemyPrefab;

    // Timer
    float _currentTimer = 0f;
    [SerializeField] float _timer;
    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Left
        Spawn(pos: _leftSpawnerPos, direction: Direction.Left);
        // RIght
        Spawn(pos: _rightSpawnerPos, direction: Direction.Right);
    }

    // Update is called once per frame
    void Update()
    {
        Timer();
    }

    void Spawn(Transform pos, Direction direction)
    {
        GameObject enemy = Instantiate(_enemyPrefab, pos.position, Quaternion.identity);

        EnemyController enemyController = enemy.GetComponent<EnemyController>();
        enemyController.Intialize(direction: direction);
    }
    void Timer()
    {
        _currentTimer += Time.deltaTime;

        if (_currentTimer >= _timer)
        {
            // Left
            Spawn(pos: _leftSpawnerPos, direction: Direction.Left);
            // RIght
            Spawn(pos: _rightSpawnerPos, direction: Direction.Right);
            // Reset Timer
            _currentTimer = 0f;
        }
    }

    private void OnDrawGizmos()
    {
        const float RADIUS = 1f;

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(_leftSpawnerPos.position, RADIUS);

        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(_rightSpawnerPos.position, RADIUS);
    }

}
