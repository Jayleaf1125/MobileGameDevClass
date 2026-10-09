using UnityEngine;

public class CombatSystem : MonoBehaviour
{
    [field: SerializeField] public float Damage;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseDamage(float amount)
    {
        Damage += amount;
    }

    public void DecreaseDamage(float amount)
    {
        Damage -= amount;
    }
}
