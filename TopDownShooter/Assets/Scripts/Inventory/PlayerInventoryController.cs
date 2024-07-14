using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;


namespace TopDownShoother.Inventory
{

    public class PlayerInventoryController : MonoBehaviour
    {
        [SerializeField] private AbstractBasePlayerInventoryItemData[] _inventoryItemDataArray;
        public Transform parent;
        private List<AbstractBasePlayerInventoryItemData> _instantiatedItemDataList;


        public ReactiveCommand ReactiveShootCommand { get; private set; }

        private void Start()
        {

            InitilizeInventory(_inventoryItemDataArray);
        }

        private void OnDestroy()
        {
            ClearInventory();
        }


        public void InitilizeInventory(AbstractBasePlayerInventoryItemData[] _inventoryItemDataArray)
        {
            if (ReactiveShootCommand == null)
            {
                ReactiveShootCommand = new ReactiveCommand();
            }
            else
            {
                //adjusting reactive command 
                ReactiveShootCommand.Dispose();
                ReactiveShootCommand = new ReactiveCommand();
            }
            
            //clearing old inventory and creating new one 
            ClearInventory();
            _instantiatedItemDataList = new List<AbstractBasePlayerInventoryItemData>(_inventoryItemDataArray.Length);

            

            
            for (int i = 0; i < _inventoryItemDataArray.Length; i++)
            {
                var instantiated = Instantiate(_inventoryItemDataArray[i]);
                instantiated.Initialize(this);
                _instantiatedItemDataList.Add(instantiated);
            }
        }

        private void ClearInventory()
        {
            if (_instantiatedItemDataList != null)
            {
                for (int i = 0; i < _instantiatedItemDataList.Count; i++)
                {
                    _instantiatedItemDataList[i].Destroy();

                }
            }
        }


       



    }//class

}

