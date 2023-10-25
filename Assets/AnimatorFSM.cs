using UnityEngine;

namespace FSM
{
    [RequireComponent(typeof(Animator))]
    public class AnimatorFSM : MonoBehaviour
    {
        private Animator animator;

        private void Awake() => animator = GetComponent<Animator>();

        public void ChangeAnimation(string nameOfAnimation) => animator.SetTrigger(nameOfAnimation);
    }
}