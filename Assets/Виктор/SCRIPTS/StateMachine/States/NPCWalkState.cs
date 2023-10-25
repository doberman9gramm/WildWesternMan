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

        private void OnEnable()
        {
            _agent.isStopped = false;
            _animator.ChangeAnimation(_walk);
        }

        private void OnDisable()
        {
            _agent.isStopped = true;
        }

        private void Update()
        {
            _agent.SetDestination(_target.position);
        }
    }
}