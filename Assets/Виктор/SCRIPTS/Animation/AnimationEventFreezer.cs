using UnityEngine;

public class AnimationEventFreezer : FreezeTransitionts
{
    public void Freeze() => Freeze(true);
    public void UnFreeze() => Freeze(false);
}
