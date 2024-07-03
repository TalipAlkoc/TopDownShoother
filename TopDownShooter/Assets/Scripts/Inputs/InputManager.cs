using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TopDownShoother.PlayerInput
{

    public class InputManager : MonoBehaviour
    {
        [SerializeField] private InputData[] _ınputDataArray;


        private void Update()
        {
            for(int i =0;  i < _ınputDataArray.Length; i++)
            {
                _ınputDataArray[i].ProcessInput();

            }
        }



    }//class

}
