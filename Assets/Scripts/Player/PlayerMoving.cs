using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

namespace Player 
{
    public class PlayerMoving : MonoBehaviour
    {
        [SerializeField] private NavMeshAgent _agent;
        [SerializeField] private InputActionReference _input;

        private void Update()
        {
            Vector2 move = _input.action.ReadValue<Vector2>();
            _agent.SetDestination(transform.position + new Vector3(move.x, 0, move.y));
        }
    }
}