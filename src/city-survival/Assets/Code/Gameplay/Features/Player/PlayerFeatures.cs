using Code.Gameplay.Features.Player.Systems;

namespace Code.Gameplay.Features.Player
{
    public class PlayerFeatures : Feature
    {
        public PlayerFeatures(GameContext gameContext)
        {
            Add(new SetPlayerDirectionByInput(gameContext));
        }
    }
}