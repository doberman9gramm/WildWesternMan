using PlayerSpace;
using UnityEngine;

namespace FSM
{
    public class OnHorse : State
    {
        [SerializeField] private SitOnHorseTransition _SitOnHorseTransition;
        [SerializeField] private Humanoide _player;

        [SerializeField] private SetterAnimation _gallop;
        [SerializeField] private SetterAnimation _idle;

        private HorseSaddle _horseSaddle;
        private Moving _horseMoving;

        private void OnEnable()
        {
            _horseSaddle = _SitOnHorseTransition.TryGetCurrentHorseSaddle();
            _horseSaddle?.SaddleHorse(_player, HorseSaddle.SaddleCondition.Saddle);

            foreach (Transform child in _horseSaddle.transform)
            {
                if (child.TryGetComponent(out Moving saddle))
                {
                    _horseMoving = saddle;
                    break;
                }
            }

            _horseMoving.IsWalk += ChangeAnimation;
        }

        private void OnDisable()
        {
            _horseSaddle?.SaddleHorse(_player, HorseSaddle.SaddleCondition.UnSaddle);
            _horseMoving.IsWalk -= ChangeAnimation;
        }

        private void ChangeAnimation(bool isGallop)
        {
            if (isGallop)
            {
                _gallop.enabled = true;
                _idle.enabled = false;
            }
            else
            {
                _idle.enabled = true;
                _gallop.enabled = false;
            }
        }
    }
}