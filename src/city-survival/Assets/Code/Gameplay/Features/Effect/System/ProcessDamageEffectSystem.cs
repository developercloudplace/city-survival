using Entitas;

namespace Code.Gameplay.Features.Effect.System
{
   public class ProcessDamageEffectSystem : IExecuteSystem
   {
      private readonly IGroup<GameEntity> _effects;
      private readonly GameContext _game;

      public ProcessDamageEffectSystem(GameContext game)
      {
         _game = game;
         _effects = game.GetGroup(GameMatcher
            .AllOf(
               GameMatcher.DamageEffect,
               GameMatcher.EffectValue,
               GameMatcher.TargetId));
      }

      public void Execute()
      {
         foreach (GameEntity effect in _effects)
         {
            GameEntity target = effect.Target();

            effect.isProcessed = true;
       
            if (target.isDead)
               continue;
        
            target.ReplaceCurrentHp(target.CurrentHp - effect.EffectValue);
        
            if(target.hasDamageTakenAnimator)
               target.DamageTakenAnimator.PlayDamageTaken();
         }
      }
   }
}