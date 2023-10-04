#if UNITY_EDITOR
using UnityEditor;

[CustomEditor(typeof(StatePool))]
public class StatePoolEditor : Editor
{
    private StatePool _statePool;
    private TabManager _tabManager;

    private void OnEnable()
    {
        _statePool = target as StatePool; 
        _tabManager = new TabManager(_statePool);
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if (_statePool.GetStatesArray().Length == 0) return;

        _tabManager.OnInspectorGUI();
    }
}
#endif