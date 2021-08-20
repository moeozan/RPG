using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayerHealth : MonoBehaviour
{ 
    public float CurrentHealth { get { return currentHealth; } private set { } }
    [SerializeField]private float maxHealth;
    public float MaxHealth { get { return maxHealth; } private set { } }
    [SerializeField]private float currentDefans;
    private Animator anim;

    private float currentHealth;
    private void Awake()
    {          
        anim = GetComponent<Animator>();
    }

    private void Start()
    {
        currentHealth = maxHealth;

    }

    private void Update()
    {
    }

    public void TakeDamage(float amount)
    {
        amount = DamageCalculation(amount);
    }


    private float DamageCalculation(float amount)
    {//defans ile yansıyan hasarın hesaplanması
        amount *= (100 / (100 + currentDefans));
        Debug.Log(amount + " Hasar alındı");
        HealthHandler(amount);
        return amount;
    }

    private void HealthHandler(float resultDamage)
    {
        currentHealth -= resultDamage;
        //healthImage.fillAmount = currentHealth / maxHealth;
        if (currentHealth <= 0)
        {
            anim.SetBool("Death", true);
        }
    }
} 



