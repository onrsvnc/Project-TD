using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int hitPoints = 5;
    [SerializeField] int currentHitPoints = 0;
    Enemy enemy;
    void OnEnable()
    {
        currentHitPoints = hitPoints;
    }
    void Start()
    {
        enemy = GetComponent<Enemy>();
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
            enemy.GoldRewarded();
            gameObject.SetActive(false);
        }
    }
}
