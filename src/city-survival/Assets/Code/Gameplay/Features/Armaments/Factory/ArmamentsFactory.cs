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
        private IIdentifierService _identifier;
        private IStaticDataService _staticData;

        public ArmamentsFactory(IIdentifierService identifier, IStaticDataService staticData)
        {
            _staticData = staticData;
            _identifier = identifier;
        }

       // public GameEntity CreateDrone(int level, Vector3 at)
       // {
       //     AbilityLevel abilityLevel = _staticData.GetAbilityLevel(AbilityId.Drone, level);
       //     ProjectileSetup setup = abilityLevel.ProjectileSetup;
       //     return CreateEntity.Empty()
       //         .AddId(_identifier.Next())
       //         .AddWorldPosition(at)
       //         .AddViewPrefab(abilityLevel.ViewPrefab)
       //         .AddSpeed(setup.Speed)
       //         .AddDirection(Vector3.zero)
       //         .With(x => x.isMoving = true)
       //         .With(x => x.isRotating = true)
       //         .With(x => x.isMovementAvailable = true)
       //         .With(x => x.isArmament = true);
       // }
    }
}