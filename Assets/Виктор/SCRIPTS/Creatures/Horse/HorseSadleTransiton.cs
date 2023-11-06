using FSM;
using UnityEngine;

public class HorseSadleTransiton : Transition
{
    [SerializeField] private HorseSaddle _horseSaddle;
    [SerializeField] private bool _transitValue;

    protected override void OnEnable()
    {
        base.OnEnable();
        _horseSaddle.IsSaddle += Transition;
    }

    protected override void OnDisable()
    {
        base.OnDisable();
        _horseSaddle.IsSaddle -= Transition;
    }

    private void Transition(bool isSaddle)
    {
        if (_transitValue == isSaddle)
            Transit();
    }
}