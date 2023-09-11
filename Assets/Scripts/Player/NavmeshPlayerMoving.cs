using InputNameSpace;
using UnityEngine;
using UnityEngine.AI;

namespace Player 
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class NavmeshPlayerMoving : MonoBehaviour
    {
        private NavMeshAgent _agent;

        private void Awake()
        {
            _agent = GetComponent<NavMeshAgent>();
        }

        private void Update()
        {
            _agent.SetDestination(transform.position + GetAxesInputs);
        }

        private Vector3 GetAxesInputs => new Vector3(AxisInput.Horizontal, 0, AxisInput.Vertical);
    }
}