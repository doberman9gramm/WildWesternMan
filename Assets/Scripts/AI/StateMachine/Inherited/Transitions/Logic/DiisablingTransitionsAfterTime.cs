using FSM;
using System.Collections.Generic;
using UnityEngine;

/// <summary> 
/// Отключение переходов по истечению времени
/// </summary>
public class DiisablingTransitionsAfterTime : MonoBehaviour
{
    [SerializeField] private List<Transition> _transitions = new List<Transition>();
    [SerializeField] private float _seconds;
    [SerializeField] private bool _valueAfterTime;

    private void OnEnable()
    {
        FunctionTimer.Create(() => ToggleAllTransitions(_valueAfterTime), _seconds, name);
    }

    private void OnDisable()
    {
        FunctionTimer.StopTimer(name);
    }

    private void ToggleAllTransitions(bool isEnabled)
    {
        foreach (var transition in _transitions)
            transition.enabled = isEnabled;
    }
}