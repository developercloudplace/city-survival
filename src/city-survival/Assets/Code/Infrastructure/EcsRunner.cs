using System;
using Code.Gameplay;
using Code.Gameplay.Common.Time;
using UnityEngine;
using Zenject;

namespace Code.Infrastructure
{
    public class EcsRunner : MonoBehaviour
    {
        private MainGameplayFeatures _mainGameplayFeatures;
        private GameContext _gameContext;
        private ITimeService _time;


        [Inject]
        private void Construct(GameContext gameContext, ITimeService time)
        {
            _time = time;
            _gameContext = gameContext;
        }

        private void Start()
        {
            _mainGameplayFeatures = new MainGameplayFeatures(_gameContext, _time);
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