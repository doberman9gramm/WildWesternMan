using FSM;
using InteractableSpace;
using UnityEngine;

[RequireComponent(typeof(AgentInteraction))]
public class InteractionTransition : Transition
{
    [SerializeField] private string _text;

    private AgentInteraction agentInteraction;

    private void Awake()
    {
        agentInteraction = GetComponent<AgentInteraction>();
    }

    protected override void OnEnable()
    {
        base.OnEnable();
        agentInteraction.Interacte += EqualText;
    }

    protected override void OnDisable()
    {
        base.OnDisable();
        agentInteraction.Interacte -= EqualText;
    }

    //Разобраться тут с кодом через стринг может быть БАГ - передаваться неотлавливаемое пустое или неверное значение
    protected virtual void EqualText(Interactable interactable)
    {
        if (_text == interactable.GetText)
            Transit();
    }
}