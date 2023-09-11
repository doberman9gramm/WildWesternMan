using UnityEngine;
using FSM;

/// <summary> 
/// ���� ������(�) ���������� � �������� �� ��������� �������
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