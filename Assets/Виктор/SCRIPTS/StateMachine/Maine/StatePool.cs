using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using FSM;

[ExecuteAlways]
public class StatePool : MonoBehaviour
{
    public List<State> GetStatesList() => GetComponents<State>().ToList();
    public State[] GetStatesArray() => GetComponents<State>();
    public Component[] Components => GetComponents<Component>();
}