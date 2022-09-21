using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletComponent : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);

        if (!other.TryGetComponent(out EnemyComponent enemy)) return;

        enemy.TakeDamage();
    }
}
