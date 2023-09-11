using FSM;
using UnityEngine;


/// <summary> 
/// Переход по истечению времени
/// </summary>
public class TransitionAfterTime : Transition
{
    [SerializeField, Min(0)] private float _seconds;

    protected override void OnEnable()
    {
        base.OnEnable();
        FunctionTimer.Create(() => Transit(), _seconds, name);
    }

    protected override void OnDisable()
    {
        base.OnDisable();
        FunctionTimer.StopTimer(name);
    }

    private bool Transit() => NeedTransit = true;
}