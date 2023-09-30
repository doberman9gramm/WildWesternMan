using UnityEngine;

namespace AnimationMachine
{
    public class AnimationMachineSetter : MonoBehaviour
    {
        [SerializeField] private AnimationMachine _animationmachine;
        [SerializeField] private string _animationBoolName;

        private void OnEnable()
        {
            _animationmachine.ChangeAnimation(_animationBoolName);
        }
    }
}