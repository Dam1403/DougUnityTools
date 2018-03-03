using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWeapon{


    float GetFireRate();
    float GetHeatRate();

    void Fire();
    
}
