using UnityEngine;

public class SetterAnimation : MonoBehaviour
{
    [field: SerializeField] public Animator Animator { get; private set; }
    [field: SerializeField] public string NameOfTriggerAnimator { get; private set; }

    private void OnEnable()
    {
        Animator.SetTrigger(NameOfTriggerAnimator);
    }
}