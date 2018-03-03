using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhaseCannon : MonoBehaviour,IWeapon {

    public float fire_rate;
    public float heat_rate;
    public GameObject ProjectileObject;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public float GetFireRate()
    {
        return fire_rate;
    }

    public float GetHeatRate()
    {
        return heat_rate;
    }

    public void Fire()
    {
        IProjectile projectile = GameObject.Instantiate(ProjectileObject,transform).GetComponent<IProjectile>();
        Vector3 localDirection = transform.rotation * transform.forward;

        projectile.Launch(transform.position, transform.TransformDirection(Vector3.forward));

    }
}
