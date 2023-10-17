using UnityEngine;
using UnityEditor;

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
        DisplayTabs();
        _statePool.TabManager.OnInspectorGUIUpdate();
    }

    private void DisplayTabs()
    {
        _statePool.TabManager.CurrentTubIndex = GUILayout.Toolbar(_statePool.TabManager.CurrentTubIndex, _statePool.TabManager.GetTabNames());
    }
}