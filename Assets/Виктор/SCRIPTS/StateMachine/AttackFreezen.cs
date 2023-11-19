using UnityEngine;

[RequireComponent(typeof(FreezeTransitionts), typeof(SetterAnimation))]
public class AttackFreezen : MonoBehaviour
{
    private FreezeTransitionts _freezeTransitionts;
    private SetterAnimation _animation;

    private void Awake()
    {
        _freezeTransitionts = GetComponent<FreezeTransitionts>();
        _animation = GetComponent<SetterAnimation>();
    }

    private void Update()
    {
        if (_animation.Animator.GetCurrentAnimatorStateInfo(0).IsName("HeavyAttack"))
        {
            _freezeTransitionts.Freeze(false);
        }
        else
        {
            _freezeTransitionts.Freeze(true);
        }
    }
}