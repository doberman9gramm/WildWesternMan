using FSM;
using UnityEngine;

/// <summary> 
/// ���� ������ ���������� ��������� �������
/// </summary>
public class ObjectExistsTransition : Transition
{
    [SerializeField] private GameObject _gameObject;
    [SerializeField] private bool _objectExists;

    private void Update()
    {
        if (_objectExists == (_gameObject != null))
            NeedTransit = true;
    }
}