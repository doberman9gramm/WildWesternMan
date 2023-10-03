#if UNITY_EDITOR
using FSM;
using UnityEditor;
using UnityEngine;


[CustomEditor(typeof(StatesPool))]
public class StatesPoolEditor : Editor
{
    //statesArray[i].hideFlags = HideFlags.HideInInspector;
    private State[] statesArray;
    private string[] _tabs;
    private int _tabsSelected = 0;

    private void OnEnable()
    {
        var statesPool = target as StatesPool;
        if (statesPool == null) return;

        statesArray = statesPool._states.ToArray();
        _tabs = new string[statesArray.Length];
        for (int i = 0; i < statesArray.Length; i++)
            _tabs[i] = statesArray[i].GetType().Name;
    }

    public override void OnInspectorGUI()
    {
        Debug.Log("StatesPoolEditor.OnInspectorGUI()");
        DisplayingTabs();

        if (_tabsSelected >= 0 || _tabsSelected < _tabs.Length)
            OptionOne(statesArray[_tabsSelected]);
    }

    private void DisplayingTabs()
    {
        _tabsSelected = GUILayout.Toolbar(_tabsSelected, _tabs);
    }

    private void OptionOne(State state)
    {

    }
}
#endif