using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShoother.Inventory
{

    public class PlayerInventoryController : MonoBehaviour
    {
        [SerializeField] private AbstractBasePlayerInventoryItemData[] _inventoryItemDataArray;
        public Transform parent;
        private void Start()
        {

            InitilizeInventory(_inventoryItemDataArray);
        }

        public void InitilizeInventory(AbstractBasePlayerInventoryItemData[] _inventoryItemDataArray)
        {
            for (int i = 0; i < _inventoryItemDataArray.Length; i++)
            {
                _inventoryItemDataArray[i].CreateIntoInventory(this);
            }
        }

    }
}

