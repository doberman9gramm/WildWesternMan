using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using FSM;

/// <summary>
/// Этот класс заполняет свой лист всеми состояниями на игровом обьекте
/// </summary>
[ExecuteAlways]
public class StatesPool : MonoBehaviour
{
    public List<State> GetStatesList()
    {
        List<State> states = new List<State>();

        foreach (State state in GetComponents<State>())
            states.Add(state);

        return states;
    }

    public Component[] Components => GetComponents<Component>();
}