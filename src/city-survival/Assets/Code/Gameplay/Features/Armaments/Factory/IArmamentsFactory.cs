using UnityEngine;

namespace Code.Gameplay.Features.Armaments.Factory
{
    public interface IArmamentsFactory
    {
       GameEntity CreateMachineGunShell(int level, Vector3 at);
    }
}