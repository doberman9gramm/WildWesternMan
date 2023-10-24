using HealthSpace;
using UnityEngine;

[RequireComponent(typeof(SphereTrigger))]
public class AutoAIM : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private SphereTrigger _sphereTrigger;

    private void Awake()
    {
        _sphereTrigger = GetComponent<SphereTrigger>();
    }

    private void Update()
    {
        if (_target != null)
            transform.LookAt(_target);
        else
            _target = TryGetEnemyTarget();
    }

    private Transform TryGetEnemyTarget()
    {
        Health enemyHealth = _sphereTrigger.TryGetComponentInTrigger<Health>();
        return enemyHealth?.GetComponent<Transform>();
    }

#if UNITY_EDITOR
    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(transform.position, _target.position);
    }
#endif
}