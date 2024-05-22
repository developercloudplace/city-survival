using Code.Gameplay.Cameras.Provider;
using Code.Gameplay.Levels;
using Code.Gameplay.StaticData;
using UnityEngine;
using Zenject;

namespace Code.Infrastructure.Installers
{
    public class LevelInitializer : MonoBehaviour, IInitializable
    {
        public Camera MainCamera;
        public Transform StartPoint;
        private ICameraProvider _cameraProvider;
        private ILevelDataProvider _levelDataProvider;
        private IStaticDataService _staticDataService;

        [Inject]
        private void Construct(ICameraProvider cameraProvider, ILevelDataProvider levelDataProvider, IStaticDataService staticDataService)
        {
            _staticDataService = staticDataService;
            _levelDataProvider = levelDataProvider;
            _cameraProvider = cameraProvider;
        }

        public void Initialize()
        {
            _staticDataService.LoadAll();
            _levelDataProvider.SetStartPoint(StartPoint.position);
            _cameraProvider.SetMainCamera(MainCamera);
        }
    }
}