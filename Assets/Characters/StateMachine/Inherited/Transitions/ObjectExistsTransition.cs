using FSM;
using UnityEngine;

public class ObjectExistsTransition : Transition
{
    //Если обьект существует совершить переход
    [SerializeField] private bool _objectExists;
    [SerializeField] private GameObject _gameObject;

    private void Update()
    {
        if (_objectExists == (_gameObject != null))
            NeedTransit = true;
    }
}
