using FSM;
using UnityEngine;

public class TabManager
{
    private readonly StatesPool _statesPool;

    private int _currentTubIndex = 0;
    private int _currentTubIndexBuffer = 0;

    private State[] _states;

    System.Type[] _excludedType = 
    { 
        typeof(StateMachine),
        typeof(StatesPool),
    };

    public TabManager(StatesPool statesPool)
    {
        _statesPool = statesPool;

        //Какие компоненты должны быть изначально? StateMachine, StatesPool
        //Как удалить остальные компоненты?

        foreach (Component component in _statesPool.Components)
        {
            for (int i = 0; i < _excludedType.Length; i++)
            {
                if (component.GetType() == _excludedType[i])
                {
                    Debug.Log(component.ToString());
                }
            }
        }
    }

    public void Update()
    {
        DisplayingTabs();
        TabSelected();
    }

    private void DisplayingTabs()
    {
        string[] names = GetNamesOfStates(_statesPool.GetStatesArray());

        _currentTubIndex = GUILayout.Toolbar(_currentTubIndex, names);
    }

    private string[] GetNamesOfStates(State[] states)
    {
        _states = states;

        string[] names = new string[_states.Length];

        for (int i = 0; i < _states.Length; i++)
            names[i] = _states[i].GetType().Name;

        return names;
    }

    private void TabSelected()
    {
        if (_currentTubIndexBuffer != _currentTubIndex)
        {
            _currentTubIndexBuffer = _currentTubIndex;
        }
    }
}