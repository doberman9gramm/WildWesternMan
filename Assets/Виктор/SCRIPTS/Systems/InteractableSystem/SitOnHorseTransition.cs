using InteractableSpace;

public class SitOnHorseTransition : InteractionTransition
{
    private Interactable _horse;
    //Рефакторить
    public HorseSaddle TryGetCurrentHorse()
    {
        _horse.TryGetComponent(out HorseSaddle horse);
        return horse;
    }

    protected override void EqualText(Interactable interactable)
    {
        base.EqualText(interactable);
        _horse = interactable;
    }
}