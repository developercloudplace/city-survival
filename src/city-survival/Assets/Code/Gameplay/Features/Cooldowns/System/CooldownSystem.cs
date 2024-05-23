using System.Collections.Generic;
using Code.Gameplay.Common.Time;
using Entitas;

namespace Code.Gameplay.Features.Cooldowns.System
{
    public class CooldownSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _cooldowns;
        private readonly ITimeService _time;
        private readonly List<GameEntity> _buffer = new(64);

        public CooldownSystem(GameContext game, ITimeService time)
        {
            _time = time;
            _cooldowns = game.GetGroup(GameMatcher
                .AllOf(GameMatcher.Cooldown, GameMatcher.CooldownLeft));
        }

        public void Execute()
        {
            foreach (GameEntity cooldown in _cooldowns.GetEntities(_buffer))
            {
                cooldown.ReplaceCooldownLeft(cooldown.CooldownLeft - _time.DeltaTime);
                if (cooldown.CooldownLeft <= 0)
                {
                    cooldown.isCooldownUp = true;
                    cooldown.RemoveCooldownLeft();
                }
            }
        }
    }
}