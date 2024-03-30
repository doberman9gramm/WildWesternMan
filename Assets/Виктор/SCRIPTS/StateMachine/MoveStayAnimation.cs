using PlayerSpace;
using UnityEngine;

[RequireComponent(typeof(Moving))]
public class MoveStayAnimation : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private string _moveTriggerName = "Walk";
    [SerializeField] private string _stayTriggerName = "Idle";

    private Moving playerMoving;

    private void Awake() => playerMoving = GetComponent<Moving>();

    private void OnEnable() => playerMoving.IsWalk += ChooseAnimationAndSetToAnimator;

    private void OnDisable() => playerMoving.IsWalk -= ChooseAnimationAndSetToAnimator;

    private void ChooseAnimationAndSetToAnimator(bool isWalk) => _animator.SetTrigger(isWalk ? _moveTriggerName : _stayTriggerName);
}