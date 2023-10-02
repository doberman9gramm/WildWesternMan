using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FSM;

[ExecuteAlways]
public class StatesPool : MonoBehaviour
{
    public List<State> _states;

    private void OnValidate()
    {
        _states.Clear();

        foreach (State state in GetComponents<State>())
            _states.Add(state);
    }
}