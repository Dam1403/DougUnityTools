using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour,IHealthPool {
    private int health;
	// Use this for initialization
	void Start () {
        health = 1000;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Damage(int damage)
    {
        health -= damage;
    }


    public void Heal(int heal_amount)
    {
        health += heal_amount;
    }

    public int GetCurrentHealth()
    {
        return health;
    }
}
