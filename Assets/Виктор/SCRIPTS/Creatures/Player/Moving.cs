using System;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

namespace PlayerSpace
{
    public sealed class Moving : MonoBehaviour
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
            if (Move(_move.action.ReadValue<Vector2>()))
            {
                if (_isWalking != IsWalking())
                {
                    _isWalking = !_isWalking;//баг 1) ѕри двойном нажатие на лошади идти куда-то сохран€етс€ анимаци€ идти хот€ персонаж не идЄт
                    IsWalk?.Invoke(_isWalking);
                }
            }
        }
        //изменить неймнинг
        private bool IsWalking() => _agent.hasPath;

        private bool Move(Vector2 destination)
        {
            return _agent.SetDestination(transform.position + new Vector3(destination.x, 0, destination.y));
        }
    }
}