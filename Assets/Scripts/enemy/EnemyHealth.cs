using UnityEngine;
using UnityEngine.UI;
using System;

public class EnemyHealth : MonoBehaviour
{
    [HideInInspector]
    public float currentHealt;

    public float maxHealth;

    private Animator anim;

    [SerializeField] private Image enemyHealthBar;

    private LevelHandler levelHandler;

    private void Awake()
    {
        currentHealt = maxHealth;
        anim = GetComponent<Animator>();
        levelHandler = GameObject.FindGameObjectWithTag("Player").GetComponent<LevelHandler>();
    }
    public void TakeDamage(float amount)
    {
        currentHealt -= amount;
        Debug.Log(currentHealt);
        enemyHealthBar.fillAmount = currentHealt / maxHealth;
        if (currentHealt > 0)
        {
            anim.SetTrigger("Hit");
            Debug.Log(amount.ToString());
        }
        if (currentHealt <= 0)
        {
            Destroy(gameObject, 3f);
            levelHandler.EXPHandler(33);
        }
    }
}
