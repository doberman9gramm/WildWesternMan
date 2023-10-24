using FSM;
using UnityEngine;

[ExecuteAlways]
public class StatesPool : MonoBehaviour
{
    [SerializeField] private TabControl _tabs;
    public TabControl Tabs => _tabs;

    private void Start()
    {
        Debug.Log("Awake");
        _tabs = new TabControl(this);
    }

    public State[] GetStatesArray() => GetComponents<State>();
    public Component[] Components => GetComponents<Component>();
}