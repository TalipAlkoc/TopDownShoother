using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace TopDownShoother.Camera
{
    public class CameraController : MonoBehaviour
    {

        [SerializeField] CameraSettings _cameraSettings;
        [SerializeField] private Transform _rotationTarget;
        [SerializeField] private Transform _positionTarget;
        [SerializeField] private Transform _cameraTransform;


        private void Update()
        {
            CameraRotationFollow();
            CameraMovementFollow();
        }


        private void CameraRotationFollow()
        {
            _cameraTransform.rotation = Quaternion.Lerp(_cameraTransform.rotation,
               Quaternion.LookRotation(_rotationTarget.forward),
               Time.deltaTime * _cameraSettings.RotationLerpSpeed);
        }

        private void CameraMovementFollow()
        {
            _cameraTransform.localPosition = _cameraSettings.PositionOffset;
        }

    }//class

}
