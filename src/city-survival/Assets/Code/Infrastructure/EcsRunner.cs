using Code.Gameplay;
using Code.Infrastructure.System;
using UnityEngine;
using Zenject;

namespace Code.Infrastructure
{
    public class EcsRunner : MonoBehaviour
    {
       // private GameContext _gameContext;
       // private ITimeService _time;
      //  private IInputService _inputService;
      //  private ICameraProvider _cameraProvider;
        private MainGameplayFeatures _mainGameplayFeatures;
        private ISystemFactory _systemFactory;

        [Inject]
        private void Construct(ISystemFactory systemFactory)
        {
            _systemFactory = systemFactory;
        }

        private void Start()
        {
            _mainGameplayFeatures = _systemFactory.Create<MainGameplayFeatures>();
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