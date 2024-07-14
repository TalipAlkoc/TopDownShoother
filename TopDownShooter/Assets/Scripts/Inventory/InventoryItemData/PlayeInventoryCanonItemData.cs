using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

namespace TopDownShoother.Inventory
{
    [CreateAssetMenu(menuName = "TopDownShoote/Inventory/Player Inventory Canon Item Data")]

    public class PlayeInventoryCanonItemData : AbstractPlayerInventoryItemData<PlayerInventoryCanonItemMono>
    {
        [SerializeField] private float _damage;
        public float Damage { get { return _damage; }}


        [SerializeField] private float _rpm = 1f;
        public float RPM { get { return _rpm; } }

        private float _lastShootTime;

        public override void Initialize(PlayerInventoryController _targetPlayerInventory)
        {
            base.Initialize(_targetPlayerInventory);
            InstantiateAndInitilizePrefab(_targetPlayerInventory.parent);
            _targetPlayerInventory.ReactiveShootCommand.Subscribe(OnReactiveShootCommand).AddTo(_compositeDisposable);
            Debug.Log("Thıs class ıs player inventory canon ıtem data");
        }

        private void OnReactiveShootCommand(Unit obj)
        {
            Debug.Log("reactive command shoot");
            Shoot();
        }

        public override void Destroy()
        {
            base.Destroy();
        }


        public void Shoot()
        {
            if(Time.time - _lastShootTime > _rpm)
            {
                _instantiated.Shoot();
                _lastShootTime = Time.time;
            }
            else
            {
                Debug.LogError("you cant shoot now !");
            }
            
        }


    }//class

}

