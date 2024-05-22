using System.Collections.Generic;
using Code.Gameplay.Features.Armaments.Factory;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Abilities.System
{
    public class DroneAbilitySystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _drones;
        private readonly IGroup<GameEntity> _players;
        private IArmamentsFactory _armamentsFactory;
        private readonly List<GameEntity> _buffer = new(4);

        public DroneAbilitySystem(GameContext game, IArmamentsFactory armamentsFactory)
        {
            _armamentsFactory = armamentsFactory;
            _drones = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.DroneAbility, GameMatcher.WorldPosition));
            
            _players = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Player, GameMatcher.WorldPosition));
        }

        public void Execute()
        {
            foreach (GameEntity drone in _drones.GetEntities(_buffer))
            foreach(GameEntity player in _players)
            {

                var stopDistance =  Vector3.Distance(player.WorldPosition, drone.WorldPosition) ;
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
}