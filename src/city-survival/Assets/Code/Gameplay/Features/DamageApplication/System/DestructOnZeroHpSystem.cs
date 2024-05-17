using Entitas;

namespace Code.Gameplay.Features.DamageApplication.System
{
    public class DestructOnZeroHpSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _entities;
      

        public DestructOnZeroHpSystem(GameContext gameContext) => 
            _entities = gameContext.GetGroup(GameMatcher.CurrentXp);

        public void Execute()
        {
            foreach (GameEntity entity in _entities)
            {
                if (entity.CurrentXp <= 0)
                {
                    entity.isDestructed = true;
                }
            }
        }
    }
}