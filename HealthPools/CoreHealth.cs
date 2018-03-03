using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoreHealth : MonoBehaviour,IHealthPool {

    public int health;

    public float timeScale;
    public float dilationDuration;

    TakeDamage flash;
    ScreenShake shake;
    // Use this for initialization
    void Start()
    {
        flash = GetComponent<TakeDamage>();
        shake = GetComponent<ScreenShake>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Damage(int damage)
    {
        health -= damage;
        flash.FlashEffect();
        shake.shakeDuration = 0.5f;
        //StartCoroutine("TimeDilation");
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
        GetComponent<EndGame>().WinGame();
        Debug.Log("Die");
    }

    IEnumerator TimeDilation()
    {
        Time.timeScale = timeScale;
        yield return new WaitForSeconds(dilationDuration);
        Time.timeScale = 1;
    }


}
