using Code.Gameplay.Features.Player.Behaviours;
using Code.Infrastructure.View.Registrars;

namespace Code.Gameplay.Registrar
{
    public class PlayerAnimatorRegistrar : EntityComponentRegistrar
    {
        public PlayerAnimator PlayerAnimator;

        public override void RegistrarComponent()
        {
            Entity
                .AddPlayerAnimator(PlayerAnimator)
                .AddDamageTakenAnimator(PlayerAnimator);
        }

        public override void UnRegistrarComponent()
        {
            if (Entity.hasPlayerAnimator)
                Entity.RemovePlayerAnimator();

            if (Entity.hasDamageTakenAnimator)
                Entity.RemoveDamageTakenAnimator();
        }
    }
}