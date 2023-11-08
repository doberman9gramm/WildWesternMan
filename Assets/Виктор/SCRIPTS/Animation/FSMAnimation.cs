using UnityEngine;

public class FSMAnimation : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private string _nameOfTriggerAnimator = "None";

    private void OnEnable()
    {
        _animator.SetTrigger(_nameOfTriggerAnimator);
    }
}