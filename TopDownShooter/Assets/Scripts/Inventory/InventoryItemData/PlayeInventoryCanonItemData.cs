using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShoother.Inventory
{
    [CreateAssetMenu(menuName = "TopDownShoote/Inventory/Player Inventory Canon Item Data")]

    public class PlayeInventoryCanonItemData : AbstractPlayerInventoryItemData<PlayerInventoryCanonItemMono>
    {
        public override void CreateIntoInventory(PlayerInventoryController _targetPlayerInventory)
        {
            InstantiateAndInitilizePrefab(_targetPlayerInventory.parent);
            Debug.Log("Thıs class ıs player inventory canon ıtem data");
        }


        public void Shoot()
        {
            _instantiated.Shoot();
        }


    }//class

}

