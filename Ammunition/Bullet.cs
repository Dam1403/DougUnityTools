using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour,IProjectile {

    public GameObject BulletHoleDecal;
    private Vector3 originVec = Vector3.zero;
    private Vector3 directionVec;
    private int BulletDamage = 50;

    // Use this for initialization
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Launch(Vector3 position,Vector3 direction)
    {
        RaycastHit rayhit;
        //look into collision layers
        directionVec = direction;
        bool hit = Physics.Raycast(transform.position, directionVec,out rayhit);


        if (hit)
        {
            Vector3 rayposition = rayhit.point;
            IHealthPool hithealth = rayhit.transform.GetComponent<IHealthPool>();
            if(hithealth != null)
            {
                hithealth.Damage(BulletDamage);
            }
            GameObject decal = Instantiate(BulletHoleDecal);

            decal.transform.position = rayposition;
            
        }
        StartCoroutine(despawn());
        
    }

    IEnumerator despawn()
    {
        yield return new WaitForSeconds(.1F);
        Despawn();
    }
    public void Travel()
    {
        throw new System.NotImplementedException();
    }

    public void Hit()
    {
        Debug.Log("Hit");

    }

    public void Despawn()
    {
        Debug.Log("Despawn");
    }







}
