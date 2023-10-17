using FSM;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[Serializable]
public class TabControl
{
    public int CurrentTubIndex = 0;

    private int _currentTabIndexBuffer = 0;
    private readonly StatesPool _statesPool;

    Type[] _excludedType =
     {
        typeof(Transform),
        typeof(StateMachine),
        typeof(StatesPool),
    };

    #region Debug
    [Header("Debug states lists")]
    private int _statesIndexPool = 0;
    [SerializeField] private List<Component> _statesPoolComponents = new List<Component>();
    [SerializeField] private List<Component> _excludedComponents = new List<Component>();
    [SerializeField] private List<Component> _NoExcludedComponents = new List<Component>();
    [SerializeField] private List<Component> _states = new List<Component>();
    #endregion

    [SerializeField] private List<Tab> Tabs = new List<Tab>();
    private Tab _currentTab;

    public string[] GetTabNames()
    {
        string[] names = new string[Tabs.Count];
        for (int i = 0; i < Tabs.Count; i++)
            names[i] = Tabs[i].Name;

        return names;
    }

    public TabControl(StatesPool statesPool)
    {
        _statesPool = statesPool;
    }

    public void OnInspectorGUIUpdate()
    {
        UpdateComponents();
        //Если текщая вкладка изменилась, то 
        //Скрыть все вкладки кроме текущий
        foreach (Tab tab in Tabs)
        {
            if (tab != _currentTab)
            {
                tab.SetComponentsHideFlag(HideFlags.HideInInspector);
            }
            else
            {
                tab.SetComponentsHideFlag(HideFlags.None);
            }
        }

        CurrentTabChanged(CurrentTubIndex);
    }
    /// <summary> Если количество компонентов изменилось то обновить лист компонентов </summary>
    private void UpdateComponents()
    {
        if (_statesIndexPool != _statesPool.Components.Length)
        {
            UpdateComponentsList();
            _statesIndexPool = _statesPoolComponents.Count;
        }
    }
    /// <summary> Если вкладку переключили, то скрыть старую и показать новую </summary>
    private void CurrentTabChanged(int newTabIndex)
    {
        if (_currentTabIndexBuffer != newTabIndex)
        {
            Debug.Log("Change");
            Tabs[_currentTabIndexBuffer].SetComponentsHideFlag(HideFlags.HideInInspector);
            _currentTab = Tabs[newTabIndex];
            _currentTabIndexBuffer = newTabIndex;
            Tabs[_currentTabIndexBuffer].SetComponentsHideFlag(HideFlags.None);
        }
    }

    private void UpdateComponentsList()
    {
        ClearAllList();
        _statesPoolComponents = _statesPool.Components.ToList<Component>();
        SeparateComponents(_statesPool.Components);
    }
    /// <summary> Разделение компонентов на группы в листах </summary>
    private void SeparateComponents(Component[] components)
    {
        foreach (Component component in components)
        {
            if (IsComponentOneOfTypeArray(component, _excludedType))//Исключить компоненты по исключенному списку
            {
                _excludedComponents.Add(component);
            }
            else if (component.GetType().IsSubclassOf(typeof(State)))//В случае обнаружения состояния создать новую вкладку состояния
            {
                _states.Add(component);
                _currentTab = new Tab(component as State);
                Tabs.Add(_currentTab);
            }
            else //В случае обнаружения компонента добавить его к активной вкладке
            {
                _currentTab.Components.Add(component);
            }
        }
    }

    private void ClearAllList()
    {
        _statesPoolComponents.Clear();
        _excludedComponents.Clear();
        _NoExcludedComponents.Clear();
        _states.Clear();
        Tabs.Clear();
    }
    /// <summary> Является ли компонент одним из типов </summary>
    private bool IsComponentOneOfTypeArray(Component component, Type[] types)
    {
        foreach (var type in types)
            if (component.GetType() == type)
                return true;
        return false;
    }
}

[Serializable]
public class Tab
{
    private State _state;
    public List<Component> Components = new List<Component>();
    public string Name => _state.GetType().Name;

    public Tab(State state)
    {
        _state = state;
    }

    public void SetComponentsHideFlag(HideFlags hideFlags)
    {
        _state.hideFlags = hideFlags;

        foreach (var component in Components)
            component.hideFlags = hideFlags;
    }
}