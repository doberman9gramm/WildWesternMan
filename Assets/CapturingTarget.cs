using HealthSpace;
using UnityEngine;

[RequireComponent(typeof(SphereTrigger))]
public class CapturingTarget : MonoBehaviour
{
    [SerializeField] private Vector3 _directionAdjustment;//костыль

    private Transform _target;
    private SphereTrigger _sphereTrigger;

    private void Awake()
    {
        _sphereTrigger = GetComponent<SphereTrigger>();
    }

    private void Update()
    {
        if (_target != null)
            transform.LookAt(_target.position + _directionAdjustment);
        else
            _target = TryGetEnemyTarget();
    }

    private Transform TryGetEnemyTarget()
    {
        Health enemyHealth = _sphereTrigger.TryGetComponentInTrigger<Health>();
        return enemyHealth?.GetComponent<Transform>();
    }
    
    private void OnDrawGizmos()
    {
        if (_target != null)
            Gizmos.DrawLine(transform.position, _target.position);
    }
}