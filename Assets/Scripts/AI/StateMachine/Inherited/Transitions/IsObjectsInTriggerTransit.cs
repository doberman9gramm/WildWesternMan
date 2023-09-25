using UnityEngine;

namespace FSM
{
    /// <summary> 
    /// Если обьект(ы) существует в триггере то совершить переход
    /// </summary>
    public class IsObjectsInTriggerTransit : Transition
    {
        [SerializeField] private GameObject[] _objects;
        [SerializeField] private bool _invertLogic;

        private void Update()
        {
            float interactRange = 2f;
            Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
            foreach (Collider collider in colliderArray)
                if (collider.TryGetComponent(out Component component))
                {

                }
                




            foreach (var gameobject in _objects)//переделать на события
                if (_trigger.IsGameobjectInTrigger(gameobject) != _invertLogic)
                    NeedTransit = true;
        }
    }
}