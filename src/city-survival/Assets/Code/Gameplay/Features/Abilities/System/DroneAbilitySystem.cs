using System.Collections.Generic;
using System.Linq;
using Code.Gameplay.Features.Armaments.Factory;
using Entitas;
using UnityEngine;
using NotImplementedException = System.NotImplementedException;

namespace Code.Gameplay.Features.Abilities.System
{
    public class DroneAbilitySystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _drones;
        private readonly IGroup<GameEntity> _players;
        private IArmamentsFactory _armamentsFactory;
        private readonly List<GameEntity> _buffer = new(32);
        private readonly IGroup<GameEntity> _enemies;

        public DroneAbilitySystem(GameContext game, IArmamentsFactory armamentsFactory)
        {
            _armamentsFactory = armamentsFactory;
            _drones = game.GetGroup(GameMatcher
                    .AllOf(
                    GameMatcher.DroneAbility,
                    GameMatcher.Rotate,
                    GameMatcher.CurrentTarget,
                    GameMatcher.WorldPosition));

            _players = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Player,
                    GameMatcher.WorldPosition));
            
            _enemies = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Enemy,
                    GameMatcher.WorldPosition));
        }

        public void Execute()
        {
            foreach (GameEntity drone in _drones.GetEntities(_buffer))
            foreach (GameEntity player in _players)
            {
                
                DronePursuitPlayer(player, drone);
                DroneLookRotationFirstEnemy(drone);
            }
        }

        private void DroneLookRotationFirstEnemy(GameEntity drone)
        {
            if (_enemies.count <= 0)
                return;


           // drone.ReplaceCurrentTarget(FirstAvailableTarget().Transform.position);
            
            var targetAngle = (FirstAvailableTarget().WorldPosition - drone.WorldPosition);
            drone.ReplaceRotate(Quaternion.LookRotation(targetAngle));
            drone.Transform.rotation = drone.Rotate;
        }

        private GameEntity FirstAvailableTarget()
        {
            return _enemies.AsEnumerable().First();
        }

        private void DronePursuitPlayer(GameEntity player, GameEntity drone)
        {
            var stopDistance = Vector3.Distance(player.WorldPosition, drone.WorldPosition);
            if (stopDistance > 1)
            {
                drone.ReplaceDirection((player.WorldPosition - drone.WorldPosition).normalized);
                drone.isMoving = true;
                drone.isRotating = true;
                drone.isMovementAvailable = true;
            }
            else
            {
                drone.isMoving = false;
                drone.isMovementAvailable = false;
            }
        }
    }
}