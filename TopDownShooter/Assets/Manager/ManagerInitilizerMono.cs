using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShoother
{

    public class ManagerInitilizerMono : MonoBehaviour
    {
        [SerializeField] public AbstaractScriptableManagerBase[] _abstaractScriptableManagerArray;
        private List<AbstaractScriptableManagerBase> _instantiatedAbstaractScriptableManagerList;

        private void Start()
        {
            _instantiatedAbstaractScriptableManagerList = new List<AbstaractScriptableManagerBase>(_abstaractScriptableManagerArray.Length);
            for (int i = 0; i < _abstaractScriptableManagerArray.Length; i++)
            {
                var instantiated = Instantiate(_abstaractScriptableManagerArray[i]);
                instantiated.Initilize();
                _instantiatedAbstaractScriptableManagerList.Add(instantiated);
            }
        }



        private void OnDestroy()
        {
            if (_instantiatedAbstaractScriptableManagerList != null)
            {
                for (int i = 0; i < _instantiatedAbstaractScriptableManagerList.Count; i++)
                {
                    _abstaractScriptableManagerArray[i].Destroy();
                }
            }



            
        }








    }//class

}
