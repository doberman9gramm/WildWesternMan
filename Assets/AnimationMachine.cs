using UnityEngine;

namespace AnimationMachine
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
            if (_currentBoolName != "")
                _animator.SetBool(_currentBoolName, false);

            _currentBoolName = boolName;

            _animator.SetBool(_currentBoolName, true);
        }
    }
}