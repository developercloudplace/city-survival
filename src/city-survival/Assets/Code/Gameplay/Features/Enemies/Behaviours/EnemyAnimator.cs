using Code.Gameplay.Common.Visuals;
using UnityEngine;

namespace Code.Gameplay.Features.Enemies.Behaviours
{
    public class EnemyAnimator : MonoBehaviour, IDamageTakenAnimator
    {
        private readonly int _isMovingHash = Animator.StringToHash("isMoving");
        private readonly int _attackHash = Animator.StringToHash("attack");
        private readonly int _takeDamageHash = Animator.StringToHash("takeDamage");
        private readonly int _diedHash = Animator.StringToHash("died");

        public Animator Animator;
     

        public void PlayMove() => Animator.SetBool(_isMovingHash, true);
        public void PlayIdle() => Animator.SetBool(_isMovingHash, false);

        public void PlayAttack() => Animator.SetTrigger(_attackHash);

        public void PlayDied() => Animator.SetTrigger(_diedHash);

        public void PlayDamageTaken()
        {
            Animator.SetTrigger(_takeDamageHash);
        }


        public void ResetAll()
        {
            Animator.ResetTrigger(_attackHash);
            Animator.ResetTrigger(_diedHash);
        }
    }
}