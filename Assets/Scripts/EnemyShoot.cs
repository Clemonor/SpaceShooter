using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : Shoot
{
    private float timer = 0;

    public override bool CanShoot()
    {
        timer += Time.deltaTime;

        if(timer > 2)
        {
            timer = 0;
            return true;
            
        }
        return false;
    }
}
