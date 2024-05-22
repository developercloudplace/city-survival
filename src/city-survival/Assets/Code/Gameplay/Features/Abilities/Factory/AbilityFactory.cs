using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.Features.Abilities.Configs;
using Code.Gameplay.StaticData;
using Code.Infrastructure.Identifiers;
using UnityEngine;
using NotImplementedException = System.NotImplementedException;

namespace Code.Gameplay.Features.Abilities.Factory
{
    public class AbilityFactory : IAbilityFactory
    {
        private readonly IIdentifierService _identifiers;
        private readonly IStaticDataService _staticData;

        public AbilityFactory(IIdentifierService identifiers, IStaticDataService staticData)
        {
            _identifiers = identifiers;
            _staticData = staticData;
        }
        
        public GameEntity CreateDroneAbility(int level, Vector3 at)
        {
            AbilityLevel abilityLevel = _staticData.GetAbilityLevel(AbilityId.Drone, level);
            ProjectileSetup setup = abilityLevel.ProjectileSetup;
            return CreateEntity.Empty()
                .AddId(_identifiers.Next())
                .AddWorldPosition(at)
                .AddViewPrefab(abilityLevel.ViewPrefab)
                .AddSpeed(setup.Speed)
                .AddDirection(Vector3.zero)
                .With(x => x.isMoving = true)
                .With(x => x.isRotating = true)
                .With(x => x.isMovementAvailable = true)
                .With(x => x.isDroneAbility = true);
        }
    }
}