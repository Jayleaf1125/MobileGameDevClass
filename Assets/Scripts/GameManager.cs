using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [field: SerializeField] public List<BuffCardSO> EnemyBuffCardList { get; private set; } = new List<BuffCardSO>();
    [field: SerializeField] public List<BuffCardSO> PlayerBuffCardList { get; private set; } = new List<BuffCardSO>();

    [SerializeField] GameObject _player;
    [SerializeField] GameObject _enemy;

    private void Start()
    {
        HealthSystem playerHS = _player.GetComponent<HealthSystem>();
        HealthSystem enemyHS = _enemy.GetComponent<HealthSystem>();

        CombatSystem playerCS = _player.GetComponent<CombatSystem>();
        CombatSystem enemyCS = _enemy.GetComponent<CombatSystem>();

        foreach (BuffCardSO card in EnemyBuffCardList)
        {
            foreach (KeyValuePair<BuffTypes, int> kp in card.BuffDict)
            {
                switch (kp.Key)
                {
                    case BuffTypes.IncreaseHealth:
                        enemyHS.IncreaseHealth(kp.Value);
                        break;
                    case BuffTypes.DecreasHealth:
                        enemyHS.DecreaseHealth(kp.Value);
                        break;
                    case BuffTypes.IncreaseDamage:
                        enemyCS.IncreaseDamage(kp.Value);
                        break;
                    case BuffTypes.DecreasDamage:
                        enemyCS.DecreaseDamage(kp.Value);
                        break;
                }
            }
        }

        foreach (BuffCardSO card in PlayerBuffCardList)
        {
            foreach (KeyValuePair<BuffTypes, int> kp in card.BuffDict)
            {
                switch (kp.Key)
                {
                    case BuffTypes.IncreaseHealth:
                        playerHS.IncreaseHealth(kp.Value);
                        break;
                    case BuffTypes.DecreasHealth:
                        playerHS.DecreaseHealth(kp.Value);
                        break;
                    case BuffTypes.IncreaseDamage:
                        playerCS.IncreaseDamage(kp.Value);
                        break;
                    case BuffTypes.DecreasDamage:
                        playerCS.DecreaseDamage(kp.Value);
                        break;
                }
            }
        }
    }
}
