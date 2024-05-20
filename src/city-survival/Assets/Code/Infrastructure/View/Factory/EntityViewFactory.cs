using Code.Infrastructure.AssetManagement;
using Unity.Mathematics;
using UnityEngine;
using Zenject;

namespace Code.Infrastructure.View.Factory
{
    public class EntityViewFactory : IEntityViewFactory
    {
        private IInstantiator _instantiator;
        private IAssetProvider _assetProvider;

        public EntityViewFactory(IAssetProvider assetProvider, IInstantiator instantiator)
        {
            _assetProvider = assetProvider;
            _instantiator = instantiator;
        }

        public EntityBehavior CreateViewForEntity(GameEntity entity)
        {
            var viewPrefab = _assetProvider.LoadAsset<EntityBehavior>(entity.ViewPath);
            var view = _instantiator.InstantiatePrefabForComponent<EntityBehavior>
                (viewPrefab, new Vector3(-999, 999, 0), quaternion.identity, null);
            view.SetEntity(entity);
            return view;
        }
        public EntityBehavior CreateViewForEntityFromPrefab(GameEntity entity)
        {
         
            var view = _instantiator.InstantiatePrefabForComponent<EntityBehavior>
                (entity.ViewPrefab, new Vector3(-999, 999, 0), quaternion.identity, null);
            view.SetEntity(entity);
            return view;
        }

    
    }
}