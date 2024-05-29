using Code.Gameplay.Features.Armaments.System;
using Code.Infrastructure.System;

public sealed class ArmamentFeature : Feature
{
    public ArmamentFeature(ISystemFactory systems)
    {
        Add(systems.Create<MarkProcessedOnTargetLimitExceededSystem>()); 
        Add(systems.Create<FinalizeProcessedArmamentsSystem>());
    }
}