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
            _horse = _SitOnHorseTransition.TryGetCurrentHorse();//��������� ������ �� ������� ����� ������
            _playerParent = _player.transform.parent;//���������� ��������, ����� ����� ���� ����� ������� ��� ����� ������ � ������
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