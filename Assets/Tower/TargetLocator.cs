using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetLocator : MonoBehaviour
{
    [SerializeField] Transform cannon;
    Transform target;

    void Start()
    {
        target = FindObjectOfType<EnemyMover>().transform;
    }

    void Update()
    {
        AimWeapon();
    }

    void AimWeapon()
    {
        cannon.transform.LookAt(target);
    }
}
