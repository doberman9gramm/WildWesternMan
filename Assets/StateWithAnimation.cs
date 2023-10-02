using AnimationMachineSpace;
using FSM;
using UnityEngine;

public class StateWithAnimation : State
{
    [SerializeField] private AnimationMachine AnimationMachine;
    [SerializeField] private string _boolAnmimationName;

    private void OnEnable()
    {
        AnimationMachine.ChangeAnimation(_boolAnmimationName);
    }
}