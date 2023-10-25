using UnityEngine;

namespace FSM
{
    public class AttackState : State
    {
        //посмотреть и переделать
        [SerializeField] private Transform _agent;
        [SerializeField] private Transform _target;
        [SerializeField] private Vector3 _correctionLookAtTarget;
        
        [SerializeField] private AnimatorFSM _animator;
        private const string _walk = "Idle";

        private void OnEnable()
        {
            _animator.ChangeAnimation(_walk);
        }

        private void Update()
        {
            _agent.LookAt(new Vector3(_target.position.x, transform.position.y, _target.position.z) + _correctionLookAtTarget);
        }
    }
}
