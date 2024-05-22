using Code.Gameplay.Features.Abilities.Factory;
using Code.Gameplay.Features.Player.Factory;
using Code.Gameplay.Levels;
using Entitas;

namespace Code.Gameplay.Features.Player.Systems
{
    public class InitializePlayerSystem : IInitializeSystem
    {
        private readonly ILevelDataProvider _levelDataProvider;
        private readonly IPlayerFactory _playerFactory;


        public InitializePlayerSystem(IPlayerFactory playerFactory,
            ILevelDataProvider levelDataProvider)
        {
            _playerFactory = playerFactory;
            _levelDataProvider = levelDataProvider;
        }

        public void Initialize()
        {
            _playerFactory.CreatePlayer(_levelDataProvider.StartPoint);
        }
    }
}