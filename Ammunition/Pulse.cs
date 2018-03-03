using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulse : MonoBehaviour,IProjectile {

    //public GameObject ExplosionDecal;


    private Vector3 originVec = Vector3.zero;
    private Vector3 directionVec;
    private Rigidbody body;
    private Vector3 travel_direction;
    private bool launched = false;
    private bool hit = false;
    private Collision the_collision;
    private int TravelSpeed = 90;
    private int PulseDamage = 200;
    // Use this for initialization
    void Start()
    {

        transform.parent = null;

    }


    void OnCollisionEnter(Collision collision)
    {
        hit = true;
        //Debug.Break();
        the_collision = collision;
        Hit();

    }
    // Update is called once per frame
    void Update()
    {
        if (launched)
        {
            Travel();
        }
    }

    public void Launch(Vector3 position,Vector3 direction)
    {

        travel_direction = direction* TravelSpeed;
        body = GetComponent<Rigidbody>();
        body.velocity = travel_direction;
        launched = true;
        
    }

    IEnumerator despawn()
    {
        yield return new WaitForSeconds(.1F);
        Despawn();
    }
    public void Travel()
    {
        
        
    }

    public void Hit()
    {
        //Debug.Log("Hit: " + the_collision.transform.name);
        IHealthPool hithealth = the_collision.transform.GetComponent<IHealthPool>();
        if (hithealth != null)
        {
            //Debug.Log("Damaged: " + the_collision.transform.name);
            hithealth.Damage(PulseDamage);
        }
        Vector3 spawn_point = the_collision.contacts[0].point;
        Despawn();


    }

    public void Despawn()
    {

        gameObject.SetActive(false);
        Destroy(gameObject);
    }







}
