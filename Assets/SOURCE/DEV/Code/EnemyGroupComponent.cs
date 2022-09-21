using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGroupComponent : MonoBehaviour
{
    [SerializeField] private EnemyComponent[] enemies;

    public void InitGroup()
    {
        enemies = GetComponentsInChildren<EnemyComponent>();

        foreach (var enemy in enemies)
        {
            enemy.Init();
        }
    }

    public bool FindAliveEnemy()
    {
        int enemyCounter = 0;

        foreach (var enemy in enemies)
        {
            if (enemy.CurrentHealth > 0)
                enemyCounter++;
        }

        if (enemyCounter > 0)
            return false;
        else
            return true;
    }
}
