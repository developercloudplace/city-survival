﻿using Code.Gameplay.Common.Visuals;
using Unity.Mathematics;
using UnityEngine;

namespace Code.Gameplay.Features.Player.Behaviours
{
    public class PlayerAnimator : MonoBehaviour, IDamageTakenAnimator
    {
        private readonly int _isMovingHash = Animator.StringToHash("isMoving");
        private readonly int _attackHash = Animator.StringToHash("attack");
        private readonly int _takeDamageHash = Animator.StringToHash("takeDamage");
        private readonly int _diedHash = Animator.StringToHash("died");

        public Animator Animator;
        public Transform point;
        public GameObject fx;
        private bool _takeDamage = true;

        public void PlayMove() => Animator.SetBool(_isMovingHash, true);
        public void PlayIdle() => Animator.SetBool(_isMovingHash, false);

        public void PlayDamageTaken()
        {
            if (_takeDamage)
            {
                var go = Instantiate(fx, point.position, quaternion.identity);
                Destroy(go, .3f);
            }
        }

        public void PlayDied() => Animator.SetTrigger(_diedHash);

        public void StopDamageTaken() => 
            _takeDamage = false;

        public void PlayAttack() => Animator.SetTrigger(_attackHash);


        public void ResetAll()
        {
            Animator.ResetTrigger(_attackHash);
            Animator.ResetTrigger(_diedHash);
        }
    }
}