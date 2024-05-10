using Code.Gameplay;
using Code.Gameplay.Cameras.Provider;
using Code.Gameplay.Common.Time;
using Code.Gameplay.Input.Service;
using UnityEngine;
using Zenject;

namespace Code.Infrastructure
{
    public class EcsRunner : MonoBehaviour
    {
        private GameContext _gameContext;
        private ITimeService _time;
        private MainGameplayFeatures _mainGameplayFeatures;
        private IInputService _inputService;
        private ICameraProvider _cameraProvider;

        [Inject]
        private void Construct(GameContext gameContext, ITimeService time, IInputService inputService,ICameraProvider cameraProvider)
        {
            _cameraProvider = cameraProvider;
            _gameContext = gameContext;
            _time = time;
            _inputService = inputService;
        }

        private void Start()
        {
            _mainGameplayFeatures = new MainGameplayFeatures(_gameContext, _time, _inputService,_cameraProvider);
            _mainGameplayFeatures.Initialize();
        }

        private void Update()
        {
            _mainGameplayFeatures.Execute();
            _mainGameplayFeatures.Cleanup();
        }

        private void OnDestroy() =>
            _mainGameplayFeatures.TearDown();
    }
}