using PlayerSpace;
using UnityEngine;

public class WalkIdleAnimation : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    private const string _walk = "Walk";
    private const string _idle = "Idle";
    private PlayerMoving playerMoving;

    private void Awake() => playerMoving = GetComponent<PlayerMoving>();

    private void OnEnable() => playerMoving.IsWalk += ChooseAnimationAndSetToAnimator;

    private void OnDisable() => playerMoving.IsWalk -= ChooseAnimationAndSetToAnimator;

    private void ChooseAnimationAndSetToAnimator(bool isWalk) => _animator.SetTrigger(isWalk ? _walk : _idle);
}