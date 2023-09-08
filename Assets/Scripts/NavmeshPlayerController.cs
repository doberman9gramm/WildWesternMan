using InputNameSpace;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class NavmeshPlayerController : MonoBehaviour
{
    private NavMeshAgent _navMeshAgent;

    private void Awake()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        _navMeshAgent.SetDestination(transform.position +
            new Vector3(AxisInput.Horizontal, 0, AxisInput.Vertical));
    }
}