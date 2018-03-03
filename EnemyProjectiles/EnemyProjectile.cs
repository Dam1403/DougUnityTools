using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour,IProjectile {

    Collision the_collision;
    private GameObject collidee;
    public int damage;
    public float damage_cooldown;

    private bool can_take_damage = true;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    void OnTriggerEnter(Collider collider)
    {
        //Debug.Log("HIT");
        collidee = collider.gameObject;
        Hit();

    }
    void OnCollisionEnter(Collision collision)
    {
        the_collision = collision;
        Hit();
    }

    public void Despawn()
    {
    }

    public void Hit()
    {
        //Debug.LogFormat("Collidee: " + collidee.name);
        CarHealth hp = collidee.GetComponent<CarHealth>();
        
        if(hp != null && can_take_damage)
        {
            hp.Damage(damage);
            can_take_damage = false;
            StartCoroutine(DamageCooldown());
        }
    }

    public void Launch(Vector3 position, Vector3 direction)
    {
    }

    public void Travel()
    {
    }

    private IEnumerator DamageCooldown()
    {
        Debug.Log("DMG COOLDOWN");
        yield return new WaitForSeconds(damage_cooldown);
        can_take_damage = true;
        Debug.Log("DMGABLE");
    }

}
