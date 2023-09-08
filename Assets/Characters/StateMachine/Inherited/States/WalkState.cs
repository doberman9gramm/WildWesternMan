using FSM;
using UnityEngine;
using UnityEngine.AI;

public class WalkState : State
{
    [SerializeField] private NavMeshAgent _agent;
    [SerializeField] private Transform _target;

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
        if (_target != null)
            _agent.SetDestination(_target.position);
        else
            Debug.Log("у агента нет цели!");
        
    }
}
