namespace Code.Infrastructure.View.Registrars
{
    public abstract class EntityComponentRegistrar : EntityDependant, IEntityComponentRegistrar
    {
        public abstract void RegistrarComponent();
        public abstract void UnRegistrarComponent();
    }
}