using Code.Gameplay;
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

        [Inject]
        private void Construct(GameContext gameContext, ITimeService time, IInputService inputService)
        {
            _gameContext = gameContext;
            _time = time;
            _inputService = inputService;
        }

        private void Start()
        {
            _mainGameplayFeatures = new MainGameplayFeatures(_gameContext, _time, _inputService);
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