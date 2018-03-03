using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyHealth : MonoBehaviour,IHealthPool {

    int health = 255;

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
        health -= damage;
        transform.position  +=new Vector3(damage / 10, 0);

    }

    public void Heal(int health)
    {

    }

    public int GetCurrentHealth()
    {
        return health;
    }




}
