using HealthSpace;
using UnityEngine;

namespace FSM
{
    public class DeadTransition : Transition
    {
        [SerializeField] private Health _health;

        protected override void OnEnable()
        {
            base.OnEnable();
            _health.Dead += Transit;
        }

        protected override void OnDisable()
        {
            base.OnDisable();
            _health.Dead -= Transit;
        }
    }
}