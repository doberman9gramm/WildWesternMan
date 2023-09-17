using FSM;
using HealthSpace;
using UnityEngine;

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

    private void Transit()
    {
        NeedTransit = true;
    }
}