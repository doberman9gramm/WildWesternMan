using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using FSM;

public class StatesPool : MonoBehaviour
{
    private TabManager _tabManager;

    private void OnValidate()
    {
        _tabManager = new TabManager(this);
    }
    public List<State> GetStatesList() => GetComponents<State>().ToList();
    public State[] GetStatesArray() => GetComponents<State>();
    public Component[] Components => GetComponents<Component>();
}