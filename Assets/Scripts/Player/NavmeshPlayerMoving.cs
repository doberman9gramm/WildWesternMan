using InputNameSpace;
using UnityEngine;
using UnityEngine.AI;

namespace Player 
{
    public class NavmeshPlayerMoving : MonoBehaviour
    {
        [SerializeField] private NavMeshAgent _agent;

        private void Update()
        {
            _agent.SetDestination(transform.position + GetAxesInputs);
        }

        private Vector3 GetAxesInputs => new Vector3(AxisInput.Horizontal, 0, AxisInput.Vertical);
    }
}