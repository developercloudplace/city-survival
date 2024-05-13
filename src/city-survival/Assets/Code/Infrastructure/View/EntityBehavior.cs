using Code.Gameplay.Common.Collisions;
using Code.Infrastructure.View.Registrars;
using UnityEngine;
using Zenject;

namespace Code.Infrastructure.View
{
    public class EntityBehavior : MonoBehaviour, IEntityView
    {
        private GameEntity _entity;
        private ICollisionRegistry _collisionRegistry1;
        public GameEntity Entity => _entity;

        [Inject]
        public void Construct(ICollisionRegistry _collisionRegistry) => 
            _collisionRegistry1 = _collisionRegistry;

        public void SetEntity(GameEntity gameEntity)
        {
            _entity = gameEntity;
            gameEntity.Retain(this);
            _entity.AddView(this);

            foreach (IEntityComponentRegistrar registrar in GetComponentsInChildren<IEntityComponentRegistrar>())
                registrar.RegistrarComponent();
        }

        public void ReleaseEntity()
        {
            foreach (IEntityComponentRegistrar registrar in GetComponentsInChildren<IEntityComponentRegistrar>())
                registrar.UnRegistrarComponent();

            _entity.Release(this);
            _entity = null;
        }
    }
}