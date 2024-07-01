using Code.Gameplay.Features.Player.Behaviours;
using Entitas;

namespace Code.Gameplay.Features.Player
{
    [Game] public class Player: IComponent{}
    [Game] public class PlayerAnimatorComponent: IComponent{public PlayerAnimator Value;}
}