using FSM;
using UnityEngine;

public class StatesPool : MonoBehaviour
{
    [SerializeField] private TabControl _tabManager;
    public TabControl TabManager => _tabManager;

    private void OnValidate()
    {
        _tabManager = new TabControl(this);
    }

    public State[] GetStatesArray() => GetComponents<State>();
    public Component[] Components => GetComponents<Component>();
}