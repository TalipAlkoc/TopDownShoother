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
            base.Initilize();
            Debug.Log("scriptable shoot manager activated");
        }

        public override void Destroy()
        {
            base.Destroy();
            Debug.Log("scriptable shoot manager destroyed");
        }

        public void Shoot(Vector3 origin , Vector3 direction)
        {
            RaycastHit rHit;
            var physic = Physics.Raycast(origin, direction,out rHit);
            if (physic)
            {
                Debug.Log("Collider: " + rHit.collider.name);
            }
        }
    }

}
