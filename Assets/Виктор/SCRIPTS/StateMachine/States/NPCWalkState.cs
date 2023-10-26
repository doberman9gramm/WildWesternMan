using UnityEngine;
using UnityEngine.AI;

namespace FSM
{
    public class NPCWalkState : State
    {
        [SerializeField] private Transform _target;
        [SerializeField] private NavMeshAgent _agent;

        [SerializeField] private AnimatorFSM _animator;
        private const string _walk = "Walk";
        private const string _idle = "Idle";

        private void OnEnable()
        {
            _animator.ChangeAnimation(_walk);
            _agent.isStopped = false;
        }

        private void OnDisable()
        {
            _animator.ChangeAnimation(_idle);
            _agent.isStopped = true;
        }

        private void Update()
        {
            _agent.SetDestination(_target.position);
        }
    }
}