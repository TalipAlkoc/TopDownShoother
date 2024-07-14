using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShoother.Inventory
{


    public abstract class AbstractBasePlayerInventoryItemData : ScriptableObject
    {
        public abstract void CreateIntoInventory(PlayerInventoryController _targetPlayerInventory);

        public virtual void Initialize()
        {

        }



        public virtual void Destroy()
        {
            Destroy(this);
        }
    }

}
