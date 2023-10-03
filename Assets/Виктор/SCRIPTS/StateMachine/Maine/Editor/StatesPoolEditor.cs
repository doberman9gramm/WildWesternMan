#if UNITY_EDITOR
using UnityEditor;

[CustomEditor(typeof(StatesPool))]
public class StatesPoolEditor : Editor
{
    private StatesPool _statesPool;
    private TabManager tabManager;

    private void OnEnable()
    {
        _statesPool = target as StatesPool;
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        var statesList = _statesPool.GetStatesList();
        if (statesList.Count > 0)
        {
            tabManager = new TabManager(_statesPool);
            tabManager.CreateTabs();
        }
    }
}
#endif