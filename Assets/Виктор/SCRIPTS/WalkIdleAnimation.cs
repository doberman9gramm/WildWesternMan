using FSM;
using PlayerSpace;
using UnityEngine;

public class WalkIdleAnimation : MonoBehaviour
{
    [SerializeField] protected AnimatorFSM animatorFSM;

    private const string _walk = "Walk";
    private const string _idle = "Idle";
    private PlayerMoving playerMoving;

    private void Awake() => playerMoving = GetComponent<PlayerMoving>();

    private void OnEnable() => playerMoving.IsWalk += ChooseAnimationAndSetToAnimator;

    private void OnDisable() => playerMoving.IsWalk -= ChooseAnimationAndSetToAnimator;

    private void ChooseAnimationAndSetToAnimator(bool isWalk) => animatorFSM.ChangeAnimation(isWalk ? _walk : _idle);
}