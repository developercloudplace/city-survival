using UnityEngine;

namespace Code.Gameplay.Cameras.Provider
{
    public interface ICameraProvider
    {
        public Camera MainCamera { get; }

        public float WorldScreenHeight { get; }
        public float WorldScreenWidth { get; }
        public void SetMainCamera(Camera camera);
    }
}