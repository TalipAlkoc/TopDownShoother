using System.Collections;
using System.Collections.Generic;
using TopDownShoother.PlayerInput;
using UnityEngine;

namespace TopDownShoother.PlayerMovement
{

    public class PlayerMovementController : MonoBehaviour
    {
        [SerializeField] private InputData _inputData;
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private PlayerMovementSettings _playerMovementSettings;

        private void Update()
        {
            _rigidbody.MovePosition(_rigidbody.position +( _rigidbody.transform.forward * _inputData.Vertical *
                _playerMovementSettings.SpeedVertical));
            _rigidbody.MovePosition(_rigidbody.position +( _rigidbody.transform.right * _inputData.Horizontal*
                _playerMovementSettings.SpeedHorizontal));
        }




    }//class
}


