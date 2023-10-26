using UnityEngine;

public class Horse : MonoBehaviour
{
    [SerializeField] private Vector3 _sitPosition;
    
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(_sitPosition + transform.position, .1f);
    }
}