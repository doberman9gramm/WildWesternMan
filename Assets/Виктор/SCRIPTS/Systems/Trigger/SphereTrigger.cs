using UnityEngine;

public class SphereTrigger : MonoBehaviour
{
    [SerializeField] private float _radius = 3f;
    [SerializeField] private LayerMask layerMask;

    /// <summary>���� � ��������� �������� �� OverlapSphere �� ����������� ������ ����</summary>
    public T TryGetComponentInTrigger<T>() where T : MonoBehaviour
    {
        foreach (Collider collider in Physics.OverlapSphere(transform.position, _radius, layerMask))
            if (collider.TryGetComponent(out T component) && component != this)
                return component;
        return null;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, _radius);
    }
}