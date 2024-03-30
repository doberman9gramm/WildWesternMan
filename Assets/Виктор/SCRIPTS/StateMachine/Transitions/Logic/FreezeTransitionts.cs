using FSM;
using System.Collections.Generic;
using UnityEngine;

public class FreezeTransitionts : MonoBehaviour
{
    [SerializeField] private List<Transition> _transitions;

    /// <summary>
    /// ¬ключить/выключить переходы
    /// </summary>
    public void Freeze(bool isEnable)
    {
        foreach (Transition transition in _transitions)
            transition.enabled = !isEnable;
    }
}
