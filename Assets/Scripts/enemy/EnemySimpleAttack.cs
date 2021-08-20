using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySimpleAttack : MonoBehaviour
{
    WanderingAI danamgeFromMonster;
    PlayerHealth playerHealth;
    private void Awake()
    {
        playerHealth = FindObjectOfType<PlayerHealth>();
        danamgeFromMonster = GetComponentInParent<WanderingAI>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerHealth.TakeDamage(danamgeFromMonster.damage);
        }
    }
}
