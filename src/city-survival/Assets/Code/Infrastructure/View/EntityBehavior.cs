using Code.Infrastructure.View.Registrars;
using UnityEngine;

namespace Code.Infrastructure.View
{
    public class EntityBehavior : MonoBehaviour, IEntityView
    {
        private GameEntity _entity;
        public GameEntity Entity { get; }

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