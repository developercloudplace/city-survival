using Code.Gameplay.Common.Time;
using Code.Gameplay.Features.Movement;
using Code.Gameplay.Features.Player;
using Code.Gameplay.Input;
using Code.Gameplay.Input.Service;

namespace Code.Gameplay
{
    public class MainGameplayFeatures : Feature
    {
        public MainGameplayFeatures(GameContext gameContext, ITimeService time, IInputService inputService)
        {
            Add(new InputFeature(gameContext, inputService));
            Add(new PlayerFeatures(gameContext));
            Add(new MovementFeatures(gameContext, time));
        }

        
    }
}