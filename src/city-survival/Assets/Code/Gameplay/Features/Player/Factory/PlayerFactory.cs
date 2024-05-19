using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Infrastructure.Identifiers;
using UnityEngine;

namespace Code.Gameplay.Features.Player.Factory
{
    public class PlayerFactory : IPlayerFactory
    {
        private IIdentifierService _identifier;

        public PlayerFactory(IIdentifierService identifier) => 
            _identifier = identifier;

        public GameEntity CreatePlayer(Vector3 at)
        {
            return CreateEntity.Empty()
                    .AddId(_identifier.Next())
                    .AddWorldPosition(at)
                    .AddCurrentXp(10)
                    .AddMaxXp(10)
                    .AddSpeed(10)
                    .AddDirection(Vector3.zero)
                    .With(x => x.isPlayer = true)   
                    .With(x => x.isRotating = true)
                    .With(x => x.isMovementAvailable = true)
                ;
        }
    }
}