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

            ClearInventory();

            _instantiatedItemDataList = new List<AbstractBasePlayerInventoryItemData>(_inventoryItemDataArray.Length);
            for (int i = 0; i < _inventoryItemDataArray.Length; i++)
            {
                var instantiated = Instantiate(_inventoryItemDataArray[i]);
                instantiated.CreateIntoInventory(this);
                instantiated.Initialize();
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


        private void Update()
        {
            
        }



    }//class

}

