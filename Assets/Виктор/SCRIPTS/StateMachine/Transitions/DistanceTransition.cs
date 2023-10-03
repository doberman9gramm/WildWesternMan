using UnityEngine;

namespace FSM
{
    /// <summary> 
    /// Переход по дистанции
    /// </summary>
    public class DistanceTransition : Transition
    {
        [SerializeField] private Transform _target;
        [SerializeField] private float _distance;
        [SerializeField] private DistanceLogic _transitionLogic;

        public void Update()
        {
            var currentDistance = Vector3.Distance(transform.position, _target.position);

            if (currentDistance * ((int)_transitionLogic) > _distance * ((int)_transitionLogic))
                NeedTransit = true;
        }
    }

    public enum DistanceLogic : int
    {
        More = -1,
        Less = 1
    }
}