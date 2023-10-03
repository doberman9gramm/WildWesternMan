using System.Collections.Generic;
using UnityEngine;
using FSM;

/// <summary>
/// ���� ����� ��������� ���� ���� ����� ����������� �� ������� �������
/// </summary>
[ExecuteAlways]
public class StatesPool : MonoBehaviour
{
    public List<State> _states;//����� ���������������

    private void OnValidate()
    {
        RefreshList();
    }

    private void RefreshList()
    {
        _states.Clear();

        foreach (State state in GetComponents<State>())
            _states.Add(state);
    }
}