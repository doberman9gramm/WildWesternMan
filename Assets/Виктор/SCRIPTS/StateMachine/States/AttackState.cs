using UnityEngine;

namespace FSM
{
    public class AttackState : State
    {
        //Отрефакторить
        [SerializeField] private Transform _agent;
        [SerializeField] private Transform _target;
        [SerializeField] private GameObject _weapon;
        [SerializeField] private bool _hideWeaponOnDisable;

        private void OnEnable()
        {
            _weapon.SetActive(true);
        }

        private void OnDisable()
        {
            if (_hideWeaponOnDisable)
                _weapon.SetActive(false);
        }

        private void Update()
        {
            _agent.LookAt(new Vector3(_target.position.x, transform.position.y, _target.position.z));
        }
    }
}
