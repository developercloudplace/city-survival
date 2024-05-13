using Code.Gameplay.Common.Collisions;
using Code.Infrastructure.View.Registrars;
using UnityEngine;
using Zenject;

namespace Code.Infrastructure.View
{
    public class EntityBehavior : MonoBehaviour, IEntityView
    {
        private GameEntity _entity;
        private ICollisionRegistry _collisionRegistry;
        public GameEntity Entity => _entity;

        [Inject]
        public void Construct(ICollisionRegistry collisionRegistry) =>
            _collisionRegistry = collisionRegistry;

        public void SetEntity(GameEntity gameEntity)
        {
            _entity = gameEntity;
            gameEntity.Retain(this);
            _entity.AddView(this);

            foreach (IEntityComponentRegistrar registrar in GetComponentsInChildren<IEntityComponentRegistrar>())
                registrar.RegistrarComponent();
            foreach (Collider collider in GetComponentsInChildren<Collider>(true))
                _collisionRegistry.Register(collider.GetInstanceID(), _entity);
        }

        public void ReleaseEntity()
        {
            foreach (IEntityComponentRegistrar registrar in GetComponentsInChildren<IEntityComponentRegistrar>())
                registrar.UnRegistrarComponent();
            foreach (Collider collider in GetComponentsInChildren<Collider>(true))
                _collisionRegistry.Unregister(collider.GetInstanceID());

            _entity.Release(this);
            _entity = null;
        }
    }
}