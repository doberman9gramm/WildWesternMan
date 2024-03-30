using System.Collections.Generic;
using UnityEngine;

namespace FSM
{
    public abstract class State : MonoBehaviour
    {
        private readonly List<Transition> _transitions = new List<Transition>();

        protected void Awake() => FillTransitionList();

        private void FillTransitionList()
        {
            foreach (Transition transition in GetComponents<Transition>())
                _transitions.Add(transition);
        }

        internal State TryGetNewState()
        {
            foreach (var transition in _transitions)
                if (transition != null)
                    if (transition.NeedTransit)
                        return transition.NextState;
            return null;
        }

        internal void Enter()
        {
            enabled = true;
            gameObject.SetActive(true);

            foreach (var transition in _transitions)
                if (transition != null)
                    transition.enabled = true;
        }

        internal void Exit()
        {
            foreach (var transition in _transitions)
                transition.enabled = false;

            enabled = false;
            gameObject.SetActive(false);
        }
    }
}