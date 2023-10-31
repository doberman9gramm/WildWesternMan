using InteractableSpace;
using UnityEngine;

public class SitOnHorseTransition : InteractionTransition
{
    private Interactable _horse;
    //�����������
    public HorseSaddlePositions TryGetCurrentHorse()
    {
        _horse.TryGetComponent(out HorseSaddlePositions horse);
        return horse;
    }

    protected override void EqualText(Interactable interactable)
    {
        base.EqualText(interactable);
        _horse = interactable;
    }
}