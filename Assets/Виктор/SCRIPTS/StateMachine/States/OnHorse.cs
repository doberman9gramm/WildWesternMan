using UnityEngine;

namespace FSM
{
    public class OnHorse : State
    {
        [SerializeField] private SitOnHorseTransition _SitOnHorseTransition;
        [SerializeField] private Humanoide _player;

        private HorseSaddle _horse;

        private void OnEnable()
        {
            _horse = _SitOnHorseTransition.TryGetCurrentHorse();
            _horse?.SaddleHorse(_player, HorseSaddle.SaddleCondition.Saddle);
        }

        private void OnDisable()
        {
            _horse?.SaddleHorse(_player, HorseSaddle.SaddleCondition.UnSaddle);
        }
    }
}