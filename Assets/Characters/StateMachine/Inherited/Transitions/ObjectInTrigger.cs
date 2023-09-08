using UnityEngine;
using FSM;

public class ObjectInTrigger : Transition
{
    [SerializeField] private Trigger _trigger;
    [SerializeField] private bool _invertLogic;//��������� ������ ������� ��� ���������� ������� � ������� ����
    [SerializeField] private GameObject[] _objects;//����� ������� ���� � ��������� ������ �������� foreach

    private void Update()
    {
        foreach (var gameobject in _objects)
            if (_trigger.IsGameobjectInTrigger(gameobject) != _invertLogic)
                NeedTransit = true;

    }
}