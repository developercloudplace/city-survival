using System.Collections.Generic;
using Code.Common.Extensions;
using Code.Gameplay.Common.Time;
using Code.Gameplay.Features.Armaments.Factory;
using Code.Gameplay.Features.Cooldowns.System;
using Code.Gameplay.StaticData;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Abilities.System
{
    public class MachineGunAbilitySystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _machineGuns;
        private readonly IGroup<GameEntity> _droneAbilities;
        private readonly IArmamentsFactory _armamentsFactory;
        private readonly IStaticDataService _staticData;
        private readonly List<GameEntity> _buffer = new(8);

        public MachineGunAbilitySystem(GameContext game, IArmamentsFactory armamentsFactory,
            IStaticDataService staticData)
        {
            _staticData = staticData;
            _armamentsFactory = armamentsFactory;

            _machineGuns = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.MachineGunAbility,
                    GameMatcher.WorldPosition,
                    GameMatcher.CooldownUp));

            _droneAbilities = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.DroneAbility,
                    GameMatcher.WorldPosition));
        }

        public void Execute()
        {
            foreach (GameEntity drone in _droneAbilities)
            foreach (GameEntity machineGun in _machineGuns.GetEntities(_buffer))
            {
                if (drone.isCurrentTarget)
                {
                    _armamentsFactory
                        .CreateMachineGunShell(1, drone.WorldPosition)
                        .AddProducerId(drone.Id)
                        .ReplaceDirection((drone.CurrentTargetPosition - drone.WorldPosition + new Vector3(0, 1, 0))
                            .normalized)
                        .With(x => x.isArmament = true);

                     
                    machineGun.PutOnCooldown(_staticData.GetAbilityLevel(AbilityId.MachineGun, 1).Cooldown);
                }
            }
        }
    }
}