using FSM;
using System.Collections.Generic;
using UnityEngine;

public class TabManager : MonoBehaviour
{
    private StatesPool _statesPool;
    private List<Tab> _tabs = new List<Tab>();
    private List<State> _states;

    private int _tabsSelected = 0;
    private int _tabsSelectedBuffer = 0;

    public TabManager(StatesPool statesPool)
    {
        _statesPool = statesPool;
    }

    public void CreateTabs()
    {
        _tabs.Clear(); //Очистить лист
        _states = _statesPool.GetStatesList();//Полученить лист состояний
        //FillTabsList(_states.ToArray());//Добавить вкладки состояний в лист
        //DisplayingTabs();//Отобразить вкладки
        //ChooseTab();//Выбрать вкладку
    }
}