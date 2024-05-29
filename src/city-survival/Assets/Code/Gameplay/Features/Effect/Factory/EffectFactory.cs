using System;
using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Infrastructure.Identifiers;

namespace Code.Gameplay.Features.Effect.Factory
{
    public class EffectFactory : IEffectFactory
    {
        private readonly IIdentifierService _identifierService;

        public EffectFactory(IIdentifierService identifierService)
        {
            _identifierService = identifierService;
        }

        public GameEntity CreateEffect(EffectSetup setup, int producerId, int targetId)
        {
            switch (setup.EffectTypeId)
            {
                case EffectTypeId.Unknown:
                    break;
                case EffectTypeId.Damage:
                   return CreateDamage(producerId, targetId, setup.Value);
                default:
                    throw new ArgumentOutOfRangeException();
            }

            throw new Exception($"Effect with type id{setup.EffectTypeId} note exit");
        }

        private GameEntity CreateDamage(int producerId, int targetId, float setupValue)
        {
           return CreateEntity.Empty()
                .AddId(_identifierService.Next())
                .With(x => x.isEffect = true)
                .With(x => x.isDamageEffect = true)
                .AddEffectValue(setupValue)
                .AddProducerId(producerId)
                .AddTargetId(targetId);
        }
    }
}