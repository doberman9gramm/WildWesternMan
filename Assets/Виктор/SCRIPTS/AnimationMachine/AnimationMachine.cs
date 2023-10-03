using UnityEngine;

namespace AnimationMachineSpace
{
    [RequireComponent(typeof(Animator))]
    public class AnimationMachine : MonoBehaviour
    {
        private Animator _animator;
        private string _currentBoolName;

        private void Awake()
        {
            _animator = GetComponent<Animator>();
        }

        public void ChangeAnimation(string boolName)
        {
            ExitCurrentAnimation();
            ChangeCurrentAnimation(boolName);
            EnterToCurrentAnimation();
        }

        private void ExitCurrentAnimation()
        {
            if (string.IsNullOrEmpty(_currentBoolName))
                _animator.SetBool(_currentBoolName, false);
        }

        private void ChangeCurrentAnimation(string boolName)
        {
            _currentBoolName = boolName;
        }

        private void EnterToCurrentAnimation()
        {
            _animator.SetBool(_currentBoolName, true);
        }
    }
}