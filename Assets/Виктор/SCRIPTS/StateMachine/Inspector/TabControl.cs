using FSM;
using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class TabControl
{
    public int IndexOfCurrentTub = 0;
    private int _currentTabIndexBuffer = 0;
    private readonly StatesPool _statesPool;

    Type[] _excludedType =
     {
        typeof(Transform),
        typeof(StateMachine),
        typeof(StatesPool),
    };

    private int _componentsPoolCount = 0;

    [SerializeField] private List<Tab> Tabs = new List<Tab>();

    public TabControl(StatesPool statesPool)
    {
        _statesPool = statesPool;
    }
    public List<Tab> GetTabs => Tabs;

    public void OnInspectorGUIUpdate()
    {
        if (_statesPool == null)
            return;

        Debug.Log("Up");
        UpdateComponents(_statesPool.Components);
        CurrentTabChanged(IndexOfCurrentTub);
    }

    /// <summary> ���� ���������� ����������� ���������� �� �������� ���� ����������� </summary>
    private void UpdateComponents(Component[] components)
    {
        if (_componentsPoolCount < _statesPool.Components.Length)//���� ���������� ��������
        {
            Component[] components2 = new Component[components.Length - _componentsPoolCount];
            for (int i = 0; i < components2.Length; i++)
                components2[i] = components[_componentsPoolCount + i];
            SeparateComponents(components2);
            _componentsPoolCount = _statesPool.Components.Length;
        }
        else if (_componentsPoolCount > _statesPool.Components.Length)//���� ���������� �������
        {
            Debug.Log("��������� ������");

            //������ ����� ��� ����� � ������ ��������� ����� ��������� � �� ���� �������� ����
            /*bool isNullOrEmpty = Tabs?.Any() != true;
            Debug.Log(isNullOrEmpty);*/
            _componentsPoolCount = _statesPool.Components.Length;
        }
    }

    /// <summary> ���� ������� �����������, �� ������ ������ � �������� ����� </summary>
    private void CurrentTabChanged(int newTabIndex)
    {
        if (_currentTabIndexBuffer != newTabIndex)
        {
            Tabs[_currentTabIndexBuffer].SetComponentsHideFlag(HideFlags.HideInInspector);
            _currentTabIndexBuffer = newTabIndex;
            Tabs[_currentTabIndexBuffer].SetComponentsHideFlag(HideFlags.None);
            //���������� ��� � ������������ ���������� � ��������� ��� ������������ �������, � ���� ������� ��� ������
            _statesPool.enabled = false;
            _statesPool.enabled = true;
        }
    }
    /// <summary> ���������� ����������� �� ������ � ������ </summary>
    private void SeparateComponents(Component[] components)
    {
        foreach (Component component in components)
        {
            if (IsComponentOneOfTypes(component, _excludedType))//��������� ���������� �� ������������ ����
            { 

            }
            else if (component.GetType().IsSubclassOf(typeof(State)))//� ������ ����������� ��������� ������� ����� ������� ���������
            {
                Tabs.Add(new Tab(component as State));
            }
            else if (Tabs.Count > 0)
            {
                Tabs[IndexOfCurrentTub].Components.Add(component);
            }
        }
    }
    /// <summary> �������� �� ��������� ����� �� ����� </summary>
    public bool IsComponentOneOfTypes(Component component, Type[] types)
    {
        foreach (var type in types)
            if (component.GetType() == type)
                return true;
        return false;
    }
}