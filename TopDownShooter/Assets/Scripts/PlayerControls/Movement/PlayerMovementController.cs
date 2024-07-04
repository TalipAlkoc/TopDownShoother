using System.Collections;
using System.Collections.Generic;
using TopDownShoother.PlayerInput;
using UnityEngine;

namespace TopDownShoother.PlayerControls
{

    public class PlayerMovementController : MonoBehaviour
    {
        [SerializeField] private InputData _inputData;
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private Transform _targetTransform;
        [SerializeField] private PlayerMovementSettings _playerMovementSettings;

        private void Update()
        {
            _rigidbody.MovePosition(_rigidbody.position +( _rigidbody.transform.forward * _inputData.Vertical *
                _playerMovementSettings.SpeedVertical));
            _targetTransform.Rotate(0, _inputData.Horizontal * _playerMovementSettings.SpeedHorizontal, 0, Space.Self);
            
        }




    }//class
}


