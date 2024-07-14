using System.Collections;
using System.Collections.Generic;
using TopDownShoother.Inventory;
using TopDownShoother.PlayerInput;
using UnityEngine;



namespace TopDownShoother
{

    public class LocalPlayerController : MonoBehaviour
    {
        [SerializeField] private PlayerInventoryController _inventoryController;
        [SerializeField] private InputData _shootInput;

        private void Update()
        {
            if(_shootInput.Horizontal > 0)
            {
                _inventoryController.ReactiveShootCommand.Execute();
            }
        }


    }//class

}
