using System.Collections.Generic;
using UnityEngine;
using FSM;

/// <summary>
/// Этот класс заполняет свой лист всеми состояниями на игровом обьекте
/// </summary>
[ExecuteAlways]
public class StatesPool : MonoBehaviour
{
    public List<State> _states;//Стоит инкапсулировать

    private void OnValidate()
    {
        RefreshList();
    }

    private void RefreshList()
    {
        _states.Clear();

        foreach (State state in GetComponents<State>())
            _states.Add(state);
    }
}