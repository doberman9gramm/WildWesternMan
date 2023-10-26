using UnityEngine;

public class DrawLineGizmo : MonoBehaviour
{
    [SerializeField] private Transform _target0;
    [SerializeField] private Transform _target1;
    [SerializeField] private float _upMultiplier;

    private void OnDrawGizmos()
    {
        var multiplier = Vector3.up * _upMultiplier;
        Gizmos.color = Color.red;
        Gizmos.DrawLine(_target0.position + multiplier, _target1.position + multiplier);
    }
}