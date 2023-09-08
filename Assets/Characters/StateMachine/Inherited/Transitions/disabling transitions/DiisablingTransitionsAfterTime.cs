using FSM;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiisablingTransitionsAfterTime : MonoBehaviour
{
    //������� ������ �� FunctionTimer � �������� ������

    [SerializeField] private List<Transition> _transitions = new List<Transition>();

    public void TransitionEnableForAWhile(bool isEnabled, float time)
    {
        StartCoroutine(CoroutineTransitionEnableForAWhile(isEnabled, time));
    }

    private IEnumerator CoroutineTransitionEnableForAWhile(bool isEnabled, float time)
    {
        yield return null;//��� ���� ������� �� �������� �������� �� ������ 
        ToggleAllTransitions(isEnabled);
        yield return new WaitForSeconds(time);
        ToggleAllTransitions(!isEnabled);
        yield break;
    }

    private void ToggleAllTransitions(bool isEnabled)
    {
        foreach (var transition in _transitions)
            transition.enabled = isEnabled;
    }
}