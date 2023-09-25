using UnityEngine;

namespace FSM
{
    public abstract class Transition : MonoBehaviour
    {
        [SerializeField] private State _nextState;

        public bool NeedTransit { get; protected set; }

        public State NextState => _nextState;

        protected void Transit() => NeedTransit = true; 

        protected virtual void OnEnable() => NeedTransit = false;

        protected virtual void OnDisable() => NeedTransit = false;
    }
}