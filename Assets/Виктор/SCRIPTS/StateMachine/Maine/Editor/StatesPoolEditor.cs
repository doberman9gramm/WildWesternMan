using FSM;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(StatesPool))]
public class StatesPoolEditor : Editor
{
    private StatesPool _statePool;
    private State[] _states;

    private int _currentTubIndex = 0;
    private int _currentTubIndexBuffer = 0;

    private void OnEnable()
    {
        _statePool = target as StatesPool;
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if (HasStates)
        {
            DisplayingTabs();
            TabSelected();
        }
    }
    private bool HasStates => _statePool.GetStatesArray().Length != 0;

    private void DisplayingTabs()
    {
        string[] names = GetNamesOfStates(_statePool.GetStatesArray());

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
            Debug.Log("Open tab number " + _currentTubIndex);
            _currentTubIndexBuffer = _currentTubIndex;
        }
    }
}