using System.Collections.Generic;
using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.Features.CharacterStats;
using Code.Infrastructure.Identifiers;
using UnityEngine;

namespace Code.Gameplay.Features.Player.Factory
{
    public class PlayerFactory : IPlayerFactory
    {
        private readonly IIdentifierService _identifier;

        public PlayerFactory(IIdentifierService identifier) =>
            _identifier = identifier;

        public GameEntity CreatePlayer(Vector3 at)
        {
            Dictionary<Stats, float> baseStats = InitStats
                .EmptyStatDictionary() // TODO:Change to getting from the config
                .With(x => x[Stats.Speed] = 10)
                .With(x => x[Stats.MaxHp] = 10);


            return CreateEntity.Empty()
                    .AddId(_identifier.Next())
                    .AddWorldPosition(at)
                    .AddBaseStats(baseStats)
                    .AddStatModifiers(InitStats.EmptyStatDictionary())
                    .AddSpeed(baseStats[Stats.Speed])
                    .AddCurrentHp(baseStats[Stats.MaxHp])
                    .AddMaxHp(baseStats[Stats.MaxHp])
                    .AddViewPath("Player/Player") //Resources path. TODO:place Addressable labels
                    .AddDirection(Vector3.zero)
                    .With(x => x.isPlayer = true)
                    .With(x => x.isRotating = true)
                    .With(x => x.isMovementAvailable = true)
                ;
        }
    }
}