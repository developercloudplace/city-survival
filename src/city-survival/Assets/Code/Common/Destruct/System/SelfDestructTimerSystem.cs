using System.Collections.Generic;
using Code.Gameplay.Common.Time;
using Entitas;

namespace Code.Common.Destruct.System
{
    public class SelfDestructTimerSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _entities;
        private readonly List<GameEntity> _buffer = new(64);
        private readonly ITimeService _time;


        public SelfDestructTimerSystem(GameContext gameContext, ITimeService time)
        {
            _time = time;
            _entities = gameContext.GetGroup(GameMatcher.SelfDestructTimer);
        }
        


        public void Execute()
        {
            foreach (var entity in _entities.GetEntities(_buffer))
            {
                if (entity.SelfDestructTimer > 0)
                    entity.ReplaceSelfDestructTimer(entity.SelfDestructTimer - _time.DeltaTime);
                else
                {
                    entity.RemoveSelfDestructTimer();
                    entity.isDestructed = true;
                }
            }
        }
    }
}