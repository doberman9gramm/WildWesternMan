using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

namespace PlayerSpace 
{
    public sealed class PlayerMoving : MonoBehaviour
    {
        [SerializeField] private NavMeshAgent _agent;
        [SerializeField] private InputActionReference _move;

        public bool _isWalking { get; private set; }

        private void OnEnable()
        {
            _agent.enabled = true;
        }

        private void OnDisable()
        {   
            _agent.enabled = false;
        }

        private void Update()
        {
            Move(_move.action.ReadValue<Vector2>());
            _isWalking = CheckWalking();
        }

        private bool CheckWalking()
        {
            return _agent.hasPath ? true : false;
        }

        private void Move(Vector2 destination)
        {
            _agent.SetDestination(transform.position + new Vector3(destination.x, 0, destination.y));
        }
    }
}