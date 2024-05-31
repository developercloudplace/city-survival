using Unity.Mathematics;
using UnityEngine;

namespace Code.Gameplay.Common.Visuals
{
    public class StatusVisuals : MonoBehaviour, IStatusVisuals
    {
        public Transform PointCreateBurningFx;
        public GameObject PrefabBurningFx;
        private GameObject _currentFx;

        public void ApplyBurning()
        {
            if (!_currentFx)
            {
               //Debug.Log("Apply Burning Fx");
               //var go = Instantiate(PrefabBurningFx, PointCreateBurningFx.position, quaternion.identity);
               //_currentFx = go;
            }
        }

        public void UnApplyBurning()
        {
         //  if (_currentFx)
         //  {
         //      Destroy(_currentFx);
         //      _currentFx = null;
         //  }
        }
    }
}