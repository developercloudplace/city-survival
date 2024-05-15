using Code.Infrastructure.View.Registrars;

namespace Code.Gameplay.Registrar
{
    public class RotateRegistrar : EntityComponentRegistrar
    {
        public override void RegistrarComponent() => 
            Entity.AddRotate(transform.rotation);

        public override void UnRegistrarComponent() => 
            Entity.RemoveRotate();
    }
}