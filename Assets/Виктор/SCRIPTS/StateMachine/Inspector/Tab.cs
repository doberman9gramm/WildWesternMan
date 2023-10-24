using FSM;
using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Tab
{
    [SerializeField] private State _state;
    public List<Component> Components = new List<Component>();
    public string Name => _state.GetType().Name;

    public Tab(State state)
    {
        _state = state;
    }

    public void SetComponentsHideFlag(HideFlags hideFlags)
    {
        _state.hideFlags = hideFlags;

        foreach (var component in Components)
            component.hideFlags = hideFlags;
    }
}