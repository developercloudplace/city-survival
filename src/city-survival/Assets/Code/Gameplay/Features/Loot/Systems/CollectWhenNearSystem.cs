using System.Numerics;
using Entitas;
using Vector3 = UnityEngine.Vector3;

namespace Code.Gameplay.Features.Loot.Systems
{
    public class CollectWhenNearSystem : IExecuteSystem
    {
        private readonly float CloseDistance = 0.2f;
    
        private readonly IGroup<GameEntity> _players;
        private readonly IGroup<GameEntity> _pullables;

        public CollectWhenNearSystem(GameContext game)
        {
            _players = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Player,
                    GameMatcher.WorldPosition));
      
            _pullables = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Pulling,
                    GameMatcher.WorldPosition));
        }

        public void Execute()
        {
            foreach (GameEntity player in _players)
            foreach (GameEntity pullable in _pullables)
            {
                if (Vector3.Distance(player.WorldPosition, pullable.WorldPosition) <= CloseDistance)
                    pullable.isCollected = true;
            }
        }
    
    }

    public class CollectExperienceSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _collected;
        private readonly IGroup<GameEntity> _players;
       // private readonly ILevelUpService _levelUpService;

        public CollectExperienceSystem(GameContext game /*ILevelUpService levelUpService*/)
        {
        //    _levelUpService = levelUpService;
            _collected = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Collected,
                    GameMatcher.Experience));
      
            _players = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Player, 
                    GameMatcher.WorldPosition));

        }

        public void Execute()
        {
            foreach (GameEntity collected in _collected)
            foreach (GameEntity player in _players)
            {
               // _levelUpService.AddExperience(entity.Experience);
               // hero.ReplaceExperience(_levelUpService.CurrentExperience);
               player.ReplaceExperience(player.Experience + collected.Experience);
            }
        }
        
    }
    
}