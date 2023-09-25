using UnityEngine;

namespace FSM
{
    /// <summary> 
    /// ������� �� ���������
    /// </summary>
    public class DistanceTransition : Transition
    {
        [SerializeField] private Transform _target;
        [SerializeField] private float _distance;
        [SerializeField] private DistanceLogic _transitionLogic;

        public void Update()
        {
            var currentDistance = Vector3.Distance(transform.position, _target.position);

            switch (_transitionLogic)
            {
                case DistanceLogic.More:
                    if (currentDistance > _distance)
                        NeedTransit = true;
                    break;

                case DistanceLogic.Less:
                    if (currentDistance < _distance)
                        NeedTransit = true;
                    break;

                case DistanceLogic.Equally:
                    if (currentDistance == _distance)
                        NeedTransit = true;
                    break;

                case DistanceLogic.EquallyOrMore:
                    if (currentDistance >= _distance)
                        NeedTransit = true;
                    break;

                case DistanceLogic.EquallyOrLess:
                    if (currentDistance <= _distance)
                        NeedTransit = true;
                    break;
            }


        }

        public enum DistanceLogic
        {
            More,
            Less,
            Equally,
            EquallyOrMore,
            EquallyOrLess,
        }
    }
}
