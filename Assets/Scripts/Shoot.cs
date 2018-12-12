using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shoot : MonoBehaviour
{


    public GameObject projectile;
    public Transform ship;

    // Update is called once per frame
    public virtual void Update()
    {
        if (CanShoot() == true)
            ShootProjectile();
    }
    public abstract bool CanShoot();

    public virtual void ShootProjectile()
    {
        Instantiate(projectile, ship.position, ship.rotation);
    }
}
