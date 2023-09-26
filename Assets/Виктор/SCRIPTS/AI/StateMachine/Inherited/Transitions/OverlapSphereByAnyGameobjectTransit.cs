/*using UnityEngine;

namespace FSM
{
    /// <summary> 
    /// Если один из обьектов существует в триггере то совершить переход
    /// </summary>
    public class OverlapSphereByAnyGameobjectTransit : Transition
    {
        [SerializeField] private Component[] _components;
        [SerializeField] private bool _invertLogic;

        private float radius = 2f;

        private void Update()
        {
            if (IsAnyGameobjectInOverlapSphere(_components))
                    NeedTransit = true;
        }

        private bool IsAnyGameobjectInOverlapSphere(Component[] components)
        {
            Collider[] colliderArray = Physics.OverlapSphere(transform.position, radius);
            
            foreach (Collider _collider in colliderArray)
                foreach (Component component in components)
                    if (true)
                        //чаво блять
                        return true;
            return false;
        }
    }
}

public static class ColliderExtensions
{
    //https://stackoverflow.com/questions/52475924/write-own-custom-method-with-out-parameter
    public static bool TryGetComponent<T>(this Collider collider, out T component) where T : class
    {
        component = collider.GetComponent<T>();
        return component != null;
    }
}*/