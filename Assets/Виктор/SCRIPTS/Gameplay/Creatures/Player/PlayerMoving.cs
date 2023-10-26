using System;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

namespace PlayerSpace
{
    public sealed class PlayerMoving : MonoBehaviour
    {
        public Action<bool> IsWalk;

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

            if (_isWalking != IsWalking())
            {
                _isWalking = !_isWalking;
                IsWalk?.Invoke(_isWalking);
            }

        }
        //изменить неймнинг
        private bool IsWalking() => _agent.hasPath;

        private void Move(Vector2 destination)
        {
            _agent.SetDestination(transform.position + new Vector3(destination.x, 0, destination.y));
        }
    }
}