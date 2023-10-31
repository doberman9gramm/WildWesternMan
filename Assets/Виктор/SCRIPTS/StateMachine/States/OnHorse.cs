using UnityEngine;

namespace FSM
{
    public class OnHorse : State
    {
        [SerializeField] private SitOnHorseTransition _SitOnHorseTransition;
        [SerializeField] private GameObject _player;

        private HorseSaddlePositions _horse;
        private Transform _playerParent;

        private void OnEnable()
        {
            _horse = _SitOnHorseTransition.TryGetCurrentHorse();//Получение лошади на которой будем сидеть
            _playerParent = _player.transform.parent;//Сохранение родителя, чтобы можно было потом вернуть его когда слезем с лошади
            _player.transform.SetParent(_horse.transform);
            _player.transform.position = _horse.GetSitPosition;
            _player.transform.rotation = _horse.transform.rotation;
        }

        private void OnDisable()
        {
            _player.transform.position = _horse.GetStandPosition;
            _player.transform.SetParent(_playerParent);
        }
    }
}