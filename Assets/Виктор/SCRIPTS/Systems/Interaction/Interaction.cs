using UnityEngine;

namespace InteractableSpace
{
    //doc https://www.youtube.com/watch?v=LdoImzaY6M4&t=1287s
    public class Interaction : MonoBehaviour
    {
        [SerializeField] float interactRange = 2f;
        [SerializeField] LayerMask layer;

        private void Update()
        {
            Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange, layer);
            foreach (Collider collider in colliderArray)
                if (collider.TryGetComponent(out Interactable interactable))
                    interactable.Interact();
        }

        public Interactable GetInteractableObject()
        {
            Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange, layer);
            foreach (Collider collider in colliderArray)
                if (collider.TryGetComponent(out Interactable interactable))
                    return interactable;
            return null;
        }
    }
}