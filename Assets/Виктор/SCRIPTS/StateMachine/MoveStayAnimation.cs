using PlayerSpace;
using UnityEngine;

[RequireComponent(typeof(PlayerMoving))]
public class MoveStayAnimation : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private string _moveTriggerName = "Walk";
    [SerializeField] private string _stayTriggerName = "Idle";

    private PlayerMoving playerMoving;

    private void Awake() => playerMoving = GetComponent<PlayerMoving>();

    private void OnEnable() => playerMoving.IsWalk += ChooseAnimationAndSetToAnimator;

    private void OnDisable() => playerMoving.IsWalk -= ChooseAnimationAndSetToAnimator;

    private void ChooseAnimationAndSetToAnimator(bool isWalk) => _animator.SetTrigger(isWalk ? _moveTriggerName : _stayTriggerName);
}