using Code.Gameplay.Cameras.Provider;
using Code.Gameplay.Cameras.System;
using Code.Gameplay.Features.Player.Systems;
using Code.Infrastructure.System;

namespace Code.Gameplay.Features.Player
{
    public class PlayerFeatures : Feature
    {
        public PlayerFeatures(ISystemFactory systemFactory)
        {
            Add(systemFactory.Create<InitializePlayerSystem>());
            Add(systemFactory.Create<SetPlayerDirectionByInput>());
            Add(systemFactory.Create<CameraFollowPlayerSystem>());
            Add(systemFactory.Create<AnimatePlayerMovementSystem>());
            Add(systemFactory.Create<PlayerDeathSystem>());
            Add(systemFactory.Create<FinalizePlayerDeathProcessingSystem>());
        }
    }
}