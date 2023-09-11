using UnityEngine;
using FSM;

/// <summary> 
/// Если обьект(ы) существует в триггере то совершить переход
/// </summary>
public class ObjectsInTrigger : Transition
{
    [SerializeField] private GameObject[] _objects;
    [SerializeField] private Trigger _trigger;
    [SerializeField] private bool _invertLogic;

    private void Update()
    {
        foreach (var gameobject in _objects)
            if (_trigger.IsGameobjectInTrigger(gameobject) != _invertLogic)
                NeedTransit = true;

    }
}