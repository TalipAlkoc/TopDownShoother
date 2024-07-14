using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShoother.Inventory
{


    public class PlayerInventoryCanonItemMono : AbstractPlayerInventoryMono
    {
        [SerializeField] private Transform _canonShootPoint;




       public void Shoot()
        {
            //add also effects and such
            ScriptabeleShootManager.Instance.Shoot(_canonShootPoint.position, _canonShootPoint.forward);
            
        }
    }

}
