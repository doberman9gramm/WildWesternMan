using UnityEngine;
using UnityEngine.AI;

namespace FSM
{
    public class NPCWalkState : State
    {
        [SerializeField] private Transform _target;
        [SerializeField] private NavMeshAgent _agent;

        private void OnEnable()
        {
            _agent.isStopped = false;
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