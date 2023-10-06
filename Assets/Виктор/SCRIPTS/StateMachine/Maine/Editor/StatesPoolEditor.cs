#if UNITY_EDITOR
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

    }
}
#endif