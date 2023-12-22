using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temperature : MonoBehaviour
{
    public Health health;
    public int playerDamage = 10;
    public float temperatureCurrent = 36.6f;
    public int temperatureNormal = 35;
    public int temperatureCritical = 28;
    public float freezeSpeed = 0.10f;
    public float freezeDamageTimer = 1;
    public float freezeDamageDelay = 2;

    void Update()
    {
        temperatureCurrent -= freezeSpeed * Time.deltaTime;
        print(temperatureCurrent);
        if (temperatureCurrent <= temperatureCritical)
        {
            if (freezeDamageTimer <=0 )
            {
                health.TakeDamage(playerDamage);
                freezeDamageTimer += freezeDamageDelay;
            }
            else
            {
                freezeDamageTimer -= Time.deltaTime;
            }
        }
    }
}
