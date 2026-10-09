using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    [SerializeField] float _maxHealh;
    float _currentHealth;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _currentHealth = _maxHealh;    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(float damage)
    {
        float newHealth = _currentHealth - damage;

        if (newHealth <= 0)
        {
            _currentHealth = 0;
            return;
        }

        _currentHealth = newHealth; 
    }

    public void Heal(float amount)
    {
        float newHealth = _currentHealth + amount;

        if (newHealth >= _maxHealh) 
        {
            _currentHealth = _maxHealh;
            return;
        }

        _currentHealth = _maxHealh;
    }
    
    public void IncreaseHealth(float amount)
    {
        _maxHealh += amount;
        _currentHealth = _maxHealh;
    }

    public void DecreaseHealth(float amount)
    {
        _maxHealh -= amount;
        _currentHealth = _maxHealh;
    }
}
