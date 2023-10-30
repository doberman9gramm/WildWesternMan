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

    //–азобратьс€ тут с кодом через стринг может передаватьс€ неотлавливаемое пустое или неверное значениеы
    private void EqualText(Interactable interactable)
    {
        if (_text == interactable.GetText)
            Transit();


        Debug.Log("–азобратьс€ тут с кодом через стринг может передаватьс€ неотлавливаемое пустое или неверное значениеы");
    }
}