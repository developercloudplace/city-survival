using Unity.Mathematics;
using UnityEngine;

namespace Code.Gameplay.Common.Visuals
{
    public class StatusVisuals : MonoBehaviour, IStatusVisuals
    {
        [Header("Burning Setting ")] [Space(2)]
        public Transform PointCreateBurningFx;
        public GameObject PrefabBurningFx;
        [Header("Freeze Setting ")] [Space(2)]
        public Transform PointCreateFreezeFx;
        public GameObject PrefabFreezeFx;
        private GameObject _currentFx;
        private GameObject _currentFreezeFx;

        public void ApplyBurning()
        {
            Debug.Log("ApplyBurning");
            if (!_currentFx)
            {
               //Debug.Log("Apply Burning Fx");
               //var go = Instantiate(PrefabBurningFx, PointCreateBurningFx.position, quaternion.identity);
               //_currentFx = go;
            }
        }

        public void ApplyFreeze()
        {
            Debug.Log("ApplyFreeze");
          ////Debug.Log("Apply Freeze Fx");
          // var go = Instantiate(PrefabFreezeFx, PointCreateFreezeFx.position, quaternion.identity);
          // _currentFreezeFx = go;
        }

        public void UnApplyBurning()
        {
            Debug.Log("UnApplyBurning");
         //  if (_currentFx)
         //  {
         //      Destroy(_currentFx);
         //      _currentFx = null;
         //  }
        }

        public void UnApplyFreeze()
        {
            Debug.Log("UnApplyFreeze");
          // if (_currentFreezeFx)
          // {
          //     Destroy(_currentFreezeFx);
          //     _currentFreezeFx = null;
          // }
        }
    }
}