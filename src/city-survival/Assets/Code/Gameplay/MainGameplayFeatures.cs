using Code.Gameplay.Features.Movement;
using Code.Gameplay.Features.Player;
using Code.Gameplay.Input;
using Code.Infrastructure.System;

namespace Code.Gameplay
{
    public class MainGameplayFeatures : Feature
    {
        public MainGameplayFeatures(ISystemFactory systemFactory)
        {
            Add(systemFactory.Create<InputFeature>());
            Add(systemFactory.Create<PlayerFeatures>());
            Add(systemFactory.Create<MovementFeatures>());
        }
    }
}