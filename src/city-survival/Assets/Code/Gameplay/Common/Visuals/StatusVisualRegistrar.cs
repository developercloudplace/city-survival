using Code.Infrastructure.View.Registrars;

namespace Code.Gameplay.Common.Visuals
{
    public class StatusVisualsRegistrar : EntityComponentRegistrar
    {
        public StatusVisuals StatusVisuals;


        public override void RegistrarComponent()
        {
            Entity.AddStatusVisuals(StatusVisuals);
        }

        public override void UnRegistrarComponent()
        {
            if (Entity.hasStatusVisuals)
                Entity.RemoveStatusVisuals();
        }
    }
}