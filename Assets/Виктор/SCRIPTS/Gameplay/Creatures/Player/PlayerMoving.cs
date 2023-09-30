using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;
using System;

namespace PlayerSpace 
{
    public class PlayerMoving : MonoBehaviour
    {   
        [SerializeField] private NavMeshAgent _agent;
        [SerializeField] private InputActionReference _input;
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
            Move(_input.action.ReadValue<Vector2>());
        }

        private void Move(Vector2 destination)
        {
            _agent.SetDestination(transform.position + new Vector3(destination.x, 0, destination.y));

            _isWalking = _agent.hasPath ? true : false;
        }
    }
}