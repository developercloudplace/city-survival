using Code.Common.Extensions;
using Code.Gameplay.Cameras.Provider;
using Entitas;
using UnityEngine;
using NotImplementedException = System.NotImplementedException;

namespace Code.Gameplay.Cameras.System
{
    public class CameraFollowPlayerSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _players;
        private readonly ICameraProvider _cameraProvider;

        public CameraFollowPlayerSystem(GameContext gameContext, ICameraProvider cameraProvider)
        {
            _cameraProvider = cameraProvider;
            _players = gameContext.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Player,
                    GameMatcher.WorldPosition));
        }

        public void Execute()
        {
            foreach (var player in _players)
            {
                 _cameraProvider.MainCamera.transform.SetWorldXZ(player.WorldPosition.x, player.WorldPosition.z);
              // _cameraProvider.MainCamera.transform.position =
                 //  new Vector3(player.WorldPosition.x, 0,player.WorldPosition.z);
            }
        }
    }
}