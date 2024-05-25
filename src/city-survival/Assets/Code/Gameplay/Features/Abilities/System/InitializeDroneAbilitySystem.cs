using Code.Gameplay.Features.Abilities.Factory;
using Code.Gameplay.Levels;
using Entitas;

namespace Code.Gameplay.Features.Abilities.System
{
    public class InitializeDroneAbilitySystem : IInitializeSystem
    {
        private readonly ILevelDataProvider _levelDataProvider;
        private readonly IAbilityFactory _abilityFactory;

        public InitializeDroneAbilitySystem(
            IAbilityFactory abilityFactory,
            ILevelDataProvider levelDataProvider)
        {
            _abilityFactory = abilityFactory;
            _levelDataProvider = levelDataProvider;
        }

        public void Initialize()
        {
            _abilityFactory.CreateDroneAbility(1, _levelDataProvider.StartPoint);
            _abilityFactory.CreateMachineGunAbility(1);
        }
    }
}