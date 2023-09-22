using UnityEngine;

[ExecuteAlways]
public class Railway : MonoBehaviour
{
    [SerializeField] private Vector3 _start;
    [SerializeField] private Vector3 _end;
    [SerializeField] private float _radius;

    public Vector3 GetStart => _start + transform.position;
    public Vector3 GetEnd => _end + transform.position;

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red; 
        Gizmos.DrawSphere(_start + transform.position, _radius);
        Gizmos.DrawSphere(_end + transform.position, _radius);
        Gizmos.DrawLine(_start + transform.position, _end + transform.position);
    }
}