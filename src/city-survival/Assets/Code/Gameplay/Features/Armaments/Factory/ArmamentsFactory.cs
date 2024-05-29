using System.Collections.Generic;
using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.Features.Abilities;
using Code.Gameplay.Features.Abilities.Configs;
using Code.Gameplay.StaticData;
using Code.Infrastructure.Identifiers;
using Unity.VisualScripting;
using UnityEngine;

namespace Code.Gameplay.Features.Armaments.Factory
{
    public class ArmamentsFactory : IArmamentsFactory
    {
        private readonly IIdentifierService _identifier;
        private readonly IStaticDataService _staticData;
        private const int TARGET_BUFFER_SIZE = 64;


        public ArmamentsFactory(IIdentifierService identifier, IStaticDataService staticData)
        {
            _staticData = staticData;
            _identifier = identifier;
        }

        public GameEntity CreateMachineGunShell(int level, Vector3 at)
        {
            AbilityLevel abilityLevel = _staticData.GetAbilityLevel(AbilityId.MachineGun, level);
            ProjectileSetup setup = abilityLevel.ProjectileSetup;
            return CreateEntity.Empty()
                .AddId(_identifier.Next())
                .AddWorldPosition(at)
                .AddViewPrefab(abilityLevel.ViewPrefab)
                .AddEffectSetups(abilityLevel.EffectSetups)
                .AddSpeed(setup.Speed)
                .AddRotate(Quaternion.identity)
                .AddCollectTargetRadius(setup.ContactSphereRadios)
                .AddLayerMask(CollisionLayer.Enemy.AsMask())
                .AddTargetBuffer(new List<int>(TARGET_BUFFER_SIZE))
                .AddProcessedTargetsBuffer(new List<int>(TARGET_BUFFER_SIZE))
                .AddTargetLimits(setup.Pierce)
                .AddSelfDestructTimer(setup.LifeTime)
                .With(x => x.isMoving = true)
                .With(x => x.isMovementAvailable = true)
                .With(x => x.isArmament = true)
                .With(x => x.isReadyToCollectTargets = true)
                .With(x => x.isCollectingTargetsContinuously = true);
        }
    }
}