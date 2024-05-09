using UnityEngine;

namespace Code.Gameplay.Features.Player.Behaviours
{
    public class PlayerAnimator : MonoBehaviour
    {
        private readonly int _isMovingHash = Animator.StringToHash("isMoving");
        private readonly int _attackHash = Animator.StringToHash("attack");
        private readonly int _diedHash = Animator.StringToHash("died");

        public Animator Animator;

        public void PlayMove() => Animator.SetBool(_isMovingHash, true);
        public void PlayIdle() => Animator.SetBool(_isMovingHash, false);

        public void PlayAttack() => Animator.SetTrigger(_attackHash);

        public void PlayDied() => Animator.SetTrigger(_diedHash);

        public void PlayDamageTaken()
        {
            // if (DOTween.IsTweening(Material))
            //     return;

            // Material.DOFloat(0.5f, OverlayIntensityProperty, 0.15f)
            //     .OnComplete(() =>
            //     {
            //         if (SpriteRenderer)
            //             Material.DOFloat(0, OverlayIntensityProperty, 0.15f);
            //     });
        }

        public void ResetAll()
        {
            Animator.ResetTrigger(_attackHash);
            Animator.ResetTrigger(_diedHash);
        }
    }
}