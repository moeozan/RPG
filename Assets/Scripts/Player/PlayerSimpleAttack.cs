using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSimpleAttack : MonoBehaviour
{
    EnemyHealth enemyHealth;
    private void Awake()
    {
        enemyHealth = FindObjectOfType<EnemyHealth>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            enemyHealth.TakeDamage(101);
        }
    }
}
