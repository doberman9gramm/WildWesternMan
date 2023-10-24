using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

[CustomEditor(typeof(StatesPool))]
public class StatesPoolEditor : Editor
{
    private StatesPool _statePool;

    private void OnEnable()
    {
        _statePool = target as StatesPool;
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if (_statePool.Tabs == null)
            return;
        DisplayTabsAndGetCurrentTab();
        _statePool.Tabs.OnInspectorGUIUpdate();
    }

    private void DisplayTabsAndGetCurrentTab()
    {
        _statePool.Tabs.IndexOfCurrentTub = GUILayout.Toolbar(
            _statePool.Tabs.IndexOfCurrentTub,
            GetTabsNames(_statePool.Tabs.GetTabs));
    }

    public string[] GetTabsNames(List<Tab> tabs)
    {
        string[] names = new string[tabs.Count];
        for (int i = 0; i < tabs.Count; i++)
            names[i] = tabs[i].Name;

        return names;
    }
}