using Code.Gameplay.Cameras.Provider;
using Code.Gameplay.Cameras.System;
using Code.Gameplay.Features.Player.Systems;

namespace Code.Gameplay.Features.Player
{
    public class PlayerFeatures : Feature
    {
        public PlayerFeatures(GameContext gameContext,ICameraProvider cameraProvider)
        {
            Add(new SetPlayerDirectionByInput(gameContext));
            Add(new CameraFollowPlayerSystem(gameContext,cameraProvider));
            Add(new AnimatePlayerMovementSystem(gameContext));
        }
    }
}