using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : Weapon
{
    //В отличие от веапона
    //Умеет стрелять 
    //Есть перезарядка патрон
    //Может заклинить, может быть перегрев

    public void Shoot()
    {
        Debug.Log("Shoot");
    }

    private void Reload()
    {
        Debug.Log("Reload");
    }
}