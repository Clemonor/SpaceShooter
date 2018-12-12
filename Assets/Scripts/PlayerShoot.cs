using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : Shoot
{
    public override bool CanShoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            return true;
        }

        return false;
    }
}
