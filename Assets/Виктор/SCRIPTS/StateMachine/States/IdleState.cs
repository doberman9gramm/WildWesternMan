using UnityEngine;

namespace FSM
{
    public class IdleState : State 
    {
        [SerializeField] private AnimatorFSM _animator;
        private const string _walk = "Idle";

        private void OnEnable()
        {
            _animator.ChangeAnimation(_walk);
        }
    }
}