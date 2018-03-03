using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHealthPool {


    int GetCurrentHealth();

    void Damage(int damage);

    void Heal(int health);
}
