//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentLookupGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public static class GameComponentsLookup {

    public const int Destructed = 0;
    public const int SelfDestructTimer = 1;
    public const int View = 2;
    public const int ViewPath = 3;
    public const int ViewPrefab = 4;
    public const int Damage = 5;
    public const int DamageTakenAnimator = 6;
    public const int Id = 7;
    public const int Rotate = 8;
    public const int StatusVisuals = 9;
    public const int Transform = 10;
    public const int Velocity = 11;
    public const int WorldPosition = 12;
    public const int AbilityId = 13;
    public const int CurrentTarget = 14;
    public const int CurrentTargetPosition = 15;
    public const int DroneAbility = 16;
    public const int MachineGunAbility = 17;
    public const int Armament = 18;
    public const int EffectSetups = 19;
    public const int Processed = 20;
    public const int StatusSetups = 21;
    public const int TargetLimits = 22;
    public const int BaseStats = 23;
    public const int StatChange = 24;
    public const int StatModifiers = 25;
    public const int Cooldown = 26;
    public const int CooldownLeft = 27;
    public const int CooldownUp = 28;
    public const int DamageEffect = 29;
    public const int Effect = 30;
    public const int EffectValue = 31;
    public const int ProducerId = 32;
    public const int TargetId = 33;
    public const int Enemy = 34;
    public const int EnemyAnimator = 35;
    public const int EnemyTypeId = 36;
    public const int SpawnTimer = 37;
    public const int CurrentHp = 38;
    public const int Dead = 39;
    public const int MaxHp = 40;
    public const int ProcessingDeath = 41;
    public const int Direction = 42;
    public const int MovementAvailable = 43;
    public const int Moving = 44;
    public const int Rotating = 45;
    public const int Speed = 46;
    public const int Player = 47;
    public const int PlayerAnimator = 48;
    public const int Affected = 49;
    public const int Applied = 50;
    public const int ApplierStatusLink = 51;
    public const int Burning = 52;
    public const int Duration = 53;
    public const int Freeze = 54;
    public const int Period = 55;
    public const int Status = 56;
    public const int StatusTypeId = 57;
    public const int TimeLeft = 58;
    public const int TimeSinceLastTick = 59;
    public const int Unapplied = 60;
    public const int CollectingTargetsContinuously = 61;
    public const int CollectTargetRadius = 62;
    public const int CollectTargetsInterval = 63;
    public const int CollectTargetsTimer = 64;
    public const int LayerMask = 65;
    public const int ProcessedTargetsBuffer = 66;
    public const int ReadyToCollectTargets = 67;
    public const int TargetBuffer = 68;
    public const int AxisInput = 69;
    public const int Input = 70;

    public const int TotalComponents = 71;

    public static readonly string[] componentNames = {
        "Destructed",
        "SelfDestructTimer",
        "View",
        "ViewPath",
        "ViewPrefab",
        "Damage",
        "DamageTakenAnimator",
        "Id",
        "Rotate",
        "StatusVisuals",
        "Transform",
        "Velocity",
        "WorldPosition",
        "AbilityId",
        "CurrentTarget",
        "CurrentTargetPosition",
        "DroneAbility",
        "MachineGunAbility",
        "Armament",
        "EffectSetups",
        "Processed",
        "StatusSetups",
        "TargetLimits",
        "BaseStats",
        "StatChange",
        "StatModifiers",
        "Cooldown",
        "CooldownLeft",
        "CooldownUp",
        "DamageEffect",
        "Effect",
        "EffectValue",
        "ProducerId",
        "TargetId",
        "Enemy",
        "EnemyAnimator",
        "EnemyTypeId",
        "SpawnTimer",
        "CurrentHp",
        "Dead",
        "MaxHp",
        "ProcessingDeath",
        "Direction",
        "MovementAvailable",
        "Moving",
        "Rotating",
        "Speed",
        "Player",
        "PlayerAnimator",
        "Affected",
        "Applied",
        "ApplierStatusLink",
        "Burning",
        "Duration",
        "Freeze",
        "Period",
        "Status",
        "StatusTypeId",
        "TimeLeft",
        "TimeSinceLastTick",
        "Unapplied",
        "CollectingTargetsContinuously",
        "CollectTargetRadius",
        "CollectTargetsInterval",
        "CollectTargetsTimer",
        "LayerMask",
        "ProcessedTargetsBuffer",
        "ReadyToCollectTargets",
        "TargetBuffer",
        "AxisInput",
        "Input"
    };

    public static readonly System.Type[] componentTypes = {
        typeof(Code.Common.Destructed),
        typeof(Code.Common.SelfDestructTimer),
        typeof(Code.Common.View),
        typeof(Code.Common.ViewPath),
        typeof(Code.Common.ViewPrefab),
        typeof(Code.Gameplay.Common.Damage),
        typeof(Code.Gameplay.Common.DamageTakenAnimatorComponent),
        typeof(Code.Gameplay.Common.Id),
        typeof(Code.Gameplay.Common.RotateComponent),
        typeof(Code.Gameplay.Common.StatusVisualsComponent),
        typeof(Code.Gameplay.Common.TransformComponent),
        typeof(Code.Gameplay.Common.Velocity),
        typeof(Code.Gameplay.Common.WorldPosition),
        typeof(Code.Gameplay.Features.Abilities.AbilityIdComponent),
        typeof(Code.Gameplay.Features.Abilities.CurrentTarget),
        typeof(Code.Gameplay.Features.Abilities.CurrentTargetPosition),
        typeof(Code.Gameplay.Features.Abilities.DroneAbilityComponent),
        typeof(Code.Gameplay.Features.Abilities.MachineGunAbilityComponent),
        typeof(Code.Gameplay.Features.Armaments.Armament),
        typeof(Code.Gameplay.Features.Armaments.EffectSetups),
        typeof(Code.Gameplay.Features.Armaments.Processed),
        typeof(Code.Gameplay.Features.Armaments.StatusSetups),
        typeof(Code.Gameplay.Features.Armaments.TargetLimits),
        typeof(Code.Gameplay.Features.CharacterStats.BaseStats),
        typeof(Code.Gameplay.Features.CharacterStats.StatChange),
        typeof(Code.Gameplay.Features.CharacterStats.StatModifiers),
        typeof(Code.Gameplay.Features.Cooldowns.Cooldown),
        typeof(Code.Gameplay.Features.Cooldowns.CooldownLeft),
        typeof(Code.Gameplay.Features.Cooldowns.CooldownUp),
        typeof(Code.Gameplay.Features.Effect.DamageEffect),
        typeof(Code.Gameplay.Features.Effect.Effect),
        typeof(Code.Gameplay.Features.Effect.EffectValue),
        typeof(Code.Gameplay.Features.Effect.ProducerId),
        typeof(Code.Gameplay.Features.Effect.TargetId),
        typeof(Code.Gameplay.Features.Enemies.Enemy),
        typeof(Code.Gameplay.Features.Enemies.EnemyAnimatorComponent),
        typeof(Code.Gameplay.Features.Enemies.EnemyTypeIdComponent),
        typeof(Code.Gameplay.Features.Enemies.SpawnTimer),
        typeof(Code.Gameplay.Features.LifeTime.CurrentHp),
        typeof(Code.Gameplay.Features.LifeTime.Dead),
        typeof(Code.Gameplay.Features.LifeTime.MaxHp),
        typeof(Code.Gameplay.Features.LifeTime.ProcessingDeath),
        typeof(Code.Gameplay.Features.Movement.Direction),
        typeof(Code.Gameplay.Features.Movement.MovementAvailable),
        typeof(Code.Gameplay.Features.Movement.Moving),
        typeof(Code.Gameplay.Features.Movement.Rotating),
        typeof(Code.Gameplay.Features.Movement.Speed),
        typeof(Code.Gameplay.Features.Player.Systems.Player),
        typeof(Code.Gameplay.Features.Player.Systems.PlayerAnimatorComponent),
        typeof(Code.Gameplay.Features.Statuses.Affected),
        typeof(Code.Gameplay.Features.Statuses.Applied),
        typeof(Code.Gameplay.Features.Statuses.ApplierStatusLink),
        typeof(Code.Gameplay.Features.Statuses.Burning),
        typeof(Code.Gameplay.Features.Statuses.Duration),
        typeof(Code.Gameplay.Features.Statuses.Freeze),
        typeof(Code.Gameplay.Features.Statuses.Period),
        typeof(Code.Gameplay.Features.Statuses.Status),
        typeof(Code.Gameplay.Features.Statuses.StatusTypeIdComponent),
        typeof(Code.Gameplay.Features.Statuses.TimeLeft),
        typeof(Code.Gameplay.Features.Statuses.TimeSinceLastTick),
        typeof(Code.Gameplay.Features.Statuses.Unapplied),
        typeof(Code.Gameplay.Features.TargetCollection.CollectingTargetsContinuously),
        typeof(Code.Gameplay.Features.TargetCollection.CollectTargetRadius),
        typeof(Code.Gameplay.Features.TargetCollection.CollectTargetsInterval),
        typeof(Code.Gameplay.Features.TargetCollection.CollectTargetsTimer),
        typeof(Code.Gameplay.Features.TargetCollection.LayerMask),
        typeof(Code.Gameplay.Features.TargetCollection.ProcessedTargetsBuffer),
        typeof(Code.Gameplay.Features.TargetCollection.ReadyToCollectTargets),
        typeof(Code.Gameplay.Features.TargetCollection.TargetBuffer),
        typeof(Code.Gameplay.Input.System.AxisInput),
        typeof(Code.Gameplay.Input.System.Input)
    };
}
