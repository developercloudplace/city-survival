using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.Cameras.Provider;
using Code.Gameplay.Common.Time;
using Code.Gameplay.Features.Enemies.Factory;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Enemies.Systems
{
    public class EnemySpawnSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _timers;
        private readonly ITimeService _timeService;
        private readonly IEnemyFactory _enemyFactory;
        private readonly IGroup<GameEntity> _player;
        private ICameraProvider _cameraProvider;

        private const float SPAWN_DISTANCE_GAP = 25;
        private const float ENEMY_SPAWN_TIMER = 0.7f;

        public EnemySpawnSystem(GameContext game, ITimeService timeService,
            IEnemyFactory enemyFactory, ICameraProvider cameraProvider)
        {
            _cameraProvider = cameraProvider;
            _enemyFactory = enemyFactory;
            _timeService = timeService;

            _timers = game.GetGroup(GameMatcher.AllOf(GameMatcher.SpawnTimer));
            _player = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Player,
                    GameMatcher.WorldPosition));
        }


        public void Execute()
        {
            foreach (GameEntity player in _player)
            foreach (GameEntity timer in _timers)
            {
                timer.ReplaceSpawnTimer(timer.SpawnTimer - _timeService.DeltaTime);
                if (timer.SpawnTimer <= 0)
                {
                    timer.ReplaceSpawnTimer(ENEMY_SPAWN_TIMER);
                    _enemyFactory.CreateEnemy(EnemyTypeId.Zombie, RandomSpawnPosition(player.WorldPosition));
                }
            }
        }

        private Vector3 RandomSpawnPosition(Vector3 aroundPosition)
        {
            bool startWithHorizontal = Random.Range(0, 2) == 0;

            return startWithHorizontal
                ? HorizontalSpawnPosition(aroundPosition)
                : VerticalSpawnPosition(aroundPosition);
        }

        private Vector3 HorizontalSpawnPosition(Vector3 aroundPosition)
        {
            Vector3[] horizontalDirections = { Vector3.left, Vector3.right };
            Vector3 primaryDirection = horizontalDirections.PickRandom();

            float horizontalOffsetDistance = _cameraProvider.WorldScreenWidth / 2 + SPAWN_DISTANCE_GAP;
            float verticalRandomOffset = Random.Range(-_cameraProvider.WorldScreenHeight / 2,
                _cameraProvider.WorldScreenHeight / 2);

            return aroundPosition + primaryDirection * horizontalOffsetDistance + Vector3.up * verticalRandomOffset;
        }

        private Vector3 VerticalSpawnPosition(Vector3 aroundPosition)
        {
            Vector3[] verticalDirections = { Vector3.forward,-Vector3.forward };
            Vector3 primaryDirection = verticalDirections.PickRandom();

            float verticalOffsetDistance = _cameraProvider.WorldScreenHeight / 2 + SPAWN_DISTANCE_GAP;
            float horizontalRandomOffset =
                Random.Range(-_cameraProvider.WorldScreenWidth / 2, _cameraProvider.WorldScreenWidth / 2);

            return aroundPosition + primaryDirection * verticalOffsetDistance + Vector3.right * horizontalRandomOffset;
        }
    }
}