namespace Code.Infrastructure.View.Factory
{
    public interface IEntityViewFactory
    {
        EntityBehavior CreateViewForEntity(GameEntity entity);
        EntityBehavior CreateViewForEntityFromPrefab(GameEntity entity);
    }
}