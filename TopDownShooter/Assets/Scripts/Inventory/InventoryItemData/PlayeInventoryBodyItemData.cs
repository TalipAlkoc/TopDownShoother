using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TopDownShoother.Inventory
{
    [CreateAssetMenu(menuName = "TopDownShoote/Inventory/Player Inventory Body Item Data")]
    public class PlayeInventoryBodyItemData : AbstractPlayerInventoryItemData<PlayerInventoryBodyItemMono>
    {
        public override void Initialize(PlayerInventoryController _targetPlayerInventory)
        {
            var instantiated = InstantiateAndInitilizePrefab(_targetPlayerInventory.parent);
            Debug.Log("Thıs class ıs player inventory body ıtem data");
        }
    }

}
