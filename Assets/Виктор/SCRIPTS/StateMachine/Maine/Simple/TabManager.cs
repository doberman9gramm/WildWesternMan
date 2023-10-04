using FSM;
using UnityEngine;

public class TabManager
{
    private readonly StatePool _statesPool;

    private int _currentTubIndex = 0;
    private int _currentTubIndexBuffer = 0;
    private ComponentsManager _excludedComponents;//Исключенные компоненты
    private State[] _states;//Исключенные компоненты

    public TabManager(StatePool statesPool)
    {
        _statesPool = statesPool;
        _excludedComponents = new ComponentsManager(_statesPool.Components);

        foreach (Component component in _excludedComponents.Components)
        {
            if (component.GetType().IsSubclassOf(typeof(State)))
            {
                Debug.Log("State finded" + component);//получения стейта
            }
            else
            {
                Debug.Log(component);
            }
        }
    }

    public void OnInspectorGUI()
    {
        DisplayingTabs();
        TabSelected();
    }

    private void DisplayingTabs()
    {
        _states = ChangeStates(_statesPool.GetStatesArray());

        string[] names = new string[_states.Length];

        for (int i = 0; i < _states.Length; i++)
            names[i] = _states[i].GetType().Name;

        _currentTubIndex = GUILayout.Toolbar(_currentTubIndex, names);
    }
    private State[] ChangeStates(State[] states)
    {
        return states;//Сделать смену стейта и компонентов
    }


    private void TabSelected()
    {
        if (_currentTubIndexBuffer != _currentTubIndex)
        {
            _currentTubIndexBuffer = _currentTubIndex;
        }
    }
}

public class ComponentsManager
{
    public Component[] Components { get; private set; }

    public ComponentsManager(Component[] components)
    {
        Components = components;
    }
}