using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int hitPoints = 5;
    [SerializeField] int currentHitPoints = 0;
    void Start()
    {
        currentHitPoints = hitPoints;
    }

    void Update()
    {
        
    }

    void OnParticleCollision(GameObject other)
    {
        ProcessHit();
    }

    void ProcessHit()
    {
        currentHitPoints--;
        if(currentHitPoints <= Mathf.Epsilon)
        {
            Destroy(gameObject);
        }
    }
}
