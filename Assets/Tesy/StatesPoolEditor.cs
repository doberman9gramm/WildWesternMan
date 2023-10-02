using UnityEditor;
using UnityEngine;
using FSM;


[CustomEditor(typeof(StatesPool))]
public class StatesPoolEditor : Editor
{
    private string[] _tabs;
    private int _tabsSelected = 0;

    public override void OnInspectorGUI()
    {
        var statesPool = (StatesPool)target;
        if (statesPool == null) return;

        State[] statesArray = statesPool._states.ToArray();
        _tabs = new string[statesArray.Length];
        for (int i = 0; i < statesArray.Length; i++)
            _tabs[i] = statesArray[i].ToString();



        EditorGUILayout.BeginVertical();
        _tabsSelected = GUILayout.Toolbar(_tabsSelected, _tabs);
        EditorGUILayout.EndVertical();

        if (_tabsSelected >= 0 || _tabsSelected < _tabs.Length)
        {
            switch (_tabs[_tabsSelected])
            {
                case "Option One":
                    OptionOne();
                    break;
                case "Option Two":
                    OptionTwo();
                    break;
                case "Option Three":
                    Options("Option Three", MessageType.Warning);
                    break;
                case "Option Four":
                    Options("Option Four", MessageType.None);
                    break;
            }
        }
    }

    private void OptionOne()
    {
        EditorGUILayout.HelpBox("One", MessageType.Error);
        EditorGUILayout.TextArea("Lol");
    }

    private void OptionTwo()
    {
        EditorGUILayout.HelpBox("Two", MessageType.Info);
    }

    private void Options(string value, MessageType type)
    {
        EditorGUILayout.HelpBox(value, type);
    }
}