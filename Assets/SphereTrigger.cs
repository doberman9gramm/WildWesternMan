using UnityEngine;

public class SphereTrigger : MonoBehaviour
{
    [SerializeField] private float _radius = 3f;
    [SerializeField] private LayerMask layerMask;

    /// <summary>Ищет и возращает компонет из OverlapSphere за исключением самого себя</summary>
    public T TryGetComponentInTrigger<T>() where T : MonoBehaviour
    {
        foreach (Collider collider in Physics.OverlapSphere(transform.position, _radius, layerMask))
            if (collider.TryGetComponent(out T component) && component != this)
                return component;
        return null;
    }

#if UNITY_EDITOR
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, _radius);
    }
#endif
}