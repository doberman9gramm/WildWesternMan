using UnityEngine;
using FSM;

public class ObjectInTrigger : Transition
{
    [SerializeField] private Trigger _trigger;
    [SerializeField] private bool _invertLogic;//Позволяет делать переход при отсутствии объекта в триггер зоне
    [SerializeField] private GameObject[] _objects;//можно сделать лист и проверять список объектов foreach

    private void Update()
    {
        foreach (var gameobject in _objects)
            if (_trigger.IsGameobjectInTrigger(gameobject) != _invertLogic)
                NeedTransit = true;

    }
}