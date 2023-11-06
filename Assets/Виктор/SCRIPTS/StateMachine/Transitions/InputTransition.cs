using FSM;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputTransition : Transition
{
    [SerializeField] private InputActionReference _interactionInput;

    private void Update()
    {
        if (_interactionInput.action.ReadValue<float>() != 0)
            Transit();
    }
}