using UnityEngine;

namespace FSM
{
    public class AttackState : State
    {
        //посмотреть и переделать
        [SerializeField] private Transform _agent;
        [SerializeField] private Transform _target;
        [SerializeField] private Vector3 _correctionLookAtTarget;
        [SerializeField] private GameObject _pistol;

        private void OnEnable()
        {
            _pistol.SetActive(true);
        }

        private void OnDisable()
        {
            _pistol.SetActive(false);
        }

        private void Update()
        {
            _agent.LookAt(new Vector3(_target.position.x, transform.position.y, _target.position.z) + _correctionLookAtTarget);
        }
    }
}
