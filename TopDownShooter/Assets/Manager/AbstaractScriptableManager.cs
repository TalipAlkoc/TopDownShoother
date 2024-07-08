using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShoother
{

    public class AbstaractScriptableManager<T> : AbstaractScriptableManagerBase where T :
        AbstaractScriptableManager<T>
    {
        public static T Instance;

        public override void Initilize()
        {
            base.Initilize();
            Instance = this as T;
        }

        public override void Destroy()
        {
            base.Destroy();
        }





    }//class

}

