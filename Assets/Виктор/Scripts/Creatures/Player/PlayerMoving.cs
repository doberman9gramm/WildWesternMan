using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

namespace PlayerSpace 
{
    public class PlayerMoving : MonoBehaviour
    {
        [SerializeField] private NavMeshAgent _agent;
        [SerializeField] private InputActionReference _input;
        [SerializeField] private bool _deactivationNavMeshAgentAfterOnDisable = true;

        private void OnEnable()
        {
            _agent.enabled = true;
        }

        private void OnDisable()
        {   
            if(_deactivationNavMeshAgentAfterOnDisable)
                _agent.enabled = false;
        }


        private void Update()
        {
            Vector2 move = _input.action.ReadValue<Vector2>();
            _agent.SetDestination(transform.position + new Vector3(move.x, 0, move.y));
        }
    }
}