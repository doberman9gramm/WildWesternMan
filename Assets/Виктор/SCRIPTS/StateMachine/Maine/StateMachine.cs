using UnityEngine;

namespace FSM
{
    [RequireComponent(typeof(StatesPool))]
    public class StateMachine : MonoBehaviour
    {
        [SerializeField] private State _startState;

        private State _currentState;

        private void Start() => EnterToState(_startState);

        private void Update() => GetAndEnterNewState();

        private void GetAndEnterNewState()
        {
            var nextState = _currentState.GetNewState();

            if (nextState != null)
                EnterToState(nextState);
        }

        private void EnterToState(State nextState)
        {
            ExitPreviousState();
            EnterNewState(nextState);
        }

        private void ExitPreviousState()
        {
            if (_currentState != null)
                _currentState.Exit();
        }

        private void EnterNewState(State nextState)
        {
            _currentState = nextState;
            _currentState.Enter();
        }
    }
}