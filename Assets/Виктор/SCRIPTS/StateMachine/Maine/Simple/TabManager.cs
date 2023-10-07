using FSM;
using UnityEngine;

public class TabManager
{
    private readonly StatesPool _statesPool;
    private Tab _currentTab;

    System.Type[] _excludedType = 
    { 
        typeof(StateMachine),
        typeof(StatesPool),
    };

    public TabManager(StatesPool statesPool)
    {
        _statesPool = statesPool;

        //Какие компоненты должны быть изначально? StateMachine, StatesPool
        //Как удалить остальные компоненты?

        foreach (Component component in _statesPool.Components)
        {
            for (int i = 0; i < _excludedType.Length; i++)
            {
                if (component.GetType() == _excludedType[i])
                {
                    //Debug.Log(component.ToString());
                }
            }
        }
    }
}
public class Tab
{ 

}