using System.Collections;
using System.Collections.Generic;
using TopDownShoother.PlayerInput;
using UnityEngine;


namespace TopDownShoother.PlayerControls
{

    public class TowerRotationController : MonoBehaviour
    {


        [SerializeField] private InputData _rotationInput;
        [SerializeField] private Transform _towerTansform;
        [SerializeField] private TowerRotationSettings _towerRotationSettings;



        private void Update()
        {
            _towerTansform.Rotate(0, _rotationInput.Horizontal * _towerRotationSettings.TowerRotationSpeed, 0, Space.Self);

        }





    }//class

}
