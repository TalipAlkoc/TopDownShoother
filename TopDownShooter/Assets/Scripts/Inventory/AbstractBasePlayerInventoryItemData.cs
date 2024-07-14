using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;


namespace TopDownShoother.Inventory
{


    public abstract class AbstractBasePlayerInventoryItemData : ScriptableObject
    {
        private PlayerInventoryController _inventoryController;

        protected CompositeDisposable _compositeDisposable;



        public virtual void Initialize(PlayerInventoryController _targetPlayerInventory)
        {
            if (_compositeDisposable == null)
            {
                _compositeDisposable = new CompositeDisposable();
            }
            _inventoryController = _targetPlayerInventory;

        }




        public virtual void Destroy()
        {
            //means that we are unsubscribing from all the events we are add to this 
            if (_compositeDisposable != null)
            {
                _compositeDisposable.Dispose();
            }
            
            
            Destroy(this);
        }
    }

}
