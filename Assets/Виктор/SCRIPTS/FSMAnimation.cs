using FSM;
using UnityEngine;

public class FSMAnimation : MonoBehaviour
{
    [SerializeField] private AnimatorFSM _animator;
    [SerializeField] private string _nameOfTriggerAnimator = "None";

    private void OnEnable()
    {
        _animator.ChangeAnimation(_nameOfTriggerAnimator);
    }
    private void OnDisable()
    {
        _animator.ChangeAnimation("Idle");
    }
}