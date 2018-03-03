using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarHealth : MonoBehaviour,IHealthPool {

    public int health = 100;
    public PlayerTakeDamageEffect damageEffect;
    public TriggerUI endTheGame;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Damage(int damage)
    {
        damageEffect.DamageEffect();
        health -= damage;
        Debug.LogFormat("TOOK DAMAGE: {0}", damage);
        if(health < 0)
        {
            Die();
        }

    }

    public void Heal(int health)
    {

    }

    public int GetCurrentHealth()
    {
        return health;
    }

    public void Die()
    {
        endTheGame.ActivateUI();
        Debug.Log("PlayerDeath");
    }




}
