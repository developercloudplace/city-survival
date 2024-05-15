using Code.Infrastructure.View.Registrars;

namespace Code.Gameplay.Registrar
{
    public class TransformRegistrar : EntityComponentRegistrar
    {
        public override void RegistrarComponent() => 
            Entity.AddTransform(transform);

        public override void UnRegistrarComponent() => 
            Entity.RemoveTransform();
    }
}