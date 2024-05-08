using Code.Gameplay.Common.Time;
using Code.Gameplay.Features.Movement;

namespace Code.Gameplay
{
    public class MainGameplayFeatures : Feature
    {
        public MainGameplayFeatures(GameContext gameContext, ITimeService time)
        {
            Add(new MovementFeatures(gameContext, time));
        }

        
    }
}