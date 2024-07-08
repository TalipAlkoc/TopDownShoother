using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TopDownShoother.Inventory
{
    [CreateAssetMenu(menuName = "TopDownShoote/Inventory/ScriptabeleShootManager")]
    public class ScriptabeleShootManager : AbstaractScriptableManager<ScriptabeleShootManager>
    {



        public override void Initilize()
        {
            Debug.Log("scriptable shoot manager activated");
        }

        public override void Destroy()
        {
            Debug.Log("scriptable shoot manager destroyed");
        }


    }

}
