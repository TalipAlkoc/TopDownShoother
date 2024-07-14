using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TopDownShoother.Inventory
{
    public enum InventoryDataItemType { Canon,Body }

    public abstract class AbstractPlayerInventoryItemData<T> : AbstractBasePlayerInventoryItemData
        where T : AbstractPlayerInventoryMono

    {
        [SerializeField] protected string _itemId;
        [SerializeField] protected InventoryDataItemType _ınventoryDataItemType;
        [SerializeField] protected T _prefab;
        protected T _instantiated;




        protected T InstantiateAndInitilizePrefab(Transform parent)
        {
            _instantiated = Instantiate(_prefab, parent);
            return _instantiated;
        }





    }//class

}
