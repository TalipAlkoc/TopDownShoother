using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShoother.PlayerInput
{
    [CreateAssetMenu(menuName = "TopDownShoote/Inputs/InputData")]

    public class InputData : ScriptableObject
    {
        public float Horizontal;
        public float Vertical;
    }

}
