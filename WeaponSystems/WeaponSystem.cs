using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSystem : MonoBehaviour {

    public float heat = 0.0f;
    public float decay = 1.0F;






    private float fire_timer = 0.0F;
    private bool firing = false;

    public GameObject WeaponObject;
    private IWeapon CurrentWeapon;
    private float current_weapon_firerate;
    private float current_weapon_heatrate;



    // Use this for initialization
    void Start () {
        CurrentWeapon = WeaponObject.GetComponent<IWeapon>();
        fire_timer = CurrentWeapon.GetFireRate();
    }
	
	// Update is called once per frame
    // Fix framerate nuke eventually
	void Update () {

        if (decay > heat)
        {
            heat = 0.0f;
        }
        else
        {
            heat -= (decay + Time.deltaTime);
        }


        if (firing)
        {
            current_weapon_firerate = CurrentWeapon.GetFireRate();
            current_weapon_heatrate = CurrentWeapon.GetHeatRate();

            fire_timer += Time.deltaTime;
            if(fire_timer > current_weapon_firerate)
            {
                CurrentWeapon.Fire();
                heat += current_weapon_heatrate;
                fire_timer = 0;
            }
        }
        else
        {
        }


    }


    public void StartFiring()
    {
        firing = true;
        
    }

    public void StopFiring()
    {
        fire_timer = 0.0F;
        firing = false;
    }
}
